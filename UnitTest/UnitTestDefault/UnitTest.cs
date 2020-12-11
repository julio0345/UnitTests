using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedProject;
using System;

namespace UnitTestDefault
{
    [TestClass]
    public class UnitTest
    {
        [TestInitialize]
        public void init()
        {
            //Just Initialize every time
        }

        [TestMethod]
        public void TestAgeMoreThan18()
        {
            int age = 18;
            bool result = Helper.VerifyDangerAge(age);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(17)]
        //[DataRow(19)]
        //[DataRow(8000)]
        public void TestAgeLessThan18(int age)
        {
            bool? result;
            result = Helper.VerifyDangerAge(age);
            Assert.IsFalse(result.Value);
            Assert.AreEqual(age + 1, 18);
            Object ob1 = null;
            Object ob2 = null;
            Assert.AreSame(ob1, ob2);
            ob2 = 2;
            Assert.AreNotSame(ob1, ob2);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestSickCovid()
        {
            string name = "Julio";
            bool result = Helper.VerifyDangerSick(name);
            Assert.IsTrue(result);
        }
    }
}