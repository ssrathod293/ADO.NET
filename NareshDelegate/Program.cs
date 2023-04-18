using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshDelegate
{
    class Program
    {
        public delegate void addDel(int x, int y);
        public delegate void HelloDel(string msg);
        public  delegate int sumDel(int x, int y);
        public delegate string sayHelloDel(string msg);
        public delegate void Caldel(int x,int y);
        static void Main(string[] args)
        {
            /* DelDemo1 d1 = new DelDemo1();
             addDel del1 = new addDel(d1.add);
             del1(10, 20);
             HelloDel del2 = new HelloDel(d1.Hello);
             del2("Hello");
             DelDemo2 d2 = new DelDemo2();
             sumDel del3 =new sumDel(d2.sum);
             Console.WriteLine(del3(23, 34));
             sayHelloDel del4 = new sayHelloDel(d2.sayHello);
             Console.WriteLine(del4("shrikant"));*/
            ///////////multicast delegate////////////////////
            //DelDemo3 d3 = new DelDemo3();
            //Caldel del = d3.add;
            //del += d3.sub;del += d3.mul;del += d3.div;
            //del(30,20);
            //del(23,15);
            //Console.WriteLine("-------");
            //del -= d3.sub;del -= d3.div;
            //del(30, 20);

            ////////////////anonymous method in c#////////////////////////////
            //Caldel d1 = delegate (int x, int y)
            //{
            //    Console.WriteLine($"sum:{x+y}");
            //    Console.WriteLine($"sub:{x-y}");
            //    Console.WriteLine($"mul:{x*y}");
            //};
            //sayHelloDel d2 = delegate (string msg)
            //{
            //    return "Hello " + msg;
            //};
            //d1(20,10);
            //Console.WriteLine(d2("shrikant ")); 
            /////////////////////////////////////////////////////////////////////
            /////////////////////lambada expressions/////////////////////
            Caldel d1 = (x,y)=>
            {
                Console.WriteLine($"sum:{x + y}");
                Console.WriteLine($"sub:{x - y}");
                Console.WriteLine($"mul:{x * y}");
            };
            sayHelloDel d2 = (msg) => "Hello" + msg;
          
            d1(20, 10);
            Console.WriteLine(d2("shrikant "));
            Console.ReadLine();
        }

    }

   public class DelDemo3
    {
        public void add(int x, int y) { Console.WriteLine(x+y); }
        public void sub(int x, int y) { Console.WriteLine(x-y); }
        public void div(int x, int y) { Console.WriteLine(x/y); }
        public void mul(int x, int y) { Console.WriteLine(x*y); }
    }
    public class DelDemo2
    {
        public int sum(int x,int y)
        {
            return (x + y);
        }
        public string sayHello(string msg)
        {
            return "Hello" + msg;
        }
    }
    public class DelDemo1
    
    {
        public void add(int x,int y)
        {
            Console.WriteLine("sum:"+(x+y));
        }
        public void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    
}
