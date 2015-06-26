using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dataLib {
    public class SampleData {
        DbClassDataContext dc;
        Random r;

        public SampleData(string ConnString) {
            dc = new DbClassDataContext(ConnString);
            r = new Random();
        }
        /// <summary>
        /// Create some sample data for use in project
        /// </summary>
        /// <param name="n">Number of Payments to create</param>
        public void CreateData(int n) {
            for (int i = 0; i < n; i++) {
                CreateRecord(i);
            }
        }

        private void CreateRecord(int i) {
            CRMaster m = new CRMaster();

            m.Amount = RandomAmount(10000.0);
            m.DeliveryName = RandomName();
            m.PayType = "Check";
            m.PayVia = "Person";
            m.PayRef = RandomCheckNum();
            m.StateGA = "created";
            m.StateAR = "created";
            m.RcptID = RandomRcpt();

            dc.CRMasters.InsertOnSubmit(m);
            dc.SubmitChanges();
        }

        private string RandomRcpt() {
            string result = "";
            int n = goodChars.Length;
            int index;

            for ( int i = 0; i < 8; i ++ )
            {
                index = r.Next(0,n-1);
                result = result + goodChars.Substring(index,1);
            }

            return result;
        }

        private string RandomCheckNum() {
            string result;
            string n1 = RandomName().Substring(1,1);
            string n2 = RandomName().Substring(1,1);
            result = n1 + n2 + r.Next(1000, 9999).ToString();
            return result.ToUpper();
        }

        private string RandomName() {
            int index;
            int count;
            count = names.Count();
            index = r.Next(0,count-1);
            return names[index];
        }

        private double? RandomAmount(double range) {
            double result;
            result = (r.NextDouble() * range);
            result = Math.Round(result,2);
            return result;
        }

        readonly string goodChars = "0123456789ABCDEFGHIJKMNPQRSTUWXYZ";

        readonly string[] names = {
"James","John","Robert","Michael","William","David","Richard","Charles",
"Joseph","Thomas","Christopher","Daniel","Paul","Mark","Donald","George",
"Kenneth","Steven","Edward","Brian","Ronald","Anthony","Kevin","Jason",
"Matthew","Gary","Timothy","Jose","Larry","Jeffrey","Frank","Scott",
"Eric","Stephen","Andrew","Raymond","Gregory","Joshua","Jerry","Dennis",
"Walter","Patrick","Peter","Harold","Douglas","Henry","Carl","Arthur",
"Ryan","Roger","Joe","Juan","Jack","Albert","Jonathan","Justin","Terry",
"Gerald","Keith","Samuel","Willie","Ralph","Lawrence","Nicholas","Roy",
"Benjamin","Bruce","Brandon","Adam","Harry","Fred","Wayne","Billy","Steve",
"Louis","Jeremy","Aaron","Randy","Howard","Eugene","Carlos","Russell",
"Bobby","Victor","Martin","Ernest","Phillip","Todd","Jesse","Craig","Alan",
"Shawn","Clarence","Sean","Philip","Chris","Johnny","Earl","Jimmy","Antonio",
"Danny","Bryan","Tony","Luis","Mike","Stanley","Leonard","Nathan","Dale",
"Manuel","Rodney","Curtis","Norman","Allen","Marvin","Vincent","Glenn","Jeffery",
"Travis","Jeff","Chad","Jacob","Lee","Melvin","Alfred","Kyle","Francis","Bradley",
"Jesus","Herbert","Frederick","Ray","Joel","Edwin","Don","Eddie","Ricky","Troy",
"Randall","Barry","Alexander","Bernard","Mario","Leroy","Francisco","Marcus","Micheal",
"Theodore","Clifford","Miguel","Oscar","Jay","Jim","Tom","Calvin","Alex",
"Jon","Ronnie","Bill","Lloyd","Tommy","Leon","Derek","Warren","Darrell","Jerome",
"Floyd","Leo","Alvin","Tim","Wesley","Gordon","Dean","Greg","Jorge","Dustin",
"Pedro","Derrick","Dan","Lewis","Zachary","Corey","Herman","Maurice","Vernon",
"Roberto","Clyde","Glen","Hector","Shane","Ricardo","Sam","Rick","Lester",
"Brent","Ramon","Charlie","Tyler","Gilbert","Gene","Marc","Reginald","Ruben",
"Brett","Angel","Nathaniel","Rafael","Leslie","Edgar","Milton","Raul","Ben",
"Chester","Cecil","Duane","Franklin","Andre","Elmer","Brad","Gabriel","Ron",
"Mitchell","Roland","Arnold","Harvey","Jared","Adrian","Karl","Cory","Claude",
"Erik","Darryl","Jamie","Neil","Jessie","Christian","Javier","Fernando","Clinton",
"Ted","Mathew","Tyrone","Darren","Lonnie","Lance","Cody","Julio","Kelly","Kurt",
"Allan","Nelson","Guy","Clayton","Hugh","Max","Dwayne","Dwight","Armando","Felix",
"Jimmie","Everett","Jordan","Ian","Wallace","Ken","Bob","Jaime","Casey",
"Alfredo","Alberto","Dave","Ivan","Johnnie","Sidney","Byron","Julian","Isaac",
"Morris","Clifton","Willard","Daryl","Ross","Virgil","Andy","Marshall","Salvador",
"Perry","Kirk","Sergio","Marion","Tracy","Seth","Kent","Terrance","Rene","Eduardo",
"Terrence","Enrique","Freddie","Wade"

        };

    }
}
