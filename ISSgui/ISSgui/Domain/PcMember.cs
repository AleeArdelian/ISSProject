using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSgui.Domain {
    class PcMember {
        private String cnp;
        private String affiliation;
        private String website;

        public String getCnp() {
            return cnp;
        }

        public String getAffiliation() {
            return affiliation;
        }

        public String getWebsite() {
            return website;
        }

        public void setAffiliation(String affiliation) {
            this.affiliation = affiliation;
        }

        public void setWebsite(String website) {
            this.website = website;
        }

        public void bid() {
        }
    }
}
