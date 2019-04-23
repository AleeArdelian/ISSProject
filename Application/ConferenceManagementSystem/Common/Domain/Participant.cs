using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public abstract class Participant
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string email;

        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getEmail() { return email; }
        public void setUsername(string username) { this.username = username;  }
        public void setPassword(string password) { this.password = password; }
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setEmail(string email) { this.email = email; }
    }
}
