using System;
using System.IO;

namespace rss_counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateipfad = "C:\\Users\\flori\\Downloads\\Lern_Atelier_I23d_14-main\\Lern_Atelier_I23d_14-main\\rss counter\\rss counter\\varwert.txt";
            int[] werte;
            int[] rss;
            string[] type;
            int[] nr;
            string text1;

            werte = new int[11];
            werte[0] = 56000; // ems
            werte[1] = 5300;  // gunpowder
            werte[2] = 5300;  // redstone
            werte[3] = 5000;  // slime
            werte[4] = 7450;  // spruce
            werte[5] = 7100;  // jungle
            werte[6] = 8500;  // acacia
            werte[7] = 9650;  // birch
            werte[8] = 11500; // cherry blossom
            werte[9] = 9500;  // oak (azalea)
            werte[10] = 8500; // oak

            rss = new int[11];

            if (File.Exists(dateipfad))
            {
                string[] lines = File.ReadAllLines(dateipfad);
                for (int i = 0; i < rss.Length; i++)
                {
                    if (i < lines.Length && int.TryParse(lines[i], out int value))
                    {
                        rss[i] = value;
                    }
                    else
                    {
                        rss[i] = 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Die Datei existiert nicht.");
            }

            type = new string[11];
            type[0] = "Emeralds";
            type[1] = "Gunpowder";
            type[2] = "Redstone";
            type[3] = "Slime";
            type[4] = "Spruce";
            type[5] = "Jungle";
            type[6] = "Acacia";
            type[7] = "Birch";
            type[8] = "Cherry Blossom";
            type[9] = "Oak (Azalea)";
            type[10] = "Oak";

            nr = new int[11];
            nr[0] = 0;
            nr[1] = 1;
            nr[2] = 2;
            nr[3] = 3;
            nr[4] = 4;
            nr[5] = 5;
            nr[6] = 6;
            nr[7] = 7;
            nr[8] = 8;
            nr[9] = 9;
            nr[10] = 10;

            int t = 0;
            Console.WriteLine("#################################");
            
            // Ausgabe von den vorhandenen RSS (**Formatiert**) 
                Console.WriteLine("{0,-10} {1,-10} {2,-20}\n", nr[t], type[t], rss[t]);

                for (int i = 0; i < nr.Length; i++)
                {
                    Console.WriteLine("{0,-10} {1,-10:N1} {2,-20}", nr[i], type[i], rss[i]);
                }
                    t++;
            
            Console.Write("Mit was wollen Sie rechnen? ");
            int rsp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#################################");

            rsp -= 1;

            if (rsp >= 0 && rsp < rss.Length)
            {
                Console.WriteLine(type[rsp] + ": " + rss[rsp]);
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl.");
            }

            File.WriteAllLines(dateipfad, Array.ConvertAll(rss, x => x.ToString()));
        }
    }
}
