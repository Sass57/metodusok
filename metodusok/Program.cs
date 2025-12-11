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

            switch: (menupontok)
            {
                case 1:
                    ;
                    break;
                case 2:
                    TeruletSzamitas();
                    break;
                case "Kilépés":
                    Console.WriteLine("Kilépés...");
                    break;
                default:
                    Console.WriteLine("");
                    break;
                }
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
