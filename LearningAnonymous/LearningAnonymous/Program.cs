using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading Files");
            Download();
            Console.ReadLine();
        }
        
        static void Download()
        {
            Network.Download((message) => Console.WriteLine("Download Completed" + message));
        }
  
        class Network
        {
            static public void Download(Action<String> callback)
            {
                    Task.Run(() => {
                        Thread.Sleep(3000);
                        callback(" Completed");
                    });
            }
        }

    }
}
