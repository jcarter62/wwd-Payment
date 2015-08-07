using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using dataLib;
using classLib;


namespace RcvPayment.misc {
    public partial class LogView : RcvPayment.MyForm {
        private string pId = "";
        public string Id {
            get {
                return pId;
            }
            set {
                pId = value;
                LoadGridDataSource(ref dataGV, pId);
                LoadDescriptiveText(pId);
            }
        }
        private DbClassDataContext dc;
        private AppSettings aset;

        public LogView() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
        }

        private void LoadDescriptiveText(string id)
        {
            string descText = "";
            string sep = "/";
            IQueryable<CRMaster> r = (from a in dc.CRMasters
                                        where a.Id == id
                                        select a);

            foreach ( var rec in r )
            {
                descText = "";
                descText = rec.RcptID.Trim() + sep +
                           rec.PayType + sep + 
                           rec.PayRef + sep +
                           rec.PayVia + sep + 
                           rec.DeliveryName;
                break;
            }

            labelPayment.Text = descText;
        }

        /// <summary>
        /// Load the Grid Data Source.
        /// </summary>
        /// <param name="v">Datagridview object</param>
        /// <param name="id">TblId value</param>
        /// <returns>id column number</returns>
        private void LoadGridDataSource(ref DataGridView v, string id) {

            v.DataSource = null;
            v.Rows.Clear();

            var records = (from r in dc.TblLogs
                           where r.tblId == id
                           orderby r.cdate ascending
                           select new
                           {
                               date = r.cdate,
                               user = r.cuser,
                               text = r.txt
                           });


            WipeColumns(ref v);
            foreach (var rec in records) {
                AddColumn(ref v, "date", "Entry Date");
                AddColumn(ref v, "user", "User ID");
                AddColumn(ref v, "text", "Operation");
                break;
            }

            v.DataSource = records;
        }

        private void AddColumn(ref DataGridView grid, string colName, string colTitle,
                               bool hidden = false, bool IsCurrency = false) {
            var cellStyle = new DataGridViewCellStyle();
            DataGridViewColumn c = new DataGridViewTextBoxColumn();  // new DataGridViewColumn();
            c.Resizable = DataGridViewTriState.True;
            c.DividerWidth = 1;
            c.DataPropertyName = colName;
            c.HeaderText = colTitle;
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (hidden) {
                c.Visible = false;
            }
            if (IsCurrency) {
                cellStyle.Format = "C2";
                cellStyle.NullValue = null;
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            c.DefaultCellStyle = cellStyle;
            grid.Columns.Add(c);
        }

        private void WipeColumns(ref DataGridView grid) {
            grid.Columns.Clear();
        }

    }
}
