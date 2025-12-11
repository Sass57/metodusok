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
                    ;
                    break;
                case 3:
                    PitagoraszSzamitas();
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

    }
}
