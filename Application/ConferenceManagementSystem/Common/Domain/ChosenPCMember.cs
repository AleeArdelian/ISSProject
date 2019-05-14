using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class ChosenPCMember
    {
        public String CNP { get; set; }
        public String PCRole { get; set; }

        public ChosenPCMember(String CNP, String PCRole)
        {
            this.CNP = CNP;
            this.PCRole = PCRole;
        }

        public String getCNP() { return CNP; }
        public String getPCRole() { return PCRole; }
    }
}
