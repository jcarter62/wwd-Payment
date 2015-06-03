using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using dataLib;

namespace classLib {
    public class ReceiptId {
        AppSettings aset;
        dbClassDataContext dc;

        String prefix { get; set; }
        String year;
        String month;
        String day;
        String hour;
        String minute;
        String num;
        String result;
        public String id { get { return result; } }

        static String GoodChars = "0123456789ABCDEFGHIJKMNPQRSTUWXYZ"; 
        //                         123456789012345678901234567890123
        //                                  1         2         3  

        public ReceiptId() {

            prefix = "";
            init();
        }

        private void init() {
            int n;
            String testid = "";
            String tempid = "";
            DateTime now;
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
            
            now = DateTime.Now;

            year = year2chars(now.Year);
            month = month2char(now.Month);
            day = day2char(now.Day);
            hour = hour2char(now.Hour);
            minute = minute2char(now.Minute);

            tempid = year + month + day + hour + minute;

            n = 1;
            testid = tempid + n.ToString();
            while (IdInUse(testid)) {
                n = n + 2;
                testid = tempid + n.ToString();
            }
            result = testid;
        }


        // Determine if this testid is already in use.  Check in the CRMasterId table.
        // if it is not in use, then add a record so as to reserve the id.
        private bool IdInUse(string testid) {
            bool inUse = true;

            try {
                var q = from item in dc.CRMasterIds
                        where item.RcptId == testid
                        select item;

                // did not find a record..., so create one & return false.
                if ( q.Count() <= 0 ) {
                    inUse = false;

                    CRMasterId rec = new CRMasterId {
                        id = Guid.NewGuid().ToString().Replace("-", "").Replace("{", "").Replace("}", "").ToLower(),
                        RcptId = testid
                    };

                    dc.CRMasterIds.InsertOnSubmit(rec);
                    try {
                        dc.SubmitChanges();
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                }
                q = null;
            } finally {

            }

            // This means there is no record.

            return inUse;
        }

        // Not really interested in minute, however something more granular that hour.
        // so let's use 30 divisions
        private string minute2char(int p) {
            int mindiv2 = p / 2;
            string result = GoodChars.Substring(mindiv2, 1);
            return result;
        }

        // convert 0 to 23 to 0..9A..Z
        private string hour2char(int p) {
            string result = GoodChars.Substring(p, 1);
            return result;
        }

        // last two characters of year, zero pad to left.
        private string year2chars(int p) {
            string result = "";
            int n = p - 2000;
            result = (n > 9) ? n.ToString() : "0" + n.ToString();
            return result;
        }

        // convert day to character 0..9A..Z
        private string day2char(int p) {
            String result = GoodChars.Substring(p, 1);
            return result;
        }

        // convert month to single character. A=Jan, B=Feb, ...
        private String month2char(int num) {
            String result = GoodChars.Substring(num, 1);
            return result;
        }
    }
}
