using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PRUEBA3
{

    class RegValue
    {
        private static string MAINPATH = @"C:\_Marcos\Trading\Values";
        private static int FRECUENCY = 5; //in second
        private string FULLPATH = string.Empty;
        private string COIN = string.Empty;

        private List<double> lValues = null;
        private DateTime dValues;
        public RegValue(string coin)
        {
            if (string.IsNullOrEmpty(coin)) throw new Exception("coin no puede ser null");
            this.COIN = coin;
            this.FULLPATH = MAINPATH + @"\" + coin + ".log";
            this.lValues = new List<double>();
        }

        ~RegValue()
        {

        }

        public void setValue(double val)
        {
            if (lValues.Count > 0){
                if (DateTime.Now.AddMinutes (-1*FRECUENCY) > dValues ){
                    printValue ();
                }
            }
            
            if (lValues.Count == 0) dValues = DateTime.Now;
            lValues.Add(val);
        }

        private void printValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[" + DateTime.Now + "][" + COIN + "][");
            foreach (double v in lValues) sb.Append(v.ToString() + "|");

            var toPrint = sb.ToString();
            toPrint = toPrint.Remove(toPrint.Length - 1);
            if (printLineToFile("[" + DateTime.Now + "][" + COIN + "][" + toPrint + "]")) lValues.Clear();
        }
        private bool printLineToFile(string text)
        {
            try
            {
                File.AppendText(text + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Logger.e("Error escribiendo en fichero " + FULLPATH);
                Logger.e("Error:" + ex.Message, ex);
                return false;
            }
            return true;
        }
    }
}
