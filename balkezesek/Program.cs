using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat:
            List<Balkezes> balkezesek = new List<Balkezes>();
            string[] olvasottBalkezesek = File.ReadAllLines("Sources\\balkezesek.csv");

            for (int i = 1; i < olvasottBalkezesek.Length; i++)
            {
                string[] tagok = olvasottBalkezesek[i].Split(';');
                Balkezes ujBalkezes = new Balkezes(tagok[0], tagok[1], tagok[2], int.Parse(tagok[3]), int.Parse(tagok[4]));
                balkezesek.Add(ujBalkezes);
            }

            // 3. feladat:
            Console.WriteLine($"3. feladat: {balkezesek.Count}");

            // 4. feladat:
            Console.WriteLine("4. feladat:");
            foreach (var i in balkezesek)
            {
                if (i.UtolsoEv == 1999 && i.UtolsoHonap == 10)
                {
                    Console.WriteLine($"\t{i.Nev}: {Math.Round(i.Magassag * 2.54, 1)} cm");
                }
            }

            //5.feladat:
            Console.WriteLine("5. feladat:");
            int evszam = 0;
            do
            {
                Console.Write("Kérek egy 1990 és 1999 közötti számot!: ");
                evszam = Convert.ToInt32(Console.ReadLine());
                if (1990 <= evszam && evszam <= 1999)
                {
                    break;
                }
                else
                {
                    Console.Write("Hibás adat!");
                }

            } while (true);

            //6. feladat:
            Console.WriteLine(Math.Round(balkezesek.Where(x => x.ElsoEv <= evszam && x.UtolsoEv >= evszam).Average(x => x.Suly), 2));
        }
    }
}