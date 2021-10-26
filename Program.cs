using PruebaTonta.clasess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaTonta
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinanceCoin bc = new BinanceCoin("1INCH");
            //try
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.WriteLine(bc.getValue());
            //        System.Threading.Thread.Sleep(5000);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error:" + ex.Message);
            //}

            //PrintValues(bc.allValues);

            DateTime final = DateTime.Now.AddSeconds(10);
            //PruebaHilo ph = new PruebaHilo();
            //Thread th1 = new Thread(new ThreadStart(ph.start));
            //th1.Start();
            PruebaHilo2 ph2 = new PruebaHilo2("id1", 300);
            PruebaHilo2 ph3 = new PruebaHilo2("id2", 500);
            ph2.start();
            ph3.start();
            do
            {
                System.Threading.Thread.Sleep(100);
            } while (DateTime.Now < final);

            Console.WriteLine("Paro Hilo");
            ph2.stop();
            ph3.stop();
            //th1.Abort();

            Console.WriteLine("Hilo parado");
            System.Threading.Thread.Sleep(3000);
            int i = 0;
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
