using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedClass.models.Stadt
{
    public class Adress
    {
        public int Id { get; set; }

        public string AdressName { get; set; }

        public string AdressNumber { get; set; }

        public string Plz { get; set; }

        public virtual City City { get; set; }

        public int CityId { get; set; }

    }
}
