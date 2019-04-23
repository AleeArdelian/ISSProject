using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSgui.Domain {
    public class PcMember {
        private String CNP;
        private String Affiliation;
        private String Website;

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

        public void bid() {
        }
    }
}
