using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGGL
{
    public class MemberClass : PersonClass
    {
        public static int currentID { get; set; }
        protected int memberID { get; set; }
        protected string status { get; set; }
        protected List<string> borrowedGames { get; set; }

        public MemberClass(int aMemberID, string aName, string aSurname, string anAddress, string aMobile, string anEmail, string aStatus, List<string> aBorrowedGames)
            : base(aMemberID, aName, aSurname, anAddress, aMobile, anEmail)
        {
            this.memberID = aMemberID;
            this.status = aStatus;
            this.borrowedGames = aBorrowedGames;
        }


    }
}
