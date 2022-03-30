using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test002
{
    [TestClass]
    public class Test_NetFramwork
    {
        [TestMethod]
        public void Test_002()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Assert.IsTrue(numbers is IEnumerable<int>);
            var e = numbers.GetEnumerator();
            Assert.IsTrue(e is IEnumerator<int>);

            while (e.MoveNext())
            {

                int i = e.Current;
                Debug.WriteLine($"{nameof(Test_002)}::{nameof(Test_002)}::{i}");
            }
        }
    }
}