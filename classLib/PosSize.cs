﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace classLib {
    public class PosSize {
        public int left;
        public int right;
        public int top;
        public int bottom;
        private string name;
        private Form form;

        string companyname;
        string appname = "Payments";
        const string comma = ",";
        private char[] delim = { ',' };

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

        private string CompanyName() {
            string result = "";
            // (3)
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyCompanyAttribute assemblyCompany = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0] as AssemblyCompanyAttribute;
            result = assemblyCompany.Company;
            // (3)
            return result;
        }

        private string AppName() {
            string result = "";
            result = Application.ProductName.ToString();
            return result;
        }

        public void Save() {
            string filename = FilePath(this.name);
            string data;
            data = left.ToString() + comma +
                right.ToString() + comma +
                top.ToString() + comma +
                bottom.ToString();
            System.IO.StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(data);
            SavePanelSizes(sw);
            sw.Close();
        }

        private void SavePanelSizes(StreamWriter sw) {
            foreach (var ctrl in form.Controls) {
                if ((ctrl is Panel) || (ctrl is PanelTrak)) {
                    var p = (Panel)ctrl;
                    if (p.Dock != DockStyle.None) {
                        sw.WriteLine("{0},{1},{2}", p.Name, p.Width, p.Height);
                    }
                }
            }
        }

        public void Restore() {
            string filename = FilePath(this.name);
            if (File.Exists(filename)) {
                string data;
                StreamReader sr = new StreamReader(filename);
                data = sr.ReadLine();

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

                RestorePanelSizes(sr);
                sr.Close();
            }
            //
            // Set Icon for this form, based on Application Icon.
            //
            form.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void RestorePanelSizes(StreamReader sr) {
            string lineofdata;
            // Restore any panels if available.
            lineofdata = sr.ReadLine();
            while ( lineofdata != null )
            {
                string[] words = lineofdata.Split(delim);
                // perform only if we have 3
                if ( words.Length == 3 )
                {
                    UpdatePanelSize( words[0], 
                            Convert.ToInt32(words[1]), 
                            Convert.ToInt32(words[2]));
                }
                lineofdata = sr.ReadLine();
            }
        }

        private void UpdatePanelSize(string panelName, int width, int height) {
            foreach (var ctrl in form.Controls) {
                if ((ctrl is Panel) || (ctrl is PanelTrak)) {
                    var p = (Panel)ctrl;
                    if ( p.Name == panelName )
                    {
                        p.Width = width;
                        p.Height = height;
                    }
                }
            }

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
    // Ref:
    // (3) https://social.msdn.microsoft.com/Forums/vstudio/en-US/9325957b-cce1-429d-9aa8-f3f4350d72a2/read-the-assembly-information-data

}
