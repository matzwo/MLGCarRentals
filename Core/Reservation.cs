using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Reservation
    {
        int ID;
        int Client;
        string Car;
        DateTime start;
        DateTime finish;

        void setAll(int ID, int pesel, string regnr, DateTime since, DateTime to)
        {
            this.ID = ID;
            this.Car = regnr;
            this.Client = pesel;
            this.start = since;
            this.finish = to;

        }

    }
}
