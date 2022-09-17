using System;
namespace Converter
{
    class Converter
    {
        private double Uah { get; set; }

        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double USD, double EUR, double RUB)
        {
            this.usd = USD;
            this.eur = EUR;
            this.rub = RUB;
        }

        public double Result()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int n;

            switch (s)
            {

                case 1:
                    Console.WriteLine("From hryvnia to dollar:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double u = n / usd;
                    Console.WriteLine($"Result: {u} dollars.");
                    break;

                case 2:
                    Console.WriteLine("From hryvnia to euro:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double e = n / eur;
                    Console.WriteLine($"Result: {e} euros.");
                    break;

                case 3:
                    Console.WriteLine("From hryvnia to ruble:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double r = n / rub;
                    Console.WriteLine($"Result: {r} rubles.");
                    break;

                case 4:
                    Console.WriteLine("From dollar to hryvnia");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Uah = n * usd;
                    Console.WriteLine($"Result: {Uah} hryvnias.");
                    break;

                case 5:
                    Console.WriteLine("From euro to hryvnia:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Uah = n * eur;
                    Console.WriteLine($"Result: {Uah} hryvnias.");
                    break;

                case 6:
                    Console.WriteLine("From ruble to hryvnia:");
                    Console.Write("Enter numbers: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Uah = n * rub;
                    Console.WriteLine($"Result: {Uah} hryvnias.");
                    break;

                default:
                    Console.WriteLine("The range of numbers is within 1 to 6!");
                    break;
            }
            return Uah;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Оберiть потрібну фiнансову операцiю (1-6):");
            Console.WriteLine("1.Купівля usd за uah;");
            Console.WriteLine("2.Купівля eur за uah;");
            Console.WriteLine("3.Купівля rub за uah;");
            Console.WriteLine("4.Купівля uah за usd;");
            Console.WriteLine("5.Купівля uah за eur;");
            Console.WriteLine("6.Купівля uah за rub.");

            Converter convert = new Converter(41, 40.7, 7.74);
            convert.Result();
        }
    }
}