using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsedClass.models.Stadt;

namespace UsedClass.models.order.OrderOfContent
{
    public class ProcurementService:OrderContent
    {
        public DateTime TakeTime { get; set; }
        public Adress TakeAdress { get; set; }

        public string ProcurementDetails { get; set; }
    }
}
