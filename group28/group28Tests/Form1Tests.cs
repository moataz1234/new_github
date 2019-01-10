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
    [TestClass()]
    public class Add_studentest
    {
        [TestMethod()]
        public void checkuserTest()
        {
            Add_student f1 = new Add_student();
            
            Assert.ThrowsException<ArgumentException>(()=>f1.checkuser("213"));
            Assert.IsTrue(f1.checkuser("s213"));
        }
    }
    [TestClass()]
    public class Add_coursetest
    {
        [TestMethod()]
        public void equalTest()
        {
            Add_course f1 = new Add_course();

            Assert.ThrowsException<ArgumentException>(() => f1.isequal("assd","asd"));
           // Assert.IsTrue(f1.checkuser("s213"));
        }
    }
    [TestClass()]
    public class search_coursetest
    {
        [TestMethod()]
        public void checkboxTest()
        {
            Search_course ss = new Search_course();
            Assert.IsTrue(ss.checkbox(""));
        }
    }

    [TestClass()]
    public class addcrstutest
    {
        [TestMethod()]
        public void checkcountTest()
        {
            AddCourseStu ss = new AddCourseStu();
            Assert.IsTrue(ss.checkcount(0,1));
        }
    }
}