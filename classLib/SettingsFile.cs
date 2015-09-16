using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using System.Xml;

namespace classLib {

    public class SettingsFile {
        private string xmlpath;
        private string filename;
        private string companyname;
        private Settings sets;

        #region properties
        public string FullPath {
            get { return xmlpath; }
        }

        public string FileName {
            get { return filename; }
            set {
                filename = value;
                CalcNewFileName();
            }
        }

        public string CompanyName {
            get { return companyname; }
            set {
                companyname = value;
                CalcNewFileName();
            }
        }

        public int ErrCode { get; set; }
        public string ErrMsg { get; set; }

        #endregion properties

        #region Constructor Destructor

        public SettingsFile(string XMLFileName) {
            filename = XMLFileName;
            SettingsFileInit();
        }

        public SettingsFile() {
            filename = "settings.xml";
            SettingsFileInit();
        }

        private void SettingsFileInit() {
            ErrCode = 0;
            ErrMsg = "";
            // (1)
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyCompanyAttribute assemblyCompany = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0] as AssemblyCompanyAttribute;
            companyname = assemblyCompany.Company;
            // (1)
            CalcNewFileName();
        }
        #endregion Constructor Destructor

        #region Private Routines
        private void CalcNewFileName() {
            xmlpath = GetUserXMLPath(filename);
            if (sets != null)
                sets = null;
            sets = new Settings(xmlpath);
        }

        #endregion Private Routines

        #region Paths

        /*
         * Microsoft & specialfolders
         * http://msdn.microsoft.com/en-us/library/system.environment.specialfolder.aspx
         *
         * http://stackoverflow.com/questions/895723/environment-getfolderpath-commonapplicationdata-is-still-returning-c-docum
         * Examples shown
         *
            Output On Windows Server 2003:
            SpecialFolder.ApplicationData: C:\Documents and Settings\blake\Application Data
            SpecialFolder.CommonApplicationData: C:\Documents and Settings\All Users\Application Data
            SpecialFolder.ProgramFiles: C:\Program Files
            SpecialFolder.CommonProgramFiles: C:\Program Files\Common Files
            SpecialFolder.DesktopDirectory: C:\Documents and Settings\blake\Desktop
            SpecialFolder.LocalApplicationData: C:\Documents and Settings\blake\Local Settings\Application Data
            SpecialFolder.MyDocuments: C:\Documents and Settings\blake\My Documents
            SpecialFolder.System: C:\WINDOWS\system32`

            Output on Vista: SpecialFolder.ApplicationData: C:\Users\blake\AppData\Roaming
            SpecialFolder.CommonApplicationData: C:\ProgramData
            SpecialFolder.ProgramFiles: C:\Program Files
            SpecialFolder.CommonProgramFiles: C:\Program Files\Common Files
            SpecialFolder.DesktopDirectory: C:\Users\blake\Desktop
            SpecialFolder.LocalApplicationData: C:\Users\blake\AppData\Local
            SpecialFolder.MyDocuments: C:\Users\blake\Documents
            SpecialFolder.System: C:\Windows\system32
         *
         */

        private string GetUserDataPath() {
            // If we were using a user private settings file, then we would use ...ApplicationData
            // string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // In this case we are using a system wide settings file (since the service must be able to access).
            //
            string dir;
            if (Environment.GetEnvironmentVariable("UseLocalConfig", EnvironmentVariableTarget.Process) == "yes") {
                dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            }
            else {
                dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            }
            dir = System.IO.Path.Combine(dir, companyname);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return dir;
        }

        private string GetUserXMLPath(string xmlfilename) {
            string fullpath;
            string DataPath = GetUserDataPath();

            fullpath = System.IO.Path.Combine(DataPath, xmlfilename);

            return fullpath;
        }

        #endregion Paths

        #region Public Methods
        public string ReadString(string Name, string Dflt) {
            string rvalue;
            rvalue = sets.GetSetting(Name.Trim().ToUpper(), Dflt);
            return rvalue;
        }

        public void WriteString(string Name, string Value) {
            sets.PutSetting(Name.Trim().ToUpper(), Value);
        }
        #endregion Public Methods

    } // public class SettingsFile

    // Ref:
    // (1) https://social.msdn.microsoft.com/Forums/vstudio/en-US/9325957b-cce1-429d-9aa8-f3f4350d72a2/read-the-assembly-information-data
}
