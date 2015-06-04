using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace classLib {
    public class DbSettings {
        #region Properties
        private string hostname;
        public string Hostname {
            get {
                return hostname;
            }
            set {
                clearCStr();
                hostname = value;
            }
        }

        private string database;
        public string Database { 
            get {
                return database;
            } 
            set {
                clearCStr();
                database = value;
            }
        }

        private Boolean winAuth;
        public Boolean WindowsAuth { 
            get {
                return winAuth;
            }
            set {
                clearCStr();
                winAuth = value;
            }
        }

        private string username;
        public string Username {
            get {
                return username;
            }
            set {
                clearCStr();
                username = value;
            }
        }

        private string password;
        public string Password {
            get {
                return password;
            }
            set {
                clearCStr();
                password = value;
            }
        }

        private string appname;
        public string AppName {
            get {
                return appname;
            }
            set {
                clearCStr();
                appname = value;
            }
        }
        #endregion Properties

        #region Public Methods
        public DbSettings() {
            clearCStr();
        }

        private string cstr;
        public string connectionString {
            get {
                if (cstr.Length <= 0) {
                    cstr = BuildConnectionString();
                }
                return cstr;
            }
        }

        public string DbType { get; set; }

        #endregion Public Methods

        #region Other
        private void clearCStr() {
            DbType = "net";
            cstr = "";
        }

        private string BuildConnectionString() {
            string cs;
            string tmp;
            //
            // Example connection strings.
            //
            // ConnectionString = "Data Source=SQL-SVR\\MSSQLR2;Initial Catalog=abb;Integrated Security=True";
            // ConnectionString = "Data Source=localhost;Initial Catalog=abb;Integrated Security=True";
            // Data Source=SQL-SVR\MSSQLR2;Initial Catalog=abb;Integrated Security=True;Application Name=FileMonitor;Max Pool Size=200;Net=dbmsrpcn;Packet Size=1024;
         
            cs = "Server=";
            tmp = Hostname;
            cs = cs + tmp + ";Database=";
            tmp = Database;

            if ( WindowsAuth )
                cs = cs + tmp + ";Integrated Security=True;";
            else {
                cs = cs + tmp + ";User Id=" + Username +
                    ";Password=" + Password + ";";
            }

            //            cs = cs; // +"Application Name=FileMonitor;Max Pool Size=200;Packet Size=1024;";
            cs = cs + "Application Name=" + AppName + ";";

            return cs;
        }

        // https://wizpert.com/wizdom/sql-connection-test
        public Boolean Test() {
            Boolean result;
            result = false;

            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = connectionString;
            try {
                sqlconn.Open();
                result = true;
                sqlconn.Close();
            }
            catch (Exception) {
                result = false;
            }
            return result;
        }
        #endregion
    }
}
