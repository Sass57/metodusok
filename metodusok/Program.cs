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
            Console.WriteLine("Vége!");
            double a_Oldal = Convert.ToDouble(Console.ReadLine());
            double b_Oldal = Convert.ToDouble(Console.ReadLine());
            double c_Oldal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"kerület: {KeruletSzamitas}");
        }

        private static void ListazMenu(List<string> menupontok)
        {
            //Petra feladata
            Console.WriteLine("ide jött!");
            throw new NotImplementedException("Még nincs kész, ezért ne használd!");
            Console.WriteLine("ide már jut el!");
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
            throw new NotImplementedException("Még nincs kész, ezért ne használd!");
        }
    }
}
