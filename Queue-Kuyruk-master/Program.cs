using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Queue dizi = new Queue();
           dizi.Enqueue("1");
            dizi.Enqueue("2");
            dizi.Enqueue("3");
            
           

            var son = dizi.Peek();
            dizi.Dequeue();
           
         
            Console.ReadLine();
        }








    }
}
