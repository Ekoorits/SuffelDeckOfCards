using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuffelDeckOfCards
{
    internal class Program
    {
        static void Main()
        {
            List<string> kaardiPakk = KoostaKaardiPakk();

            SegaKaardid(kaardiPakk);

            Console.WriteLine("Kaardid on segatud:\n");
            PrindiKaardid(kaardiPakk);

            Console.WriteLine();

        }

        static List<string> KoostaKaardiPakk() 
        {
            List<string> kaardiPakk = new List<string>();

            string[] mastid = { "Ärtu", "Ruutu", "Poti", "Risti" };
            string[] kaardid = {"2", "3", "4", "5",  "6", "7", "8", "9", "10", "Soldat", "Emand", "Kuningas", "Äss" };
            
            foreach (var mast in mastid)
            {
                foreach (var kaart in kaardid)
                {
                    kaardiPakk.Add($"{mast} {kaart}");
                }
            }
            
            return kaardiPakk;
        }

        static void SegaKaardid(List<string> kaardiPakk)
        {
            Random juhuslik = new Random();
            
            for (int i = kaardiPakk.Count -1; i > 0; i--)
            {
                int j = juhuslik.Next(0, i + 1);

                (kaardiPakk[j], kaardiPakk[i]) = (kaardiPakk[i], kaardiPakk[j]);
            }
        }

        static void PrindiKaardid(List<string> kaardiPakk)
        {
            
            foreach (var kaart in kaardiPakk)
            {
                Console.WriteLine(kaart);
            }
        }
    }
}
