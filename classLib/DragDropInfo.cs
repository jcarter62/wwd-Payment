using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classLib {
    /// <summary>
    /// Object/Class used when Drag Drop operations
    /// are performed.  An instance will be passed 
    /// via the DoDragDrop() method.
    /// </summary>
    public class DragDropInfo {
        public string id { get; set; }
        public int value { get; set; }
        public string source { get; set; }
        public string dest { get; set; }
        public object obj { get; set; }

        public DragDropInfo() {
            obj = null;
            id = "";
            source = "";
            dest = "";
        }

        public DragDropInfo(string Source) {
            obj = null;
            dest = "";
            id = "";
            source = Source;
        }

        public DragDropInfo(string Id, string Source) {
            obj = null;
            dest = "";
            id = Id;
            source = Source;
        }

        public DragDropInfo(object Obj, string Source) {
            obj = Obj;
            dest = "";
            id = "";
            source = Source;
        }
    }
}
