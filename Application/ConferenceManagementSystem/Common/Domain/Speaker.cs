using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Speaker : Author
    {
        public Speaker(long CNP, string affiliation, string username, string password, string firstName, string lastName, string email) : base(CNP, affiliation, username, password, firstName, lastName, email)
        {
        }
    }
}