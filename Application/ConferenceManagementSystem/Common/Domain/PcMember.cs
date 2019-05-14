using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain {
    public class PcMember: Participant {
        public String CNP { get; set; }
        public String Affiliation { get; set; }
        public String Website { get; set; }

        /*public PcMember(String CNP, String Affiliation, String Website)
        {
            this.CNP = CNP;
            this.Affiliation = Affiliation;
            this.Website = Website;
        }*/

            
        public String getCnp() {
            return CNP;
        }

        public String getAffiliation() {
            return Affiliation;
        }

        public String getWebsite() {
            return Website;
        }

        public void setAffiliation(String affiliation) {
            this.Affiliation = affiliation;
        }

        public void setWebsite(String website) {
            this.Website = website;
        }

        public void setCNP(String CNP)
        {
            this.CNP = CNP;
        }

        public void bid() {
        }
        
    }
}
