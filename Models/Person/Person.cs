using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsedClass.models.role;

namespace UsedClass.models.person
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public ContactType ContactType { get; set; }

        public string ContactTypeString { get; set; }

        public string Telefon { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
