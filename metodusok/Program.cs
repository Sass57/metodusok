namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UdvozloKep();
            List<string> menupontok = new List<string>();

            menupontok.Add("Kerület számítása (F1)");
            menupontok.Add("Terület számítása (F2)");
            menupontok.Add("Pitagorasz számítás (F3)");
            menupontok.Add("Megszerkeszthető-e a háromszög (F4)");
            menupontok.Add("Kilépés (Esc)");
            ListazMenu(menupontok);
            FeladatValasztas(menupontok);
            Console.WriteLine("Vége!");
        }

        private static void ListazMenu(List<string> menupontok)
        {
        //TODO: Mászlai Munkája
            Console.SetCursorPosition(30, 3);
            Console.WriteLine("Válassz egy mnüponot!");
            int sor = menupontok.Count;
            foreach (string pont in menupontok)
            {
                Console.SetCursorPosition(30, sor);
                Console.WriteLine(pont);

                sor++;
            }

        }

        private static void FeladatValasztas(List<string> menupontok)
        {
            //TODO: Tas munkája

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    KeruletSzamitas();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    TeruletSzamitas();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    PitagoraszSzamitas();
                    break;
                case ConsoleKey.F4:
                    Console.Clear();
                    MegszerkeszthetoE();
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
            //TODO Mászlai munkája
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








        public static void PitagoraszSzamitas()
        {
            //TODO: Kujbus munkája
            Console.Clear();
            Console.WriteLine("Pitagorasz tétel számítás");

            Console.Write("Add meg az a oldalt: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Add meg a b oldalt: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Az átfogó értéke: {c}");
        }

        private static void MegszerkeszthetoE()
        {
            //TODO Kujbus munkája
            double a_oldal = Convert.ToDouble(Console.ReadLine());
            double b_oldal = Convert.ToDouble(Console.ReadLine());
            double c_oldal = Convert.ToDouble(Console.ReadLine());

            if (a_oldal + b_oldal > c_oldal && b_oldal + c_oldal > a_oldal && a_oldal + c_oldal > b_oldal)
            { Console.WriteLine("Igen,a haromsög megszerkeszthető"); }
            else { Console.WriteLine("Sajnálom,a háromszög nem szerkeszthető meg"); }


        }



        private static void KeruletSzamitas()
        {
            //TODO Tas munkája
            Console.Write("Add meg a 3 oldal hosszát! ");
            double a_Oldal = Convert.ToDouble(Console.ReadLine());
            double b_Oldal = Convert.ToDouble(Console.ReadLine());
            double c_Oldal = Convert.ToDouble(Console.ReadLine());

            double kerulet = a_Oldal + b_Oldal + c_Oldal;
            Console.WriteLine(kerulet);
        }
    }
}
