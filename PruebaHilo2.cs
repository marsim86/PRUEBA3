using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaTonta.clasess
{
    class PruebaHilo2
    {
        private Thread th = null;
        private string id = string.Empty;
        private int msEspera = 1000;

        public PruebaHilo2(string id, int msEspera){
            this.id = id;
            this.msEspera = msEspera;
            th = new Thread(new ThreadStart(this.method));
        }

        private void method()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Pinto [" + this.id + "] -> " + (i++));
                System.Threading.Thread.Sleep(msEspera);
            }
        }

        public void start(){
            this.th.Start();
        }

        public void stop()
        {
            this.th.Abort();
        }


    }
}
