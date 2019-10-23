using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsedClass.models.Stadt;
using UsedClass.models.vehicle;

namespace UsedClass.models.order.OrderOfContent
{
    public class Airport:OrderContent
    {

        public Adress FromAdress { get; set; }

        public Adress ToAdress { get; set; }

        public virtual Vehicle Vehcile { get; set; }

        public int AmountofPackage { get; set; }


    }
}
