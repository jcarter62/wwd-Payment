using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using classLib;

namespace utp {
    [TestClass]
    public class utKeys {
        [TestMethod]
        public void TestKeys() {
            String k = Keys.getKey();
            if (k.ToString().Length < 20) {
                Assert.Fail("Key length is too short");
            }
        }

        [TestMethod]
        public void TestRecitId() {
            String x;
            ReceiptId r = new ReceiptId();
            x = r.id;
            Console.WriteLine("ReceiptID.Id = {0}", x);
            if (x.Length < 2) {
                Assert.Fail("ReceiptId.Id is too short");
            }
        }
    }
}
