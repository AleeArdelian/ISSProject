using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain {

    public class RegularMember: PcMember
    {
        public String isReviewer { get; set; }

        public RegularMember(String CNP, String Affiliation, String Website)
        {
            this.setCNP(CNP);
            this.setAffiliation(Affiliation);
            this.setWebsite(Website);
        }
    }
}
