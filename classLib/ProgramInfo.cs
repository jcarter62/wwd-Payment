using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace classLib {
    public class ProgramInfo {

        public ProgramInfo() {
            FileInfo f;
            string fname;

            fname = Application.ExecutablePath.ToString();
            f = new FileInfo(fname);

            AppVersion = Application.ProductVersion.ToString();
            AppDate = f.LastWriteTime.ToString();
        }

        public string AppDate { get; set; }

        public string AppVersion { get; set; }
    }
}
