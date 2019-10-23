using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedClass.models.person
{
    public class Taker:Person
    {
        public string AdditionalInfo { get; set; } //  was er/ sie braucht?

        public List<string>  PhotoList { get; set; }

        public List<Provider> ProviderList { get; set; }
    }
}
