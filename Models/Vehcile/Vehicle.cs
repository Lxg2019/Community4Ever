using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedClass.models.vehicle
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Licenseplate { get; set; }

        public string PhotoLink { get; set; }

        public string AddinationalInfo { get; set; }
    }
}
