using NUnit.Framework;
using SharedProject;
using System;

namespace NUnitTestCore
{
    public class NUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase(18)]
        [TestCase(17)]
        //[TestCase(8000)]
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

        [Test]
        public void TestSickCovid()
        {
            string name = "Julio";
            bool result = Helper.VerifyDangerSick(name);
            Assert.IsTrue(result);
        }
    }
}