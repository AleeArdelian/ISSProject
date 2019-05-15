using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Listener: Participant
    {
        public string CNP { get; set; }

        public Listener(string CNP)
        {
            this.CNP = CNP;
        }
    }
}
