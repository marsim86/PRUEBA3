using System;

namespace PRUEBA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Servicio1 s1 = new Servicio1 ();
           // s1.call1 ();
           RegValue rv = new RegValue ("BTC");
           Random rnd = new Random();

           for (int i=0;i<10;i++){
               rv.setValue(rnd.NextDouble ());
               Console.WriteLine ("Pinta valor " + i);
               System.Threading.Thread.Sleep (1000);
           }
            Console.WriteLine  ("hola");
        }
    }
}
