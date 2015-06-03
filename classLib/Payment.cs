using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace classLib {
    public class Payment {

        public string Id { get;set; }
        public string State { get; set; }
        public string SessionId { get; set; }
        public string DeliveryName { get; set; }
        public string Recptid { get; set; }
        public Decimal Amount { get; set; }
        public string Type { get; set; }
        public string Ref { get; set; }
        public string Note { get; set; }
        public DateTime cDate { get; set; }
        public string cUser { get; set; }
        public DateTime uDate { get; set; }
        public string uUser { get; set; }


    }
}
