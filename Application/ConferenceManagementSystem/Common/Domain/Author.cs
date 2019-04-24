using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Author:Participant
    {
        private string CNP;
        private string Affiliaton;

        public Author(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email)
        {
            this.CNP = CNP;
            this.Affiliaton = affiliation;
            this.setEmail(email);
            this.setFirstName(firstName);
            this.setLastName(lastName);
            this.setPassword(password);
            this.setUsername(username);
        }

        public string getCNP() { return CNP; }
        public string getAffiliation() { return Affiliaton; }
        public void setCNP(string CNP) { this.CNP = CNP; }
        public void setAffiliation(string affiliation) { this.Affiliaton = affiliation; }

    }
}
