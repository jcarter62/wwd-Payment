using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace classLib {
    public class Images {
        public String successImage { get; protected set; }
        public String failImage { get; protected set; }

        public Images() {
            String Base = AppDomain.CurrentDomain.BaseDirectory + "images\\";
            successImage = Base + "dialog-ok-2.png";
            failImage = Base + "dialog-no-2.png";
        }
    }
}
