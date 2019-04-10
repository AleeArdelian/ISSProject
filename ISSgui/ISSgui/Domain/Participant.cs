using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSgui.Domain
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
        private string getEmail() { return email; }
    }
}
