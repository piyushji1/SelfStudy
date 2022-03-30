using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProperties
{
    class Player
    {
        public bool IsPlaying
        {
            get { return Health > 0; }
        }
        public int Health { get; private set; } = 100;
        public void Hit()
        {
            Random random = new Random();
            Health -= random.Next(5, 50);
        }
        //public void CheckDeath()
        //{
        //    if (health <= 0)
        //      IsPlaying = false;
        //}
    }

     class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i=0;i<20;i++)
            {
                player.Hit();
                Console.WriteLine("Is player alive:" + player.IsPlaying);
                


            }
            Console.ReadLine();
        }
    }
}
