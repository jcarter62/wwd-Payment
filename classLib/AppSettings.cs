using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Xml;
using System.Net.Mail;

namespace classLib {

    /// <summary>
    /// This class is used to abstract application settings.
    /// </summary>
    public class AppSettings {
        private string _AppName = "Payments";

        public DbSettings wmis;
        public DbSettings mas500;

        private string _Key = Keys.key;

        private SettingsFile sf;
        private string _filename;

        #region Properties
        public string Key {
            get { return _Key; }
        }

        public string AppName { get { return _AppName; } }

        public string SmtpServer { get; set; }
        public string SmtpPort { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public bool SendViaOutlook { get; set; }
        public bool SmtpAuthReq { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }

        #endregion Properties

        #region Startup

        /// <summary>
        ///
        /// </summary>
        public AppSettings() {
            _filename = _AppName + ".xml"; // "settings.xml";
            AppSettingsInit();
        }

        public AppSettings(string filename) {
            _filename = filename;
            AppSettingsInit();
        }

        private void AppSettingsInit() {
            sf = new SettingsFile(_filename);
            wmis = new DbSettings();
            mas500 = new DbSettings();
            Load();
        }

        #endregion Startup

        #region Methods

        private void loadDbInfo(DbSettings db, string prefix) {
            db.Hostname = GetString(prefix + "Hostname");
            db.Database = GetString(prefix + "Database");
            db.Username = GetString(prefix + "Username", true);
            db.Password = GetString(prefix + "Password", true);
            string yn;
            yn = GetString(prefix + "WindowsAuthentication");
            db.WindowsAuth = (yn == "Y");
        }

        /// <summary>
        /// Populate class properties with settings, Server, Database, Username, ...
        /// </summary>
        public void Load() {
            loadDbInfo(wmis, "wmis");
            loadDbInfo(mas500, "mas500");
            loadOtherInfo();
        }

        private void loadOtherInfo() {
            SmtpServer = GetString("SmtpServer");
            SmtpPort = GetString("SmtpPort");
            EmailFrom = GetString("EmailFrom");
            EmailTo = GetString("EmailTo");
            SendViaOutlook = (GetString("SendViaOutlook") == "Yes" ? true : false);
            SmtpAuthReq = (GetString("SmtpAuthReq") == "Yes" ? true : false);
            SmtpUser = GetString("SmtpUser", true);
            SmtpPass = GetString("SmtpPass", true);
        }

        private void saveDbInfo(DbSettings db, string prefix) {
            WriteString(prefix + "Hostname", db.Hostname);
            WriteString(prefix + "Database", db.Database);
            WriteString(prefix + "Username", db.Username, true);
            WriteString(prefix + "Password", db.Password, true);
            if (db.WindowsAuth) {
                WriteString(prefix + "WindowsAuthentication", "Y");
            }
        }

        /// <summary>
        /// Save values to settings file.
        /// </summary>
        public void Save() {
            saveDbInfo(wmis, "wmis");
            saveDbInfo(mas500, "mas500");
            saveOtherInfo();
        }

        private void saveOtherInfo() {
            WriteString("SmtpServer", SmtpServer);
            WriteString("SmtpPort", SmtpPort);
            WriteString("EmailFrom", EmailFrom);
            WriteString("EmailTo", EmailTo);
            WriteString("SendViaOutlook", (SendViaOutlook ? "Yes" : "No"));
            WriteString("SmtpAuthReq", (SmtpAuthReq ? "Yes" : "No"));
            WriteString("SmtpUser", SmtpUser, true);
            WriteString("SmtpPass", SmtpPass, true);
        }

        #endregion Methods

        #region GetSet Methods        
        /// <summary>
        /// Get Setting, clear text
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private string GetString(string Name) {
            return GetString(Name, false);
        }

        /// <summary>
        /// Get Setting, clear text or decrypted based on parameter
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Decrypt"></param>
        /// <returns></returns>
        private string GetString(string Name, Boolean Decrypt) {
            string se;
            se = sf.ReadString(Name, "");

            if (Decrypt) {
                if (se.Length > 0)
                    se = EncDec.Decrypt(sf.ReadString(Name, ""), Key + Name);
                else
                    se = "";
            }
            return se;
        }

        /// <summary>
        /// Write setting, encrypt based on parameter
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        /// <param name="Encrypt"></param>
        private void WriteString(string Name, string Value, Boolean Encrypt) {
            string s;
            if (Encrypt) {
                s = EncDec.Encrypt(Value, Key + Name);
            }
            else {
                s = Value;
            }
            sf.WriteString(Name, s);
        }

        /// <summary>
        /// Write setting, clear text
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        private void WriteString(string Name, string Value) {
            WriteString(Name, Value, false);
        }
        #endregion GetSet Methods

        #region EmailTesting

        public bool TestSmtp() {
            bool result = false;

            try {
                string emailmessage = "Test email message from " + this._AppName + " application.";
                string emailsubject = emailmessage;

                MailMessage mail = new MailMessage(this.EmailFrom, this.EmailTo);
                SmtpClient client = new SmtpClient();
                client.Port = this.SmtpPortInt;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = this.SmtpServer;
                mail.Subject = emailsubject;
                mail.Body = emailmessage;
                client.Send(mail);
                result = true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public int SmtpPortInt {
            get {
                int result;
                int.TryParse(SmtpPort, out result);
                return result;
            }
        }
        #endregion


    }
}
