using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSgui.Domain
{
    public abstract class Participant
    {
        private string Username;
        private string Passwd;
        private string FirstName;
        private string LastName;
        private string Email;

        public string getUsername() { return Username; }
        public string getPassword() { return Passwd; }
        public string getFirstName() { return FirstName; }
        public string getLastName() { return LastName; }
        public string getEmail() { return Email; }
        public void setUsername(string username) { this.Username = username;  }
        public void setPassword(string password) { this.Passwd = password; }
        public void setFirstName(string firstName) { this.FirstName = firstName; }
        public void setLastName(string lastName) { this.LastName = lastName; }
        public void setEmail(string email) { this.Email = email; }
    }
}
