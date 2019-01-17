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
        public void checkpasswordanduserTest()
        {
            Form1 f1 = new Form1();
            bool fals= f1.checkpasswordanduser("", "gf");
            Assert.IsFalse(fals);

        }
    }
    [TestClass()]
    public class Add_studentest
    {
        [TestMethod()]
        public void checkuserTest()
        {
            Add_student f1 = new Add_student();
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

    [TestClass()]
    public class delecoursetest
    {
        [TestMethod()]
        public void checkisnullTest()
        {
            delete_course d = new delete_course();
            Assert.IsFalse(d.checkisnull("asd"));
        }
    }

    [TestClass()]
    public class search_lecturertest
    {
        [TestMethod()]
        public void isincorrectTest()
        {
            Search_lecturer ss = new Search_lecturer();
            Assert.IsTrue(ss.ISincorrect(0));
        }
    }

    [TestClass()]
    public class search_studenttest
    {
        [TestMethod()]
        public void iswhiteTest()
        {
            Search_student ss = new Search_student();
            Assert.IsFalse(ss.iswhite(""));
        }
    }

    [TestClass()]
    public class reset_pwtest
    {
        [TestMethod()]
        public void isnull()
        {
            Reset_password ss = new Reset_password();
            Assert.IsFalse(ss.isnull("stu","231","1223"));
        }
    }

    [TestClass()]
    public class reset_pwusertest
    {
        [TestMethod()]
        public void userstudenttest()
        {
            Reset_password ss = new Reset_password();
            Assert.IsTrue(ss.studentuser("stu"));
        }
    }
}