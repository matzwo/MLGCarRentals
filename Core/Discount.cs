using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Discount
    {
        int discountpercent;
        int priorityLevel[];

        void setDiscount(int perc,int prior){
            this.discountpercent=perc;
            this.priorityLevel=prior;
        }
        int getPercent(){return this.discountpercent;}
        int getPriority(){return this.priorityLevel;}
    }
}
