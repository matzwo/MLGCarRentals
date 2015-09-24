using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class RentalPoint
    {
        string address;
        string[] Cars;
        int freeslot = 0;

        // void prepare() {for (int i=0;i<100;i++) {
        //                     Cars[i]="empty";
        // } }
        // int getFreeSlot(){for (int i=0;i<100;i++) {
        //                     if (Cars[i]=="empty") return i;
        // } }
        void insertCar(string regnr)
        {
            Cars[freeslot] = regnr;
            freeslot++;
        }
        void getCars()
        {
            for (int i = 0; i <= freeslot; i++)
            {
                System.Console.WriteLine(Cars[i] + "(" + i.ToString() + ")\n");
            }

        }
    }
}
