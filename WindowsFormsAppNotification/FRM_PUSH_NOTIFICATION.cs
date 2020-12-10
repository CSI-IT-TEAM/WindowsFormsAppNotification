using FirebaseAdmin.Messaging;
using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ZaloDotNetSDK;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;

namespace WindowsFormsAppNotification
{
    public partial class FRM_PUSH_NOTIFICATION : Form
    {
        public FRM_PUSH_NOTIFICATION()
        {
            InitializeComponent();
        }
        
        DataTable dt = new DataTable();
        private DataTable NOTIFY_DATA_SELECT(string ARG_QTYPE, string ARG_DATE)
        {
            try
            {
                using (OracleConnection conn = Database.GetDBConnectionVJREAL("MES"))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("MES.PKG_SMT_SCADA_COCKPIT.NOTIFY_DATA_SELECT", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("ARG_QTYPE", OracleDbType.Varchar2).Value = ARG_QTYPE;
                    command.Parameters.Add("ARG_DATE", OracleDbType.Varchar2).Value = ARG_DATE;
                    //command.Parameters.Add("ARG_LOCATION", OracleDbType.Varchar2).Value = ARG_QTYPE;
                    //command.Parameters.Add("ARG_EMP", OracleDbType.Varchar2).Value = ARG_EMP;
                    //command.Parameters.Add("ARG_IS_MANUAL", OracleDbType.Varchar2).Value = ARG_IS_MANUAL ? "1" : "0";
                    //command.Parameters.Add("OUT_TOT_M", OracleDbType.Int32).Value = ParameterDirection.Output;
                    //command.Parameters.Add("OUT_TOT", OracleDbType.Int32).Value = ParameterDirection.Output;
                    command.Parameters.Add("OUT_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    using (DataTable dt = new DataTable())
                    {
                        (new OracleDataAdapter(command)).Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private bool NOTIFY_DATA_UPDATE(string ARG_FACTORY, string ARG_YMD, string ARG_HMS, string ARG_LINE_CD, string ARG_MLINE_CD, string ARG_OP_CD, string ARG_MC_NAME, string ARG_MC_ID, string ARG_MC_CODE)
        {
            try
            {
                using (OracleConnection conn = Database.GetDBConnectionVJREAL("MES"))
                {
                    conn.Open();
                    OracleCommand command = new OracleCommand("MES.PKG_SMT_SCADA_COCKPIT.NOTIFY_DATA_UPDATE", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("ARG_FACTORY", OracleDbType.Varchar2).Value = ARG_FACTORY;
                    command.Parameters.Add("ARG_YMD", OracleDbType.Varchar2).Value = ARG_YMD;
                    command.Parameters.Add("ARG_HMS", OracleDbType.Varchar2).Value = ARG_HMS;
                    command.Parameters.Add("ARG_LINE_CD", OracleDbType.Varchar2).Value = ARG_LINE_CD;
                    command.Parameters.Add("ARG_MLINE_CD", OracleDbType.Varchar2).Value = ARG_MLINE_CD;
                    command.Parameters.Add("ARG_OP_CD", OracleDbType.Varchar2).Value = ARG_OP_CD;
                    command.Parameters.Add("ARG_MC_NAME", OracleDbType.Varchar2).Value = ARG_MC_NAME;
                    command.Parameters.Add("ARG_MC_ID", OracleDbType.Varchar2).Value = ARG_MC_ID;
                    command.Parameters.Add("ARG_MC_CODE", OracleDbType.Varchar2).Value = ARG_MC_CODE;
                    command.ExecuteNonQuery();
                    return true;

                }
            }
            catch
            {
                return false;
            }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            cCount = 0;
            dt = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
            while (dt != null && dt.Rows.Count > 0)
            {
                await DoTasks(dt);
            }
        }
        private async Task DoTasks(DataTable dt)
        {
            foreach (DataRow item in dt.Rows)
            {
                await Task.Delay(1000);
                DoWork(item);
            }
        }

        private void DoWork(DataRow item)
        {
            try
            {
                string YMD = string.Empty, HMS = string.Empty, Factory = string.Empty, LINE_CD = string.Empty, MLINE_CD = string.Empty,
                     Topics = string.Empty, Title = string.Empty, Content = string.Empty, urlImages = string.Empty, Line_NM = string.Empty,
                     Area_NM = string.Empty, MachineNM = string.Empty, Warning = string.Empty, OP_CD = string.Empty, MC_ID = string.Empty, MC_CODE = string.Empty;

                if (item != null)
                {
                    Factory = item["FACTORY"].ToString();
                    YMD = item["YMD"].ToString();
                    HMS = item["HMS"].ToString();
                    Topics = item["LINE_NM"].ToString().Replace(" ", "");
                    LINE_CD = item["LINE_CD"].ToString();
                    MLINE_CD = item["MLINE_CD"].ToString();
                    MC_ID = item["MC_ID"].ToString();
                    MC_CODE = item["MC_CODE"].ToString();
                    Title = item["TITLE"].ToString();
                    Content = item["CONTENT"].ToString();
                    urlImages = item["IMAGES_URL"].ToString();
                    Line_NM = item["PLANT_NM"].ToString();
                    Area_NM = item["OP_NM"].ToString();
                    OP_CD = item["OP_CD"].ToString();
                    MachineNM = item["MACHINE_NM"].ToString();
                    Warning = item["CONTENT"].ToString();
                    List<NotifysModel> lstModel = new List<WindowsFormsAppNotification.NotifysModel>();
                    lstModel.Add(new NotifysModel("ANDROID", Title, Content, urlImages,LINE_CD, Line_NM, Area_NM, MC_CODE, MachineNM, Warning));
                    lstModel.Add(new NotifysModel("IOS", Title, Content, urlImages, LINE_CD, Line_NM, Area_NM, MC_CODE, MachineNM, Warning));
                    foreach (NotifysModel model in lstModel)
                    {
                        string res = SendPushNotification(model);
                        if (!string.IsNullOrEmpty(res))
                        {
                            lblResponse.Text = res;
                            if (NOTIFY_DATA_UPDATE(Factory, YMD, HMS, LINE_CD, MLINE_CD, OP_CD, MachineNM, MC_ID, MC_CODE))
                            {
                                dt = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
                                gridControl1.DataSource = dt;
                                lblTotal.Text = "Notify Count: " + dt.Rows.Count;
                            }
                        }
                    }
                }
                else
                    lblTotal.Text = "Notify Count: 0";
            }
            catch
            {
            }
        }
        private string SendPushNotification(NotifysModel model)
        {
            string response;

            try
            {
                // From: https://console.firebase.google.com/project/x.y.z/settings/general/android:x.y.z
                // From https://console.firebase.google.com/project/x.y.z/settings/

                string serverKey = "AAAAib5dSi8:APA91bHpGlSq18m8gZdlg0y5NdGUIwyW9rUnXzmzdt9PtJa0i0a_t1B-X8oBcmb7N5zdaIn1HJr0QxFiGPTgBq0b8G_mm593NFNWfZjHqcWA6UxdxvXOT4-Q8LkkNue0gW_XwBPp8rpD"; // Something very long
                string senderId = "591604304431";
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                object data = "";
                switch (model.TypeDevice) //VÌ 2 LOẠI THIẾT BỊ CHUỖI JSON LÀ KHÁC NHAU
                {
                    case "ANDROID":
                        data = new
                        {
                            to = string.Concat("/topics/", model.Line_cd),
                            data = new
                            {
                                TITLE = model.Title,
                                BODY = model.Body,
                                MC_CD = model.MachineNM,
                                MC_NM = model.MachineCD,
                                AREA = string.Concat(model.Line_Nm, " - ", model.Area_NM),
                                DESC = model.Warning,
                                TIME = DateTime.Now.ToString(),
                                KIND_IMG = "BACKPART",
                                picture_url = model.urlImages
                            }
                        };
                        break;
                    case "IOS":
                        data = new
                        {
                            to = string.Concat("/topics/", model.Line_cd,"_",model.TypeDevice),
                            data = new
                            {
                                TITLE = model.Title,
                                BODY = model.Body,
                                MC_CD = model.MachineNM,
                                MC_NM = model.MachineCD,
                                AREA = string.Concat(model.Line_Nm, " - ", model.Area_NM),
                                DESC = model.Warning,
                                TIME = DateTime.Now.ToString(),
                                KIND_IMG = "BACKPART",
                                picture_url = model.urlImages
                            },
                            notification = new
                            {
                                title = model.Title,
                                body = model.Body,
                                image = model.urlImages,
                                sound = "Enable"
                            }
                        };
                        break;
                }
                var serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", serverKey));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                response = sResponseFromServer;
                            }
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                return "error" + ex.Message;
            }

           
        }

       

        int cCount = 0;
        private async void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                cCount++;
                lblTimer.Text = "Remain: " +(60- cCount);
                if (cCount >= 60)
                {
                    cCount = 0;
                    dt = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
                    while (dt != null && dt.Rows.Count > 0)
                    {
                        await DoTasks(dt);
                    }
                }
            }
            catch
            {
                cCount = 0;
            }
        }

        private void SendMsgZalo()
        {
            ZaloAppInfo appInfo = new ZaloAppInfo(4287047223436224874, "L1XL26QSnY2U6MWH850R", "http://test.net");
            ZaloAppClient appClient = new ZaloAppClient(appInfo);
            string loginUrl = appClient.getLoginUrl();
            //Process.Start(loginUrl);
            string code = "0FZeCRokLqeEykuokAHJJ0Jpwp2qiZu1VPhX0Q6jFtjAZy0BcgSB8KQhlZYKzsG1NEwxVfFNHLzuseDFbln9Qb_WgagJuXLC9hkhLTBcNdzk-8DWgVfvKMlWksZUrm5h5FkXOAJVV4jtmQ5fgVX2Jnpddr3Ym6TXBFdJHDtVQ3Wsv8CcuR9CALUxWWUIi5u198pdCEopMYa1jkKZiBm3B5QhvHRggGOGDAV9A_6NV3GtjBelsfm44MkZtmsyY2SeMQx7BQktEn1awlarsTCYJM64Rur8jxbNJ0";
            JObject token = appClient.getAccessToken(code);
            var access_token = token["access_token"].ToString();
            //JObject profile = appClient.getProfile(access_token, "id, name, birthday");
            JObject friends = appClient.getFriends(access_token, 0, 100, "id, name, picture");
            JObject sendMessage = appClient.sendMessage(access_token, 3852331461584449386, "test", "");
        }
        void TestPostMessage(string msg)
        {
            //  var urlWithAccessToken = "https://hooks.slack.com/services/{YOUR}/{ACCESS}/{TOKENS}";

            var urlWithAccessToken = "https://hooks.slack.com/services/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";
            var client = new SlackClient(urlWithAccessToken);

            client.PostMessage(username: "Mr. Phuoc",
                       text: msg,
                       channel: "#macetl");
        }
        private void btnSlack_Click(object sender, EventArgs e)
        {
            TestPostMessage(":star-struck:Hello, Everyone!");
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {
            SendMsgZalo();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<NotifysModel> lstModel = new List<WindowsFormsAppNotification.NotifysModel>();
            lstModel.Add(new NotifysModel("ANDROID", "Phước Xin Chào!", "Hôm nay bạn thế nào?", "", "013", "Plant G", "SomeWhere", "BP-001-TEST-MACHINE", "THIS IS A TEST MACHINE", "Thông báo nhiệt độ"));
            lstModel.Add(new NotifysModel("IOS", "Phước Xin Chào!", "Hôm nay bạn thế nào?", "", "013", "Plant G", "SomeWhere", "BP-001-TEST-MACHINE", "THIS IS A TEST MACHINE", "Thông báo nhiệt độ"));
            foreach (NotifysModel model in lstModel)
            {
                string res = SendPushNotification(model);
                if (!string.IsNullOrEmpty(res))
                {
                    lblResponse.Text = res;
                }
            }
           
        }
        // I suggest to create by specifying a name for instance while we have multiple projects to setup.
        
       
    
        private void CRUD_FRM_NOTIFY_NEW_VER_Load(object sender, EventArgs e)
        {
           
        }
    }
}
