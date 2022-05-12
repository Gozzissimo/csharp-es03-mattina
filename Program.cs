// See https://aka.ms/new-console-template for more information

//Aggiungete una classe che forma un Borsellino, ognivolta che
//chiamo il metodo Add(valore) il borsellino si incrementa del valore passato come parametro e lo stampa a schermo
//L aclasse la chiameremo Borsellino e il metodo int Add(int valore)

using System;

namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.AppendMessage("Nel mezzo del cammin di Montefiascone dissi Est!!! Est!!! Est!!!");

            //Questo funziona con classe e metodi statici (ho un solo borsellino)
            //duo modi di leggere a terminale un numero e assegnarlo a una variabile
            //int valore;
            ////while (int.TryParse(Console.ReadLine(), out valore))
            //string svalore = Console.ReadLine();
            //valore = Convert.ToInt32(svalore);
            //while (valore != 0)
            //{
            //    Console.WriteLine(Borsellino.Add(valore));
            //    svalore = Console.ReadLine();
            //    valore = Convert.ToInt32(svalore);
            //}

            //Questo funziona con N borsellini (classi e metodi non statici)
            Salvadanaio salva1 = new Salvadanaio();
            Salvadanaio salva2 = new Salvadanaio();
            int valore;
            while (int.TryParse(Console.ReadLine(), out valore))
            {
                Console.WriteLine(salva1.Add(valore)); //scrive il nel totale dell'oggeto salva1
                
                valore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(salva2.Add(valore)); //scrive il nel totale dell'oggeto salva2
            }
        }
    }
}
