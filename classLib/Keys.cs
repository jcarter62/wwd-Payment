using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classLib {
    public static class Keys {
        static string _key = null;

        public static string getKey() {
            if ( _key == null ) {
                _key = loadkey();
            }
            return _key;
        }

        private static string loadkey() {
            MachineKey mk = new MachineKey();
            return mk.key;
        }
    }
}
