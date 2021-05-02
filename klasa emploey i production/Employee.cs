using System;
using System.Collections.Generic;
using System.Text;

namespace klasa_emploey_i_production
{
    class Employee
    {
        public string LastName { get; set; }
        public string IdNumer { get; set; }
        public Employee(string lastname, string idnumer)
        {
            LastName = lastname;
            IdNumer = idnumer;
        }
        public static void Metoda(string lastname, string idnumer)
        {
            Console.WriteLine("Nazwisko pracownika to: " + lastname + " a jego id to: " + idnumer);
        }
    }
}
