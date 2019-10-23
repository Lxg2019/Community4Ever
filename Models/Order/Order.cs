using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsedClass.models.person;
using UsedClass.models.Stadt;

namespace UsedClass.models.order
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderId { get; set; }

        public Adress OrderAdress { get; set; }

        public Provider OrderProvider { get; set; }

        public Taker OrderTaker { get; set; }

        public OrderContent OrderContent { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
