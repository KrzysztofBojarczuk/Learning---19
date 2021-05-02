using System;
using System.Collections.Generic;
using System.Text;

namespace klasa_emploey_i_production
{
    class ProductionWorker
    {
        public int Zmiana { get; set; }
        public double Hours { get; set; }
        public ProductionWorker(int zmiana, double hours)
        {
            Zmiana = zmiana;
            Hours = hours;
        }
        public static void Metoda(int zmiana, double hours)
        {
            Console.WriteLine( "Zmiana tego pracwonika to: " + zmiana + " a jego stawka godzinowa to: " + hours);
        }

    }
}
