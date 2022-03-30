using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace LearningDotNet
{
    internal class Program
    {
       //static ConcurrentDictionary<int ,int > obj= new ConcurrentDictionary<int ,int>(); // Concurrent Dictionary
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadLine();


            ///// List ******************
            //List<string> Customers = new List<string>();// List

            ////Adding Members

            //Customers.Add("Kim");
            //Customers.Add("Piyush");
            //Customers.Add("Sinha");
            ////Foreach loop to get all the members

            //foreach(var obj in Customers)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine(Customers[2]);
            //Console.ReadLine();

            ////Dictionary ****************
            //Dictionary <String,String> Config = new Dictionary<String,String>();
            //Config.Add("Resolution", "1920 X 1080");
            //Config.Add("Type", "LED");
            //foreach (var obj1 in Config)
            //{
            //    Console.WriteLine(obj1.Key);

            //}
            //Console.WriteLine(Config["Resolution"]);
            //Console.ReadLine();

            ////Array ********************
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Piyush");
            //String s= (String) arrayList[0];
            //Console.ReadLine();

            ////Hashtable *****************

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Table", "Wooden");
            //var s = (String)hashtable["Table"];
            //Console.WriteLine(s);
            //Console.ReadLine();

            ////Concurent Dictionary ***********
            //Thread thread1 = new Thread(new ThreadStart(Additem));//Intialize the Thread
            //Thread thread2 = new Thread(new ThreadStart(Additem));
            //thread1.Start();//Thraed start
            //thread2.Start();

            ////BitArray For Boolean************

            ////Adding Member by Boolean Array
            //bool[] preload = new bool[3] {false,true,false};
            //BitArray enemygrid = new BitArray(preload);

            ////// Adding Member 
            ////enemygrid[0] = false;
            ////enemygrid[1] = true;
            //////Another method
            ////enemygrid.Set(2, false);
            //foreach(var item in enemygrid)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}

            ////************ Tuple
            ////one way to intialize the tuple
            //Tuple<int, string, bool> obj = new Tuple<int, string, bool>(1,"True",false);
            ////Anothe clean way
            //var MyTuple = Tuple.Create(1, "True", false);
            //Console.WriteLine(MyTuple.Item2);
            //Console.ReadLine();

            ////Stack **************** 
            //Stack<int> pan = new Stack<int>();
            //pan.Push(1);
            //pan.Push(2);
            //pan.Push(3);
            ////foreach(var obj in stack)
            ////{
            ////    Console.WriteLine(obj);
            ////    Console.ReadLine();
            ////}
            //Console.WriteLine(pan.Pop());
            //Console.WriteLine(pan.Peek());

            //Console.WriteLine(pan.Peek());
            //Console.ReadLine();

            ////Queue **************
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //    queue.Enqueue(2);
            //       queue.Enqueue(3);
            ////foreach(var item in queue)
            ////{
            ////    Console.WriteLine(item);
            ////    Console.ReadLine();
            ////}
            //Console.WriteLine(queue.Dequeue());
            //Console.ReadLine();

            ////Hash Sets***********
            //var set = new HashSet<string>();
            //set.Add("Piyush");
            //set.Add("Piyush");
            //String[] s =new String[]{"Piyush"};
            //Console.WriteLine(set.Overlaps(s));
            //Console.WriteLine(set.Count);
            //Console.ReadLine();

            ////Async Programming*************

            //Console.WriteLine("Downloading Files");
            //Down();
            //Console.ReadLine();

            //////////******* String Interpolation
            //var world = "world";
            //var s = "hello" + world;
            //var s2 = $"hello{world}";
            //Console.WriteLine(s);
            //Console.WriteLine(s2);
            //Console.ReadLine();

            //var point = new {x=1,y=2};
            //Console.WriteLine("x "+point.x +"y "+point.y);
            //Console.WriteLine("x {0}y {1}",point.x,point.y);
            //Console.WriteLine($"x {point.x}y {point.y}");
            //Console.ReadLine();


        }
        //// Using Dictionary in a way to be in thread safe(Concurrent)
        //static void Additem()
        //{
        //    obj.TryAdd(1,2);
        //    Console.WriteLine(obj.Count);
        //    Console.ReadLine();

        //}
        //static void Down()//It is for Async Programming
        //{
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(3000);
        //        Console.WriteLine("Downloading Completed");
        //    });
        //}


    }
}
