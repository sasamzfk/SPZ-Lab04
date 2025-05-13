using System;
using System.Text;

namespace Lab04
{
    class Lake
    {
        public string Name;
        public string Country;
        public string Region;
        public double Area;
        public double MaxDepth;
        public double Volume;
        public bool IsFreshwater;
        public bool HasIslands;

        public double CalculateAverageDepth()
        {
            if (Area == 0)
                return 0;
            return Volume / (Area * 1000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Введення даних про озеро");
            Console.WriteLine("-----------------------");

            Lake lake = new Lake();

            Console.Write("Назва озера: ");
            lake.Name = Console.ReadLine();

            Console.Write("Країна: ");
            lake.Country = Console.ReadLine();

            Console.Write("Регіон: ");
            lake.Region = Console.ReadLine();

            Console.Write("Площа озера (км²): ");
            lake.Area = double.Parse(Console.ReadLine());

            Console.Write("Максимальна глибина (м): ");
            lake.MaxDepth = double.Parse(Console.ReadLine());

            Console.Write("Об'єм води (км³): ");
            lake.Volume = double.Parse(Console.ReadLine());

            Console.Write("Чи є озеро прісноводним (т-так, н-ні): ");
            // Змінено з ConsoleKey.T на ConsoleKey.T (українська 'т')
            lake.IsFreshwater = Console.ReadKey().Key == ConsoleKey.T;
            Console.WriteLine();

            Console.Write("Чи є в озері острови (т-так, н-ні): ");
            lake.HasIslands = Console.ReadKey().Key == ConsoleKey.T;
            Console.WriteLine();

            Console.WriteLine("\nІнформація про озеро");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Назва: {lake.Name}");
            Console.WriteLine($"Країна: {lake.Country}");
            Console.WriteLine($"Регіон: {lake.Region}");
            Console.WriteLine($"Площа: {lake.Area} км²");
            Console.WriteLine($"Максимальна глибина: {lake.MaxDepth} м");
            Console.WriteLine($"Об'єм води: {lake.Volume} км³");
            // Виправлено відображення типу води
            Console.WriteLine($"Тип води: {(lake.IsFreshwater ? "прісне" : "солоне")}");
            Console.WriteLine($"Острови: {(lake.HasIslands ? "є" : "немає")}");

            double avgDepth = lake.CalculateAverageDepth();
            Console.WriteLine($"\nСередня глибина озера: {avgDepth:F2} м");

            Console.ReadKey();
        }
    }
}