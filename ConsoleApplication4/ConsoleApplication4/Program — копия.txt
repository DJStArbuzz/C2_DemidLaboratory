using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class MyClass
    {
        private int alpha;
        private int beta;
        public int gamma;
        
        public void SetAlpha(int a)
        {
            alpha = a;
        }
                
        public int getAlpha()
        {
            return alpha;
        }
        public void SetBeta(int a)
        {
            beta = a;
        }

        public int getBeta()
        {
            return beta;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.SetAlpha(-99);
            ob.SetBeta(19);
            ob.gamma = 1;
            
            Console.WriteLine("Значение переменной ob.alpha = " + ob.getAlpha());
            Console.WriteLine("Значение переменной ob.beta = " + ob.getBeta());
            Console.WriteLine("Значение переменной ob.gamma = " + ob.gamma);
            Console.WriteLine("Значение переменной ob.beta = " + ob.beta);
            Console.ReadKey();
        }
    }
}
