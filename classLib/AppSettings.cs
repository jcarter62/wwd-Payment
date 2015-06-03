using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Xml;

namespace classLib {

    /// <summary>
    /// This class is used to abstract application settings.
    /// </summary>
    public class AppSettings {
        private String _AppName = "Payments";

        public DbSettings wmis;
        public DbSettings mas500;

        private String _Key = Keys.key;

        private SettingsFile sf;
        private String _filename;

        #region Properties
        public String Key {
            get { return _Key;  }
        }

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

        private void loadDbInfo(DbSettings db, String prefix) {
            db.Hostname = GetString(prefix + "Hostname");
            db.Database = GetString(prefix + "Database");
            db.Username = GetString(prefix + "Username", true );
            db.Password = GetString(prefix + "Password", true );
            String yn;
            yn = GetString(prefix + "WindowsAuthentication");
            db.WindowsAuth = ( yn == "Y");
        }

        /// <summary>
        /// Populate class properties with settings, Server, Database, Username, ...
        /// </summary>
        public void Load() {
            loadDbInfo(wmis, "wmis");
            loadDbInfo(mas500, "mas500");
        }


        private void saveDbInfo(DbSettings db, String prefix) {
            WriteString(prefix + "Hostname", db.Hostname);
            WriteString(prefix + "Database",db.Database);
            WriteString(prefix + "Username",db.Username,true);
            WriteString(prefix + "Password",db.Password, true);
            if ( db.WindowsAuth) {
                WriteString(prefix + "WindowsAuthentication", "Y");
            }
        }

        /// <summary>
        /// Save values to settings file.
        /// </summary>
        public void Save() {
            saveDbInfo(wmis, "wmis");
            saveDbInfo(mas500, "mas500");
        }

        #endregion Methods

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
            String se;
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
        private void WriteString(String Name, String Value, Boolean Encrypt) {
            String s;
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
        private void WriteString(String Name, String Value) {
            WriteString(Name, Value, false);
        }

    }
}
