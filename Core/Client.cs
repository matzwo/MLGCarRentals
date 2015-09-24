using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Client
    {   
        string PESEL;
        string name;
        string surname;
        bool discount;

        void setPESEL(string pesel){this.PESEL=pesel;}
        string getPESEL(){return this.PESEL;}

        void setName(string Name){this.name=Name;}
        void setSurName(string Surname){this.surname=Surname;}

        string getName(){return this.name;}
        string getSurname(){return this.surname;}

        void setDiscount(bool disc) { this.discount = disc; }
        public bool getDiscountStatus() { return this.discount; }

    }
}
