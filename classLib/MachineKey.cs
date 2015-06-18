using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace classLib {

    /// <summary>
    /// Class to provide a machine specific key useful in encryption.
    /// </summary>
    public class MachineKey {
        public string key { get; protected set; }
        private string keyfile { get; set; }
        private string companyname;

        public MachineKey() {
            Init();
            LoadOrCreateKey();
        }

        private void LoadOrCreateKey() {
            FileInfo fi = new FileInfo(keyfile);
            if ( ! fi.Exists ) {
                // first time executed, we will need to
                // create a file & key contents.
                createNewKeyFile();
            }
            key = getFileContents();
        }

        private string getFileContents() {
            string results = "";
            byte[] bytes = new byte[1024];
            int charcount;
            FileStream fs = File.OpenRead(keyfile);
            if ( fs != null ) {
                charcount = fs.Read(bytes, 0, 1024);
                results = System.Text.Encoding.Default.GetString(bytes); // (1)
            }
            return results;
        }

        private void createNewKeyFile() {
            string longkey = "";
            FileStream fs = File.Create(keyfile);
            fs.Close();
            // create a really long string of guids.
            // This should be random & long enough 
            // for encryption purposes.
            for (var i = 1; i<10; i++ ) {
                longkey = longkey + ShortGuid.newId;
            }
            // (2)
            byte[] bytes = new byte[longkey.Length * sizeof(char)];
            System.Buffer.BlockCopy(longkey.ToCharArray(), 0, bytes, 0, bytes.Length);
            fs = File.OpenWrite(keyfile);
            fs.Write( bytes , 0, bytes.Length);
            fs.Close();
        }

        private void Init() {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyCompanyAttribute assemblyCompany = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0] as AssemblyCompanyAttribute;
            companyname = assemblyCompany.Company; // (3)
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            dir = System.IO.Path.Combine(dir, companyname);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            keyfile = dir + "\\keyfile.xml";
        }
    }
    // Ref:
    // (1) http://stackoverflow.com/questions/11654562/how-convert-byte-array-to-string
    // (2) http://stackoverflow.com/a/10380166
    // (3) https://social.msdn.microsoft.com/Forums/vstudio/en-US/9325957b-cce1-429d-9aa8-f3f4350d72a2/read-the-assembly-information-data

}
