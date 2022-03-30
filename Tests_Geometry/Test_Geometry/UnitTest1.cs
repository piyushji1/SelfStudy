using NUnit.Framework;


namespace Test_Geometry
{
    public class Tests
    {

        [TestClass]
        public void Test1_Geometry()
        {
            Square s = new Square();
            s.Width = 10;

            Rectangle r = new Rectangle();
            r.Width = 20;
            r.Height = 20;
        }
        public class Polygon
        {

        }
        public class Square
        {
            public uint Width { get; set; }
        }
        public class Rectangle
        {
            public virtual uint Width { get; set; }
            public virtual uint Height { get; set; }
        }

    }
}