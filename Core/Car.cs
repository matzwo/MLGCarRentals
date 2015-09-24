using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Car
    {
        string registrynr;
        int dailyprice;
        string location;
        int seats;
        int load;
        string model;
        string brand;

       void setAll(string reg, string brand, string model, string loc, int seat,int load, int price){
            this.registrynr=reg;
            this.dailyprice=price;
            this.seats=seat;
            this.location=loc;
            this.model = model;
            this.brand = brand;
            this.load = load;
                    
       }

       string getLocatin() { return this.location; }
       string getregistrynr() { return this.registrynr; }
       int getDailyPrice() { return this.dailyprice; }
       int getSeats() { return this.seats; }
       string getModel() { return this.model ; }
       string getBrand(){return this.brand ;}
       int getLoad() { return this.load; }
       

    }
}
