using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Author:Participant
    {
        public string CNP { get; set; }
        public string Affiliation { get; set; }

        public Author(string CNP, string Affiliation)
        {
            this.CNP = CNP;
            this.Affiliation = Affiliation;
        }

        public string getCNP() { return CNP; }
        public string getAffiliation() { return Affiliation; }
        public void setCNP(string CNP) { this.CNP = CNP; }
        public void setAffiliation(string affiliation) { this.Affiliation = affiliation; }

    }
}
