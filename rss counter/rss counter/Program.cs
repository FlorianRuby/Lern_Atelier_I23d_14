using System.Security.Cryptography;

namespace rss_counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateipfad = "C:\\Users\\flori\\source\\repos\\rss counter\\rss counter\\varwert.txt";
            string[] werte;

            if (File.Exists(dateipfad))
            {
                string text = File.ReadAllText(dateipfad);
                werte = text.Split(",");
                foreach (var wert in werte)
                {
                    Console.WriteLine(wert);
                }
            }
            else
            { 
                Console.WriteLine("Keine Werte vorhanden.");
            }

            werte = new string[] { "Emeralds", "Gunpowder", "Redstone" };

            File.WriteAllText(dateipfad, string.Join(",", werte));

            Console.WriteLine("Werte in Datei aktualisiert und gespeichert:");
            foreach (var wert in werte)
            {
                Console.WriteLine(wert);
            }
        }
    }
}


/**
 * # Raidfarm
 * Emeralds 56k/h
 * Gunpowder 5.3k/h
 * Redstone 5.3k/h
 * 
 * Slime 5k/h
 * 
 * Wood
 * spruce 7450/h
 * Jungle 7100/h
 * Acacia 8500/h
 * Birch 9650/h
 * Cherry blossom ~11500/h
 * Oak (from azalea) 9500/h
 * 
 