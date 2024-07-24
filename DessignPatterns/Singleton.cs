using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDessignPatterns
{
    internal class Singleton
    {
        private int data;
        private Singleton() { }

        private static Singleton singleton = null!;
        static Singleton() { 
           singleton=new Singleton();
        }

        public static Singleton getInstance() { 
            return singleton;
        }

    }
}
