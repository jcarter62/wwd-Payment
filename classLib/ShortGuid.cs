﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classLib {
    public static class ShortGuid {

        public static String newId {
            get {
                return Guid.NewGuid().ToString().ToLower().Replace("{", "").Replace("}", "").Replace("-", "");
            }
        }
    }
}
