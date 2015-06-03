using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace classLib {
    public class Payments : List<Payment>  {

        string getList;

        public Payments() {
            getList = "select id, state, sessionid, deliveryname, rcptid, amount, " +
                      "paytype, payref, note, cdate, cuser, udate, uuser from CRMaster ";
        }

        public void Load() {
            if (this.Count > 0) {
                this.Clear();
            }

            AppSettings aset = new AppSettings();

            SqlConnection conn = new SqlConnection(aset.wmis.connectionString);
            SqlCommand cmd = new SqlCommand(getList, conn);
            try {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    ReadRow((IDataRecord)reader);
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception e) {
                Console.WriteLine("Error in Payments.Load: {0}", e.Message);
            }
        }

        private void ReadRow(IDataRecord rec) {
            DateTime tmpdt = new DateTime();
            Decimal tmpdec = new Decimal();
            Payment p = new Payment();

            p.Id = rec[0].ToString();
            p.State = rec[1].ToString();
            p.SessionId = rec[2].ToString();
            p.DeliveryName = rec[3].ToString();
            p.Recptid = rec[4].ToString();
            Decimal.TryParse(rec[5].ToString(), out tmpdec);
            p.Amount = tmpdec;
            p.Type = rec[6].ToString();
            p.Ref = rec[7].ToString();
            p.Note = rec[8].ToString();
            DateTime.TryParse(rec[9].ToString(), out tmpdt);
            p.cDate = tmpdt;
            p.cUser = rec[10].ToString();
            DateTime.TryParse(rec[11].ToString(), out tmpdt );
            p.uDate = tmpdt;
            p.uUser = rec[12].ToString();

            this.Add(p);
        }
    }
}
