using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppNotification
{
    class NotifysModel
    {
        public string TypeDevice;
        public string Title;
        public string Body;
        public string urlImages;
        public string Line_cd;
        public string Line_Nm;
        public string Area_NM;
        public string MachineCD;
        public string MachineNM;
        public string Warning;
        public NotifysModel(string TypeDevice,string Title, string Body, string urlImages, string Line_cd, string Line_Nm, string Area_NM, string MachineCD, string MachineNM,string Warning)
        {
            this.TypeDevice = TypeDevice;
            this.Title = Title;
            this.Body = Body;
            this.urlImages = urlImages;
            this.Line_cd = Line_cd;
            this.Line_Nm = Line_Nm;
            this.Area_NM = Area_NM;
            this.MachineCD = MachineCD;
            this.MachineNM = MachineNM;
            this.Warning = Warning;
        }
    }
}
