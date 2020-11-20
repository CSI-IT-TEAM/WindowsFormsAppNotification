using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNotification
{
    public class Database
    {
        //Sample [How to use] => Form1
        #region Read XML file
        private static DataTable ReadXML(string file)
        {
            DataTable table = new DataTable("Item");
            try
            {
                DataSet lstNode = new DataSet();
                lstNode.ReadXml(file);
                table = lstNode.Tables["Item"];
                return table;
            }
            catch (Exception ex)
            {
                return table;
            }
        }


        public static DataTable ReadConfig(string file)
        {
            DataTable table = new DataTable("Item");
            try
            {
                DataSet lstNode = new DataSet();
                lstNode.ReadXml(file);
                table = lstNode.Tables["Item"];
                return table;
            }
            catch (Exception ex)
            {
                return table;
            }
        }
        #endregion

        #region Oracle TNS

        public static OracleConnection GetDBConnectionCMMS()
        {
            string host = "172.30.10.21";
            int port = 1521;
            string sid = "VJCMMS";
            string user = "CMMS";
            string password = "CMMS";

            return Database.GetDBConnection(host, port, sid, user, password);
        }

        public static OracleConnection GetDBConnectionHUBICVJ()
        {
            string host = "211.54.128.21";
            int port = 1521;
            string sid = "HUBICVJ";
            string user = "HUBICVJ";
            string password = "HUBICVJ";

            return Database.GetDBConnection(host, port, sid, user, password);
        }

        public static OracleConnection GetDBConnectionVJREAL(string ConnectionName)
        {
            string host = "211.54.128.21";
            int port = 1521;
            string sid = "VJEDB";
            string user = ConnectionName;
            string password = ConnectionName;

            return Database.GetDBConnection(host, port, sid, user, password);
        }


        #endregion

        #region SQL Server (Nhớ Khai báo IP máy Local nhe!)

        public static SqlConnection SQL_TestingLocal()
        {
            string datasource = "172.30.30.41";
            string database = "TEST";
            string username = "sa";
            string password = "sa";
            return Database.GetDBSQLConnection(datasource, database, username, password);
        }

        //Sử dụng This func để đọc từ file Config
        public static SqlConnection SQL_ConfigTestingLocal()
        {
            DataTable dtXML = ReadXML(Application.StartupPath + "\\Config.XML");
            string datasource = dtXML.Rows[0]["datasource"].ToString();
            string database = dtXML.Rows[0]["database"].ToString();
            string username = dtXML.Rows[0]["username"].ToString();
            string password = dtXML.Rows[0]["password"].ToString();

            return Database.GetDBSQLConnection(datasource, database, username, password);
        }
        #endregion

        #region Connection String Oracle
        public static OracleConnection
                     GetDBConnection(string host, int port, String sid, String user, String password)
        {

            Console.WriteLine("Getting Connection ...");

            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user +";";


            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }
        #endregion

        #region Connection String SQL Server
        public static SqlConnection
                GetDBSQLConnection(string datasource, string database, string username, string password)
        {

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
        #endregion
    }
}
