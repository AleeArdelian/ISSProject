﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSgui.Domain
{
    public class Author:Participant
    {
        private string CNP;
        private string affiliaton;

        public Author(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email)
        {
            this.CNP = CNP;
            this.affiliaton = affiliation;
            this.setEmail(email);
            this.setFirstName(firstName);
            this.setLastName(lastName);
            this.setPassword(password);
            this.setUsername(username);
        }

        public string getCNP() { return CNP; }
        public string getAffiliation() { return affiliaton; }
        public void setCNP(string CNP) { this.CNP = CNP; }
        public void setAffiliation(string affiliation) { this.affiliaton = affiliation; }

    }
}
