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
                    Console.WriteLine("Ви обрали купiвлю usd за uah : ");
                    Console.Write("Введiть вашу суму в uah : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double u = n / usd;
                    Console.WriteLine($"Ви отримаєте {u} usd.");
                    break;

                case 2:
                    Console.WriteLine("Ви обрали купiвлю eur за uah : ");
                    Console.Write("Введiть вашу суму в uah : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    double e = n / eur;
                    Console.WriteLine($"Ви отримаєте {e} eur.");
                    break;

                case 3:
                    Console.WriteLine("Ви обрали купiвлю rub за uah : ");
                    Console.Write("Введiть вашу суму в uah : ");
                     n = Convert.ToInt32(Console.ReadLine());
                    double r = n / rub;
                    Console.WriteLine($"Ви отримаєте {r} rub.");
                    break;

                case 4:
                    Console.WriteLine("Ви обрали купiвлю uah за usd : ");
                    Console.Write("Введiть вашу суму в usd : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Uah = n * usd;
                    Console.WriteLine($"Ви отримаєте {Uah} uah.");
                    break;

                case 5:
                    Console.WriteLine("Ви обрали купiвлю uah за eur : ");
                    Console.Write("Введiть вашу суму в eur : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Uah = n * eur;
                    Console.WriteLine($"Ви отримаєте {Uah} uah.");
                    break;

                case 6:
                    Console.WriteLine("Ви обрали купiвлю uah за rub : ");
                    Console.Write("Введiть вашу суму в rub : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Uah = n * rub;
                    Console.WriteLine($"Ви отримаєте {Uah} uah.");
                    break;

                default:
                    Console.WriteLine("Оберiть операцiю вiд 1 до 6!");
                    break;
            }
            return Uah;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Оберiть потрiбну фiнансову операцiю (1-6):");
            Console.WriteLine("1.Купiвля usd за uah;");
            Console.WriteLine("2.Купiвля eur за uah;");
            Console.WriteLine("3.Купiвля rub за uah;");
            Console.WriteLine("4.Купiвля uah за usd;");
            Console.WriteLine("5.Купiвля uah за eur;");
            Console.WriteLine("6.Купiвля uah за rub.");

            Converter convert = new Converter(41, 40.6, 0.34);
            convert.Result();
        }
    }
}