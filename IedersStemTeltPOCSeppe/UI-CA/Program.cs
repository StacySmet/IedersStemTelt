using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.UI.CA
{
    class Program
    {
        private static bool quit = false;

        static void Main(string[] args)
        {
            while (!quit)
            {
                ShowMenu();

            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1) Vragen");
            Console.WriteLine("0) Afsluiten");
            Console.Write("keuze => ");
            string keuze = Console.ReadLine();
            int keuze_int;
            if(int.TryParse(keuze, out keuze_int))
            {
                switch (keuze_int)
                {
                    case 1:
                        ToonVraag();
                        break;
                    case 2:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Geen geldige keuze!");
                        break;
                }
            }else
            {
                Console.WriteLine("Geef een 1 of 0 in!");
            }
        }

        private static void ToonVraag()
        {
            //Show question
        }
    }
}
