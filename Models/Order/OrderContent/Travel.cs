using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsedClass.models.Stadt;

namespace UsedClass.models.order.OrderOfContent
{
    public class Travel
    {
        public DateTime End { get; set; }

        public virtual OrderPlace Orderplace{ get; set; }

        public string OrderDetails { get; set; }
    }
}
