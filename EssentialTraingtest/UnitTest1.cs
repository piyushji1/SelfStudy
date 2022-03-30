using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace Essential_training_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testinstance = new Class1();
            var testREsult = testinstance.AddTwo(9, 5);
            Assert.AreEqual(14, testREsult, "sbhxjd");
        }
    }
}

