using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace classLib {
    public class PosSize {
        private int left;
        private int right;
        private int top;
        private int bottom;
        private String name;
        private Form form;

        String companyname = "WWD";
        String appname = "Payments";
        const String comma = ",";

        public PosSize(Form me) {
            companyname = CompanyName();
            appname = AppName();
            name = "form." + me.Name.ToString() + ".txt";
            form = me;
            left = me.Left;
            right = me.Right;
            top = me.Top;
            bottom = me.Bottom;
        }

        private String CompanyName() {
            String result = "";
            result = Application.CompanyName.ToString();
            return result;
        }

        private String AppName() {
            String result = "";
            result = Application.ProductName.ToString();
            return result;
        }

        public void Save() {
            String filename = FilePath(this.name);
            String data;
            data = left.ToString() + comma +
                right.ToString() + comma +
                top.ToString() + comma +
                bottom.ToString();
            System.IO.StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(data);
            sw.Close();
        }

        public void Restore() {
            char[] delim = { ',' };
            String filename = FilePath(this.name);
            if (File.Exists(filename)) {
                String data;
                StreamReader sr = new StreamReader(filename);
                data = sr.ReadLine();
                sr.Close();

                string[] words = data.Split(delim);
                // only restore if we have 4 numbers
                if (words.Length == 4) {
                    left = Convert.ToInt32(words[0]);
                    right = Convert.ToInt32(words[1]);
                    top = Convert.ToInt32(words[2]);
                    bottom = Convert.ToInt32(words[3]);
                }

                form.Left = left;
                form.Width = right - left;
                form.Top = top;
                form.Height = bottom - top;

            }
            //
            // Set Icon for this form, based on Application Icon.
            //
            form.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private string FilePath(string formname) {
            string fullpath;
            string DataPath = GetUserDataPath();
            fullpath = System.IO.Path.Combine(DataPath, formname);
            return fullpath;
        }

        private string GetUserDataPath() {
            // private settings file directory, 
            // string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            dir = System.IO.Path.Combine(dir, companyname);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            dir = System.IO.Path.Combine(dir, appname);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            return dir;
        }
    }
}
