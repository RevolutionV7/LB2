using System;

namespace Employee
{
    class Employee
    {
        private readonly string name;
        private readonly string surname;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Salary()
        {
            int post;
            double experience;
            double salary;
            double tax;

            Console.WriteLine("Оберiть посаду (1-3) :");
            Console.WriteLine("1.Junior developer;");
            Console.WriteLine("2.Middle developer;");
            Console.WriteLine("3.Senior developer.");
            post = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть ваш досвiд роботи в роках (1-3):");
            Console.WriteLine("1-2 роки ");
            Console.WriteLine("3-4 роки ");
            Console.WriteLine("5+ років ");
            experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Iм'я: {name}.");
            Console.WriteLine($"Прiзвище: {surname}.");

            if (post == 1 && experience == 1)
            {
                salary = 23000;
                tax = salary * 0.2;
                Console.WriteLine("Посада Junior developer.");
                Console.WriteLine($"Досвiд {experience} рiк.");
                Console.WriteLine($"Заробiтня плата 23000 гривень.");
                Console.WriteLine($"Податковий збiр {tax} гривень.");
            }

            if (post == 1 && experience == 2)
            {
                salary = 30000;
                tax = salary * 0.2;
                Console.WriteLine("Посада Junior developer.");
                Console.WriteLine($"Досвід {experience} роки.");
                Console.WriteLine($"Заробітня плата 30000 гривень.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }

            if (post == 2 && experience == 3)
            {
                salary = 56000;
                tax = salary * 0.2;
                Console.WriteLine("Посада Middle developer.");
                Console.WriteLine($"Досвiд {experience} years.");
                Console.WriteLine($"Заробiтня плата - 56000 гривень.");
                Console.WriteLine($"Tax: {tax} hryvnias.");
            }

            if (post == 2 && experience == 4)
            {
                salary = 82000;
                tax = salary * 0.2;
                Console.WriteLine("Посада Middle developer.");
                Console.WriteLine($"Досвiд {experience} роки.");
                Console.WriteLine($"Заробiтня плата 82000 гривень.");
                Console.WriteLine($"Податок {tax} гривень.");
            }

            if (post == 3 && experience <= 5)
            {
                salary = 121000;
                tax = salary * 0.2;
                Console.WriteLine("Посада Senior developer.");
                Console.WriteLine($"Досвiд {experience} рокiв.");
                Console.WriteLine($"Заробiтня плата 121000 гривень.");
                Console.WriteLine($"Податок: {tax} гривень.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iм'я : ");
            string a = Console.ReadLine();

            Console.WriteLine("Прiзвище : ");
            string b = Console.ReadLine();

            Employee employee = new Employee(a, b);
            employee.Salary();
        }
    }
}