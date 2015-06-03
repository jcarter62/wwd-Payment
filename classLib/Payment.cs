using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace classLib {
    public class Payment {

        public String Id { get;set; }
        public String State { get; set; }
        public String SessionId { get; set; }
        public String DeliveryName { get; set; }
        public String Recptid { get; set; }
        public Decimal Amount { get; set; }
        public String Type { get; set; }
        public String Ref { get; set; }
        public String Note { get; set; }
        public DateTime cDate { get; set; }
        public String cUser { get; set; }
        public DateTime uDate { get; set; }
        public String uUser { get; set; }


    }
}
