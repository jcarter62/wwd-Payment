using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classLib {
    public static class Keys {
        private static string key1 = "0b9afdc92f7b4fba85221eefb580a2c28c67c7134f9348e493152611a6a0d69f";
        private static string key3 = "0b9afdc92f7b4fba85201eeab580a2c28c67c7134f9348e493152611a6a0d69f";
        private static string key5 = "0b9afdc92f7b4fba85251eefb580a2c28c67c7134f9348e493152611a6a0d69f";
        public static string key {
            get { return key3; }
        }
        /* The following to get rid of compiler errors */
        private static void noop() {
            string x;
            x = key1 + key5;
        }
    }
}
