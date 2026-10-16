using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrik_Kalandpark
{
    internal class Program
    {
        static void Menukiir()
        {
            Console.WriteLine("=== PETRK KALANDPARK ===");
            Console.WriteLine("1.) Napijegy vásárlása");
            Console.WriteLine("2.) Pálya Választása");
            Console.WriteLine("3.) Kupon kalkulátor");
            Console.WriteLine("4.) Napi bevétel");
            Console.WriteLine("5.) Kilépés");
            Console.WriteLine();
            Console.Write("Választás: ");
        }

        static string JegyTipus(int kor)
        {
            if (kor < 8 && kor > 0)
            {
                return "Mini jegy";
            }
            if (kor < 16 && kor > 7)
            {
                return "Junior jegy";
            }
            if (kor <25 && kor > 15)
            {
                return "Ifjúsági jegy";
            }
            if (kor <60 && kor > 24)
            {
                return "Felnőttjegy";
            }
            else
            {
                return "Senior jegy";
            }

        }
        static int JegyAr(int kor)
        {
            if (kor < 8 && kor > 0)
            {
                return 1000;
            }
            if (kor < 16 && kor > 7)
            {
                return 2200;
            }
            if (kor < 25 && kor > 15)
            {
                return 3000;
            }
            if (kor < 60 && kor > 24)
            {
                return 4500;
            }
            else
            {
                return 2800;
            }
        }
        static string PalyaValasztas(int palya, int magassag)
        {
            switch (palya)
            {
                case 1:
                    if (magassag>= 90)
                    {
                        return "Használhatod a pályát! :)";
                    }
                    else
                    {
                        return "NEM használhatod a pályát! :(";
                    }
                case 2:
                    if (magassag >= 130)
                    {
                        return "Használhatod a pályát! :)";
                    }
                    else
                    {
                        return "NEM használhatod a pályát! :(";
                    }
                case 3:
                    if (magassag >= 160)
                    {
                        return "Használhatod a pályát! :)";
                    }
                    else
                    {
                        return "NEM használhatod a pályát! :(";
                    }
                default:
                    return "Nincs ilyen pálya";
            }
        }
        static int KuponosAr(int ar, int kupon)
        {
            switch (kupon)
            {
                case 1:
                    return ar;
                case 2:
                    return ar - (ar * 10)/100;
                case 3:
                    return ar - (ar * 25)/100;
                default:
                    return ar;

            }
        }
        static void Main(string[] args)
        {
            int valasztas = 0;
            int bevetel = 0;
            do
            {
                
                try
                {
                    Console.Clear();
                    Menukiir();
                    valasztas = Convert.ToInt32(Console.ReadLine());
                    switch (valasztas) {
                        case 1:
                            Console.Clear();
                            Console.Write("Kérem a neved: ");
                            string nev = Console.ReadLine();

                            Console.Write("Kérem az életkorod: ");
                            int kor = Convert.ToInt32(Console.ReadLine());
                            if (kor < 0 || kor > 120)
                            {
                                Console.WriteLine("Hibás Életkor");
                            }
                            else
                            {
                                string jegytipus = JegyTipus(kor);

                                int avr = JegyAr(kor);

                                Console.WriteLine($"Szia {nev}");
                                Console.WriteLine($"A jegytípus: {jegytipus}");
                                Console.WriteLine($"Fizatendő:{avr} Ft");

                                bevetel += avr;
                                
                            }
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine("=== KALANDPÁLYÁK ===");
                            Console.WriteLine("1.) Gyerekpálya");
                            Console.WriteLine("2.) Erdei Pálya");
                            Console.WriteLine("3.) Extrém pálya");
                            Console.Write("Választás: ");
                            int palya = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Magasság(cm-ben): ");
                            int magassag = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(PalyaValasztas(palya, magassag));
                            Console.ReadLine();

                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Kérlek add meg az eredeti árat: ");
                            int ar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("1.) Nincs Kupon");
                            Console.WriteLine("2.) SILVER Kupon - 10%");
                            Console.WriteLine("3.) GOLD Kupon - 25%");
                            Console.Write("Kupon: ");
                            int kupon = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Eredeti ár: {ar}");
                            Console.WriteLine($"Kupon {kupon}");
                            Console.WriteLine($"Fizetendő: {KuponosAr(ar, kupon)}");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("=== NAPI BEVÉTEL ===");
                            Console.WriteLine($"A kalandpark mai bevétele: {bevetel}");
                            Console.ReadLine();
                            break;
                    }

                }
                catch
                {
                    Console.WriteLine("Hibás! Egész számot kell használni!");
                    Console.ReadLine();
                }
            }
            while (valasztas != 5);
            {

            }
        }
    }
}
