using System;

namespace User
{
    class User
    {
        public string Login;
        public string Name;
        public string Surname;
        public int Age;
        public string Date;

        public void Information()
        {
            Console.WriteLine("Введiть ваш логiн:");
            Login = Console.ReadLine();

            Console.WriteLine("Введiть ваше iм'я:");
            Name = Console.ReadLine();

            Console.WriteLine("Введiть ваше прiзвище:");
            Surname = Console.ReadLine();

            Console.WriteLine("Введiть ваш вiк:");
            Age = Convert.ToInt32(Console.ReadLine());

            Date = DateTime.Now.ToString();

            Console.WriteLine();
            Console.WriteLine($"Ваш логiн: {Login};");
            Console.WriteLine($"Ваше iм'я: {Name} {Surname};");
            Console.WriteLine($"Ваше прiзвище: {Age};");
            Console.WriteLine($"Дата вiдповiдi на запитання: {Date}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Information();
        }
    }
}