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
            menupontok.Add("Megszerkeszthető-e a háromszög");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
            double a_Oldal = Convert.ToDouble(Console.ReadLine());
            double b_Oldal = Convert.ToDouble(Console.ReadLine());
            double c_Oldal = Convert.ToDouble(Console.ReadLine());


        }


        private static int ListazMenu(List<string> menupontok)
        {
            Console.WriteLine("Válassz egy menüpontot!");
            Console.WriteLine();

            for (int i = 0; i < menupontok.Count; i++)
            {
                int sorszam = i + 1;
                string szoveg = menupontok[i];
                Console.WriteLine(sorszam + ". " + szoveg);
            }

            Console.WriteLine();
            Console.Write("Írd be a választott menüpont számát: ");

            int valasztas = 0;
            string bevitel = Console.ReadLine();
            bool siker = int.TryParse(bevitel, out valasztas);

            while (!siker || valasztas < 1 || valasztas > menupontok.Count)
            {
                Console.Write("Hibás adat! Kérlek adj meg egy számot 1 és " + menupontok.Count + " között: ");
                bevitel = Console.ReadLine();
                siker = int.TryParse(bevitel, out valasztas);
            }

            return valasztas;
        }

        private static void FeladatValasztas(List<string> menupontok)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    double a_Oldal = Convert.ToDouble(Console.ReadLine());
                    double b_Oldal = Convert.ToDouble(Console.ReadLine());
                    double c_Oldal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"kerület: {KeruletSzamitas(a_Oldal, b_Oldal, c_Oldal)}");
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
        private static void TeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Háromszög terület számítása");
            Console.WriteLine("");

            Console.Write("Add meg az alap hosszat (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Add meg a magasságot (ma): ");
            double ma = double.Parse(Console.ReadLine());

            double terulet = (a * ma) / 2;

            Console.WriteLine($"A háromszög területe: {terulet}");
        }





    }

}
        private static void PitagoraszSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Pitagorasz tétel számítás");

            Console.Write("Add meg az a oldalt: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Add meg a b oldalt: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Az átfogó értéke: {c}");
        }

        private static void MegszerkeszthetoE(double a_oldal, double b_oldal, double c_oldal)
        {
            if (a_oldal + b_oldal > c_oldal && b_oldal + c_oldal > a_oldal && a_oldal + c_oldal > b_oldal)
            { Console.WriteLine("Igen,a haromsög megszerkeszthető"); }
            else { Console.WriteLine("Sajnálom,a háromszög nem szerkeszthető meg"); }


        }



        public static double KeruletSzamitas(double a_Oldal, double b_Oldal, double c_Oldal)
        {
            double kerulet = a_Oldal + b_Oldal + c_Oldal;
            return kerulet;

        }
    }
}
