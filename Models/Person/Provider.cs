using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedClass.models.person
{
    public class Provider:Person
    {
        public string AdditionalInfo { get; set; } // was kann er/sie anbieten
        public List<string> PhotoList { get; set; }

        public List<Taker> TakerList { get; set; }



    }
}
