using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedClass.models.order
{
    public class OrderContent
    {
        public int Id { get; set; }

        public DateTime Begin { get; set; }

        public string AdditionalInfo { get; set; }
    }
}
