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
    public partial class CRUD_FRM_NOTIFY_NEW_VER : Form
    {
        public CRUD_FRM_NOTIFY_NEW_VER()
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
        private void BindingAndSendData()
        {
            try
            {
                //DataTable dt = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
                //string YMD = string.Empty, HMS = string.Empty, Factory = string.Empty, LINE_CD = string.Empty, MLINE_CD = string.Empty,
                //   Topics = string.Empty, Title = string.Empty, Content = string.Empty, urlImages = string.Empty, Line_NM = string.Empty,
                //   Area_NM = string.Empty, MachineNM = string.Empty, Warning = string.Empty, OP_CD = string.Empty, MC_ID = string.Empty, MC_CODE = string.Empty;
                //gridControl1.DataSource = dt;
                //if (dt != null && dt.Rows.Count > 0)
                //{
                //    lblTotal.Text = "Total: " + dt.Rows.Count;
                //    Factory = dt.Rows[0]["FACTORY"].ToString();
                //    YMD = dt.Rows[0]["YMD"].ToString();
                //    HMS = dt.Rows[0]["HMS"].ToString();
                //    Topics = dt.Rows[0]["LINE_NM"].ToString().Replace(" ", "");
                //    LINE_CD = dt.Rows[0]["LINE_CD"].ToString();
                //    MLINE_CD = dt.Rows[0]["MLINE_CD"].ToString();
                //    MC_ID = dt.Rows[0]["MC_ID"].ToString();
                //    MC_CODE = dt.Rows[0]["MC_CODE"].ToString();
                //    Title = dt.Rows[0]["TITLE"].ToString();
                //    Content = dt.Rows[0]["CONTENT"].ToString();
                //    urlImages = dt.Rows[0]["IMAGES_URL"].ToString();
                //    Line_NM = dt.Rows[0]["PLANT_NM"].ToString();
                //    Area_NM = dt.Rows[0]["OP_NM"].ToString();
                //    OP_CD = dt.Rows[0]["OP_CD"].ToString();
                //    MachineNM = dt.Rows[0]["MACHINE_NM"].ToString();
                //    Warning = dt.Rows[0]["CONTENT"].ToString();
                //    string res = SendPushNotification(Topics, Title, Content, urlImages, Line_NM, Area_NM, MachineNM, Warning);
                //    if (!string.IsNullOrEmpty(res))
                //    {
                //        lblResponse.Text = res;
                //        if (NOTIFY_DATA_UPDATE(Factory, YMD, HMS, LINE_CD, MLINE_CD, OP_CD, MachineNM, MC_ID, MC_CODE)) { }
                //        gridControl1.DataSource = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
                //    }
                //}
                //else
                //    lblTotal.Text = "Total: 0";


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                    //  lblTotal.Text = "Total: " + dt.Rows.Count;
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

                    //TestPostMessage(":factory:Plant: " + Line_NM +"\n Area: " +Area_NM + "\n Machine: " + MachineNM + "\n :scream:Warning: " + Warning + "\n Time: " + HMS);
                    string res = SendPushNotification(Topics, Title, Content, urlImages, Line_NM, Area_NM, MachineNM, MC_CODE, Warning);
                    SendPushNotificationIOS(Topics, Title, Content, urlImages, Line_NM, Area_NM, MachineNM, MC_CODE, Warning);
                    if (!string.IsNullOrEmpty(res))
                    {
                        lblResponse.Text = res;
                        if (NOTIFY_DATA_UPDATE(Factory, YMD, HMS, LINE_CD, MLINE_CD, OP_CD, MachineNM, MC_ID, MC_CODE))
                        {
                            dt = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
                            gridControl1.DataSource = dt;
                            lblTotal.Text = "Total: " + dt.Rows.Count;
                        }
                        //DataTable dt = NOTIFY_DATA_SELECT("Q", DateTime.Now.ToString());
                        //gridControl1.DataSource = dt;

                    }
                }
                else
                    lblTotal.Text = "Total: 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string SendPushNotificationIOS(string Topics, string Title, string Body, string urlImages, string Line_NM, string Area_NM, string MachineNM, string MachineCD, string Warning)
        {
            string response;
            try
            {
                // From: https://console.firebase.google.com/project/x.y.z/settings/general/android:x.y.z
                // From https://console.firebase.google.com/project/x.y.z/settings/

                string serverKey = "AAAAib5dSi8:APA91bHpGlSq18m8gZdlg0y5NdGUIwyW9rUnXzmzdt9PtJa0i0a_t1B-X8oBcmb7N5zdaIn1HJr0QxFiGPTgBq0b8G_mm593NFNWfZjHqcWA6UxdxvXOT4-Q8LkkNue0gW_XwBPp8rpD"; // Something very long
                string senderId = "591604304431";
                string deviceId = "/topics/013_IOS";
                //string deviceId = "dj9...c:APA...    .....WTw"; // Also something very long, 
                // got from android
                //string deviceId = "//topics/all";             // Use this to notify all devices, 
                // but App must be subscribed to 
                // topic notification
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                string title = Title, msg = Body;

                var data = new
                {
                    to = deviceId,
                    //   to = deviceId,
                    data = new
                    {
                        TITLE = Title,
                        BODY = msg,
                        MC_CD = MachineNM,
                        MC_NM = MachineNM,
                        AREA = string.Concat(Line_NM, " - ", Area_NM),
                        DESC = Warning,
                        TIME = DateTime.Now.ToString("dd/MM HH:mm"),
                        KIND_IMG = "BACKPART"
                    }
                    ,
                    notification = new
                    {
                        body = msg,
                        title = title,
                        image = urlImages,
                        sound = "Enable"
                    }
                };



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
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response;
        }

      

        class AxisTarget
        {
            [JsonProperty("Simulator Target Bundle")]
            public string TARGET_PHUOC { get; set; }
        }
        private string SendPushNotification(string Topics, string Title, string Body, string urlImages, string Line_NM, string Area_NM, string MachineNM, string MachineCD, string Warning)
        {
            string response;

            try
            {
                // From: https://console.firebase.google.com/project/x.y.z/settings/general/android:x.y.z

                // Projekt-ID: x.y.z
                // Web-API-Key: A...Y (39 chars)
                // App-ID: 1:...:android:...

                // From https://console.firebase.google.com/project/x.y.z/settings/
                // cloudmessaging/android:x,y,z
                // Server-Key: AAAA0...    ...._4

                string serverKey = "AAAAib5dSi8:APA91bHpGlSq18m8gZdlg0y5NdGUIwyW9rUnXzmzdt9PtJa0i0a_t1B-X8oBcmb7N5zdaIn1HJr0QxFiGPTgBq0b8G_mm593NFNWfZjHqcWA6UxdxvXOT4-Q8LkkNue0gW_XwBPp8rpD"; // Something very long
                string senderId = "591604304431";
                string deviceId = "/topics/013";
                //string deviceId = "dj9...c:APA...    .....WTw"; // Also something very long, 
                // got from android
                //string deviceId = "//topics/all";             // Use this to notify all devices, 
                // but App must be subscribed to 
                // topic notification
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                string title = Title, msg = Body;
                string target = "com.csi.scadaIos";
                AxisTarget tar = new WindowsFormsAppNotification.CRUD_FRM_NOTIFY_NEW_VER.AxisTarget { TARGET_PHUOC = target };

            var data = new
                {
                    to = deviceId,
                    //   to = deviceId,
                    data = new
                    {
                        TITLE = Title,
                        BODY = msg,
                        MC_CD = MachineNM,
                        MC_NM = MachineNM,
                        AREA = string.Concat(Line_NM, " - ", Area_NM),
                        DESC = Warning,
                        TIME = DateTime.Now.ToString("dd/MM HH:mm"),
                        KIND_IMG = "BACKPART",
                        picture_url = urlImages
                    },
                //aps = new
                //{
                //notification = new
                //{
                //    title = "Đây là Alert header",
                //    body = "Đây là Body",
                //},
                //sound = "default",
                //category = "message",
                //badge = 1
                //PLANT_NM = Line_NM,
                //AREA = Area_NM,
                //MACHINE = MachineNM,
                //WARNING = Warning,
                //TITLE = title,
                //DATE = DateTime.Now.ToString(),

            };

               

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
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response;
        }

       

        int cCount = 0;
        private async void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                cCount++;
                lblTimer.Text = "Timer: " + cCount;
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
            string res = SendPushNotification("013", "Xin chào!", "Hôm nay bạn thế nào?", "https://thumbs.dreamstime.com/b/happy-cat-closeup-portrait-funny-smile-cardboard-young-blue-background-102078702.jpg", "Some Plant", "SomeWhere", "This is a test Data (BP-001-TEST-AAA)", "BP-001-TEST-AAA", "PV:00,Min:00,Max:00");
            if (!string.IsNullOrEmpty(res))
            {
                lblResponse.Text = res;
            }
            string res1 = SendPushNotificationIOS("013", "Xin chào!", "Hôm nay bạn thế nào?", "https://thumbs.dreamstime.com/b/happy-cat-closeup-portrait-funny-smile-cardboard-young-blue-background-102078702.jpg", "Some Plant", "SomeWhere", "This is a test Data (BP-001-TEST-AAA)", "BP-001-TEST-AAA", "PV:00,Min:00,Max:00");
            if (!string.IsNullOrEmpty(res))
            {
                lblResponse.Text = res1;
            }
        }
        // I suggest to create by specifying a name for instance while we have multiple projects to setup.
        
        private  void btnTestSDKAdmin_Click(object sender, EventArgs e)
        {
            string res = SendPushNotificationIOS("013", "Thông Báo UI IOS", "ABCDEF Nội dung", "", "013-001", "Assembly", "Backpart Molding (BP-001-XXX-AAA)", "BP-001-XXX-AAA", "PV:50,Min:55,Max:60");
            if (!string.IsNullOrEmpty(res))
            {
                lblResponse.Text = res;
            }
        }
    
        private void CRUD_FRM_NOTIFY_NEW_VER_Load(object sender, EventArgs e)
        {
           
        }
    }
}
