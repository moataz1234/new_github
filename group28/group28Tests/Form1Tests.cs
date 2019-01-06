using Microsoft.VisualStudio.TestTools.UnitTesting;
using group28;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group28.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void checkpasswordanduserTest()
        {
            Form1 f1 = new Form1();
            f1.checkpasswordanduser("", "gf");
        }
    }
}