namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UdvozloKep();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            FeladatValasztas();
            Console.WriteLine("Vége!");

   

        }

        private static void ListazMenu(List<string> menupontok)
        {
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("Kerület számítás");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("Terület számítás");
        }

        private static int FeladatValasztas(List<string> menupontok)
        {
            int i =Convert.ToInt32(Console.ReadKey());
            switch (i)
            {
                case 1:
            double a_Oldal = Convert.ToDouble(Console.ReadLine());
            double b_Oldal = Convert.ToDouble(Console.ReadLine());
            double c_Oldal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"kerület: {KeruletSzamitas(a_Oldal,b_Oldal,c_Oldal)}");
                    break;
                case 2:

                    break;
                default:
                    Console.WriteLine($"Nem olyan szmot adtál meg ami 1-{menupontok.Count} között van");
                    break;
            }
        }
        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");

        }
        private static double KeruletSzamitas(double a_Oldal, double b_Oldal, double c_Oldal)
        {
            double kerulet = a_Oldal + b_Oldal + c_Oldal;
            return kerulet;

        }
    }
}
