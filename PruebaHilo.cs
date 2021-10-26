using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTonta.clasess
{
    class PruebaHilo
    {
        int i = 0;
        public void start()
        {
            while (true)
            {
                Console.WriteLine("Pinto " + (i++));
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
