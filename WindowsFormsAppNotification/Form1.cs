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

namespace WindowsFormsAppNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            tbxResponse.Clear();
            string response = SendPushNotification();
            //SendPushAll();
            tbxResponse.Text = response;
        }
        private string SendPushAll()
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

                string serverKey = "AAAAIPWphRI:APA91bG3gcoKuQ4pKgKj4bSrD99PNbxRKXSeBflwW60KQ2DV1vtWoDnLpmbblxnP5xl5lnwp1_MpIzNMpygUC05b7DS9Run1AIAhJiXn4ev5X7Ko3j49qBo-xblFC6nf__vBYWoEha6Q"; // Something very long
                string senderId = "141560481042";
                string deviceId = "/topics/ALLFACTORY";
                //string deviceId = "dj9...c:APA...    .....WTw"; // Also something very long, 
                // got from android
                //string deviceId = "//topics/all";             // Use this to notify all devices, 
                // but App must be subscribed to 
                // topic notification
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                string title = txtTitle.Text, msg = txtMessenge.Text;

                var data = new
                {
                    to = deviceId,
                    //to = deviceId,
                    notification = new
                    {
                        body = msg,
                        title = title,
                        image = txtImage.Text,
                        sound = chkSound.Checked ? "Enable" : "Disable"
                    },
                    data = new
                    {
                        PLANT_NM = txtPlant.Text,
                        AREA = txtArea.Text,
                        MACHINE = txtMachine.Text,
                        WARNING = txtMessenge.Text
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
        private string SendPushNotification()
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

                string serverKey = "AAAAIPWphRI:APA91bG3gcoKuQ4pKgKj4bSrD99PNbxRKXSeBflwW60KQ2DV1vtWoDnLpmbblxnP5xl5lnwp1_MpIzNMpygUC05b7DS9Run1AIAhJiXn4ev5X7Ko3j49qBo-xblFC6nf__vBYWoEha6Q"; // Something very long
                string senderId = "141560481042";
                string deviceId = "/topics/" + txtTopic.Text;
                //string deviceId = "dj9...c:APA...    .....WTw"; // Also something very long, 
                // got from android
                //string deviceId = "//topics/all";             // Use this to notify all devices, 
                // but App must be subscribed to 
                // topic notification
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");

                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                string title = txtTitle.Text, msg =  txtMessenge.Text;

                var data = new
                {
                    to = deviceId,
                    //to = deviceId,
                    notification = new
                    {
                        body = msg,
                        title = title,
                        image = txtImage.Text,
                        sound = chkSound.Checked ? "Enable" : "Disable"
                    },
                    data = new
                    {
                        PLANT_NM = txtPlant.Text,
                        AREA = txtArea.Text,
                        MACHINE = txtMachine.Text,
                        WARNING = txtMessenge.Text
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

        private void tbxResponse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
