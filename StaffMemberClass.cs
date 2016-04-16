using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGGL
{
    public abstract class StaffMemberClass : PersonClass
    {
        protected int staffID { get; set; }

        protected int permission { get; set; }

        protected string login { get; set; }
        protected string password { get; set; }



        public StaffMemberClass
            (int aMemberID, string aName, string aSurname, string anAddress, string anEmail, string aMobile, int aStaffID, int aPermission, string aLogin, string aPassword)
            : base(aMemberID, aName, aSurname, anAddress, aMobile, anEmail)
        {
            this.staffID = aStaffID;
            this.permission = aPermission;
            this.login = aLogin;
            this.password = aPassword;
        }

        //public void UpdateMember(string theName, string theSurname, string theAddress, string theEmail, string theMobile)
        //{

        //}
    }
}
