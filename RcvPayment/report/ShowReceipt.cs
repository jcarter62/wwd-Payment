using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using dataLib;
using classLib;
using Telerik.Reporting;
using Telerik.Reporting.Processing;
using System.Net.Mail;

namespace RcvPayment {
    public partial class ShowReceipt : RcvPayment.MyForm {
        AppSettings aset;
        DbClassDataContext dc;

        public string Id { get; set; }
        public string EmailResult { get; protected set; }
        public string EmailAddress { get; set; }

        public ShowReceipt() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
        }

        public void DisplayReport(string id) {
            Id = id;
            aset = new AppSettings();
            Report1 rpt = new Report1(aset.wmis.connectionString, Id);

            rview.ReportSource = rpt;
            rview.RefreshReport();

            loadEmailList();
        }

        /*
        select 
        distinct cont.FirstName, cont.LastName, ce.Email
        from CRDetail d 
        inner join CMNameContact nc on d.Account = nc.Name_ID
        inner join CMEmail ce on nc.IDEmail = ce.IDEmail
        inner join CMContact cont on nc.IDContact = cont.IDContact
        where d.CRMid = '856e091752bb41849a0710d6c71383a7'
        order by ce.Email
        */

        private void loadEmailList() {
            var q = (from d in dc.CRDetails
                     join nc in dc.CMNameContacts on d.Account equals nc.Name_ID.ToString()
                     join ce in dc.CMEmails on nc.IDEmail equals ce.IDEmail
                     join cn in dc.CMContacts on nc.IDContact equals cn.IDContact
                     where d.CRMid == Id
                     select new { cn.FirstName, cn.LastName, ce.Email }).Distinct();

            cbEmail.Items.Clear();
            foreach (var r in q) {
                string item;
                item = r.FirstName.Trim() + " " +
                        r.LastName.Trim() + " <" +
                        r.Email.Trim() + ">";
                cbEmail.Items.Add(item);
            }
            cbEmail.Items.Add("Jim Carter <jcarter@westlandswater.org>");
        }

        private void ShowReceipt_Load(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e) {
            // Export report to pdf.
            // (1)
            Report1 rpt = new Report1(aset.wmis.connectionString, Id);
            //
            var rptProcessor = new ReportProcessor();
            var instanceRptSrc = new InstanceReportSource(); // (2)
            instanceRptSrc.ReportDocument = rpt;
            var result = rptProcessor.RenderReport("PDF", instanceRptSrc, null);

            string tempfile = System.IO.Path.GetTempPath() + "\\" + Guid.NewGuid().ToString().ToLower().Replace("{", "").Replace("}", "").Replace("-", "") + ".pdf";
            System.IO.FileStream fs = new System.IO.FileStream(tempfile, System.IO.FileMode.Create);

            fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
            fs.Close();

            // at this point, the report has been saved as pdf to a pdf named tempfile
            //

            // Now we need to email this.
            bool DoneSendingEmail = false;
            while (!DoneSendingEmail) {
                if (sendFileToEmailAddress(tempfile)) {
                    MessageBox.Show("Success!", "Information", MessageBoxButtons.OK);
                    DoneSendingEmail = true;
                    ReportEmailSent();
                }
                else {
                    DialogResult rslt;
                    string fullmsg;
                    fullmsg = "Message Failed!\n" + EmailResult;
                    rslt = MessageBox.Show(fullmsg, "Error", MessageBoxButtons.AbortRetryIgnore);
                    if ((rslt == DialogResult.Abort) || (rslt == DialogResult.Ignore)) {
                        DoneSendingEmail = true;
                    }
                }
            }

            // Reference:
            // (1) http://www.telerik.com/forums/blank-pages-in-export-to-pdf
            // (2) http://www.telerik.com/support/kb/reporting/details/how-to-migrate-your-project-to-utilize-the-new-reportsource-objects#reportprocessor
            //
        }

        private void ReportEmailSent() {
            TblLog l = new TblLog();
            l.tblId = Id;
            l.tblName = "crmaster";
            l.txt = "Send Receipt to:" + EmailAddress;

            try {
                dc.TblLogs.InsertOnSubmit(l);
                dc.SubmitChanges();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }

        private bool sendFileToEmailAddress(string tempfile) {
            bool result;
            AppSettings aset = new AppSettings();
            result = false;

            try {
                string recptId = getReceiptID();
                string emailmessage = "Payment Receipt is Attached.";
                string emailsubject = "WWD Payment Receipt: " + recptId;
                string toAddress = cbEmail.Text;

                EmailAddress = toAddress;

                MailMessage mail = new MailMessage(aset.EmailFrom, toAddress);
                SmtpClient client = new SmtpClient();
                client.Port = aset.SmtpPortInt;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = aset.SmtpServer;
                mail.Subject = emailsubject;
                mail.Body = emailmessage;
                Attachment atch = new Attachment(tempfile);
                mail.Attachments.Add(atch);
                client.Send(mail);
                result = true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                EmailResult = ex.Message;
                result = false;
            }
            return result;
        }


        private string getReceiptID() {
            string result = "";
            try {
                var q = (from m in dc.CRMasters
                         where m.Id == Id
                         select m.RcptID).First();

                result = q;

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
