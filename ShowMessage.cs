using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessage
    {
        public static void AppendMessage(string sTesto)
        {
            //Prima implementazione RICORSIVA la funzione richiama se stessa

            //if (sTesto.Length > 10)
            //{
            //    Console.WriteLine(sTesto.Substring(0, 10));
            //    AppendMessage(sTesto.Substring(10));
            //} else {
            //    Console.WriteLine(sTesto);
            //}

            //---------------------

            //Seconda implementazione ITERATIVA

            //while (sTesto.Length > 10)
            //{   
            //    //immaginando di usare la stringa "zio paperone"
            //    Console.WriteLine(sTesto.Substring(0, 10)); //prendo i primi 10 della stringa: "zio papero"
            //    sTesto = sTesto.Substring(10); //substring(10) prende i caratteri dal decimo in poi: "ne"
            //}
            //Console.WriteLine(sTesto);

            //---------------------

            //Terza implementazione ITERATIVA SUI SINGOLI CARATTERI

            //int pos = 0;
            //foreach (char c in sTesto)
            //{
            //    if (pos == 10)
            //    {
            //        Console.WriteLine();
            //        pos = 0;
            //    }
            //    Console.Write(c);
            //    pos++;
            //}
        }
    }
}
