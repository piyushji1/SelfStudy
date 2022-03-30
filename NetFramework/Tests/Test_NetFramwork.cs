using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Tests
{
    [TestClass]
    public class Test_NetFramwork
    {
        [TestMethod]
        public void Test_001()
        {
            var numbers = new List<int> { 1,2,3,4,5};
            Assert.IsTrue(numbers is IEnumerable<int>);
           var e=numbers.GetEnumerator();
            Assert.IsTrue(e is IEnumerator<int>);

            bool hasdata=e.MoveNext();
            Assert.IsTrue(hasdata);
            int i = e.Current;
            Assert.IsTrue(i == i);
        }
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
                Debug.WriteLine($"{nameof(Test_002)}::{nameof(i)}::{i}");
            }
        }
        [TestMethod]
        public void Test_003()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Assert.IsTrue(numbers is IEnumerable<int>);
            foreach(var i in numbers)
            {

               
                Debug.WriteLine($"{nameof(Test_003)}::{nameof(i)}::{i}");
            }
        }
        [TestMethod]
        public void Test_004()
        {
            var a = new int[] {1,2,3,4,5};
            Assert.IsTrue(a is IEnumerable<int>);
            Assert.IsTrue(a is IList<int>);

            var l = new List<int>() { 1, 2, 3, 4, 5 };
            Assert.IsTrue(l is IEnumerable<int>);
            Assert.IsTrue(l is IList<int>);

        }
        static string filename = @"..\..\..\..\..\..\..\Enviromental_Data_Deep_Moor_2020.txt";
        [TestMethod]
        public void Test_010_FileStream()
        {
            
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            var b1= fs.ReadByte();
            var c2= (char)b1;
            Assert.IsTrue(c2 == 'd');
            fs.Close();


        }
        [TestMethod]
        public void Test_011_FileStream()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                var b1 = fs.ReadByte();
                var c2 = (char)b1;
                Assert.IsTrue(c2 == 'd');
            }
            finally
            {
                fs.Close();
            }
          


        }
        [TestMethod]
        public void Test_012_FileStream()
        {
            FileStream fs = null;
            IDisposable idfs = fs;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                var b1 = fs.ReadByte();
                var c2 = (char)b1;
                Assert.IsTrue(c2 == 'd');
            }
            finally
            {
                idfs?.Dispose();
            }

        }
        [TestMethod]
        public void Test_013_FileStream()
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            //FileStream fs = null;
            //IDisposable idfs = fs;
            //try
            {
                //fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                var b1 = fs.ReadByte();
                var c2 = (char)b1;
                Assert.IsTrue(c2 == 'd');
            }
            
        }
        [TestMethod]
        public void Test_014_FileStream()
        {
            using (var fs = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))

            {
                var b1 = fs.ReadLine();
            }

        }
        [TestMethod]
        public void Test_015_FileStream()

        {

            using (var sr = new StreamReader(filename))

            {
                var line1 = sr.ReadLine();
                string line =null;
                  while((line = sr.ReadLine()) != null)
                  {

                    var data =line.Split('\t');
                    Assert.IsTrue(data.Length == 8);
                  }
            }
        }
        [TestMethod]

        public void Test_016_FileStreen()
        {

            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();

                IEnumerator<string> e = GetData(sr).GetEnumerator();
                while (e.MoveNext())
                {

                    var data = e.Current.Split('\t');
                }
            }
        }
            private static IEnumerable<string> GetData(StreamReader sr)

            {

                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        [TestMethod]
        public void Test_017_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();
                foreach (var line in GetData(sr))
                {
                    var data = line.Split('\t');
                }
            }

        }
        [TestMethod]
        public void Test_018_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();
                foreach (var line in GetTextData(sr))
                {
                    var data = line.Split('\t');
                }
            }

        }
        private static IEnumerable<string> GetTextData(StreamReader Text)
        {
            string line = null;
            while((line= Text.ReadLine()) != null)
            {
                yield return line;
            }
        }


    }
}