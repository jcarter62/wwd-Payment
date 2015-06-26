using System.Collections.Generic;
using System.Drawing;

namespace classLib {
    /// <summary>
    /// Object/Class used when Drag Drop operations
    /// are performed.  An instance will be passed 
    /// via the DoDragDrop() method.
    /// </summary>
    public class DragDropInfo {
        public string Id { get; set; }
        public int Value { get; set; }
        public string Source { get; set; }

        public string Dest { get; set; }
        public object Obj { get; set; }
        public Rectangle StartRegion { get; set; }
        public List<string> IdList {get;set;}

        public bool IsAList;

        public DragDropInfo() {
            StandardInit();
        }

        public override string ToString() {
            return string.Format(
                format: "Id:{0}, Source:{1}, Dest:{2}", 
                arg0: Id, arg1: Source, arg2: Dest);
        }

        public string ToString(string msg) {
            return msg + ToString();
        }

        public DragDropInfo(string Source) {
            StandardInit();
            this.Source = Source;
        }

        public DragDropInfo(string Id, string Source) {
            StandardInit();
            this.Id = Id;
            this.Source = Source;
        }

        public DragDropInfo(object Obj, string Source) {
            StandardInit();
            this.Obj = Obj;
            this.Source = Source;
        }

        private void StandardInit() {
            Obj = null;
            Id = "";
            Source = "";
            Dest = "";
            StartRegion = Rectangle.Empty;
            IdList = new List<string>();
            IsAList = false;
        }

    }
}
