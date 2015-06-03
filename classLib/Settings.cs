using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Xml;

namespace classLib {
    public class Settings {
        XmlDocument xmlDocument = new XmlDocument();
        string documentPath;

        public Settings(string path) {
            documentPath = path;
            try {
                xmlDocument.Load(documentPath);
            }
            catch {
                xmlDocument.LoadXml("<settings></settings>");
                //
                // The following is performed so all users on system will have access to the settings.
                //
                xmlDocument.Save(documentPath);
                GrantAccess(documentPath);
            }
        }

        //
        // Give all users "worldsid" access to the file.
        // Reference:
        // http://stackoverflow.com/questions/9108399/how-to-grant-full-permission-to-a-file-created-by-my-application-for-all-users
        //
        private void GrantAccess(string fullPath) {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new
                FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                PropagationFlags.NoPropagateInherit, AccessControlType.Allow)
                );
            dInfo.SetAccessControl(dSecurity);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="xPath"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public int GetSetting(string xPath, int defaultValue) {
            return Convert.ToInt16(GetSetting(xPath, Convert.ToString(defaultValue)));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="xPath"></param>
        /// <param name="value"></param>
        public void PutSetting(string xPath, int value) {
            PutSetting(xPath, Convert.ToString(value));
            xmlDocument.Save(documentPath);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="xPath"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public string GetSetting(string xPath, string defaultValue) {
            XmlNode xmlNode = xmlDocument.SelectSingleNode("settings/" + xPath);
            if (xmlNode != null) {
                return xmlNode.InnerText;
            }
            else {
                return defaultValue;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="xPath"></param>
        /// <param name="value"></param>
        public void PutSetting(string xPath, string value) {
            XmlNode xmlNode = xmlDocument.SelectSingleNode("settings/" + xPath);
            if (xmlNode == null) {
                xmlNode = createMissingNode("settings/" + xPath);
            }
            xmlNode.InnerText = value;
            xmlDocument.Save(documentPath);
        }

        private XmlNode createMissingNode(string xPath) {
            string[] xPathSections = xPath.Split('/');
            string currentXPath = "";
            XmlNode testNode = null;
            XmlNode currentNode = xmlDocument.SelectSingleNode("settings");
            foreach (string xPathSection in xPathSections) {
                currentXPath += xPathSection;
                testNode = xmlDocument.SelectSingleNode(currentXPath);
                if (testNode == null) {
                    currentNode.InnerXml += "<" +
                                xPathSection + "></" +
                                xPathSection + ">";
                }
                currentNode = xmlDocument.SelectSingleNode(currentXPath);
                currentXPath += "/";
            }
            return currentNode;
        }
    }
}
