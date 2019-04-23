using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Author:Participant
    {
        private long CNP;
        private string affiliaton;

        public Author(long CNP, string affiliation, string username, string password, string firstName, string lastName, string email)
        {
            this.CNP = CNP;
            this.affiliaton = affiliation;
            this.setEmail(email);
            this.setFirstName(firstName);
            this.setLastName(lastName);
            this.setPassword(password);
            this.setUsername(username);
        }

        public long getCNP() { return CNP; }
        public string getAffiliation() { return affiliaton; }
        public void setCNP(long CNP) { this.CNP = CNP; }
        public void setAffiliation(string affiliation) { this.affiliaton = affiliation; }

    }
}
