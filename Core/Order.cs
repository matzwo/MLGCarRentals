using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Order
    {
        int ID;
        int Client;
        string Car;
        int days;
        int cost;

        void setAll(int ID, int pesel, string regnr, int day, int dailycost)
        {
            this.ID = ID;
            this.Car = regnr;
            this.Client = pesel;
            this.days = days;
            this.cost = dailycost * days;

        }



    }
}
