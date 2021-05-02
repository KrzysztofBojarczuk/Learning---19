using System;

namespace klasa_emploey_i_production
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź nazwisko i id pracwonika:");
            string name = Console.ReadLine();
            string id = Console.ReadLine();

            Employee employee = new Employee(name, id);
            ProductionWorker production = new ProductionWorker(1, 25);

            Employee.Metoda(name, id);
            ProductionWorker.Metoda(1, 25);
        }
    }
}
