using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGGL
{
    public abstract class PersonClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }


        public PersonClass() { }

        public PersonClass(int anID, string aName, string aSurname, string anAddress, string aMobile, string anEmail)
        {
            this.id = anID;
            this.name = aName;
            this.surname = aSurname;
            this.address = anAddress;
            this.mobile = aMobile;
            this.email = anEmail;

        }

    }
}
