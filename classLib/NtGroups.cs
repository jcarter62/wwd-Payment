using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;

namespace classLib {

    /// <summary>
    /// Provides minimal access to a users groups.
    /// * List of groups the current user is a member.
    /// * Boolean method to check if current user is a member of specific group.
    /// * ToString() enumerates user+domain+groups
    /// </summary>
    public class NtGroups {
        public string CurrentUser { get; protected set; }
        private string DomainName { get; set; }

        /// <summary>
        /// All Groups the current user is a member.
        /// </summary>
        public IList<string> GroupNames { get; protected set; }

        public NtGroups() {
            Init();
            UserGroups();
        }

        /// <summary>
        /// check if current user is a member of specific group.
        /// </summary>
        /// <param name="groupname">specific group</param>
        /// <returns></returns>
        public bool IsInGroup(string groupname)
        {
            bool result = false;
            foreach (var item in GroupNames) {
                if (groupname.Trim().ToLower().CompareTo(item) == 0) {
                    result = true;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// enumerates user+domain+groups
        /// </summary>
        /// <returns>string containing user+domain+groups</returns>
        public override string ToString() {
            string s = "";
            string nl = ";\n";
            s = "user:" + CurrentUser + nl + "domain:" + DomainName + nl;
            foreach (var x in GroupNames) {
                s = s + x.ToString() + nl;
            }
            return s;
        }

        private void Init() {
            // ref: http://stackoverflow.com/a/10877627
            CurrentUser = System.Environment.UserName;
            DomainName = System.Environment.UserDomainName;
            UserGroups();
        }

        /// <summary>
        /// Load groups that this user is a member.
        /// </summary>
        // ref: http://stackoverflow.com/a/8475193
        // ref: http://stackoverflow.com/a/5310317
        private void UserGroups() {
            GroupNames = new List<string>();
            List<string> lst = new List<string>();

            if (CurrentUser.Length > 0) {
                // create your domain context
                var ctx = new PrincipalContext(ContextType.Domain);

                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, CurrentUser);

                if (user != null) {
                    PrincipalSearchResult<Principal> groups = user.GetAuthorizationGroups();

                    foreach (Principal p in groups) {
                        if (p is GroupPrincipal) {
                            string grpname;
                            grpname = p.SamAccountName.Trim().ToLower();
                            if (notInList(grpname, lst))
                                lst.Add(grpname);
                        }
                    }
                }
            }

            // Sort and store in public/property.
            GroupNames = lst.OrderBy(o => o.ToString()).ToList<string>();
        }

        private bool notInList(string s, List<string> l) {
            bool result = true;
            foreach (var item in l) {
                if (s.CompareTo(item) == 0) {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
