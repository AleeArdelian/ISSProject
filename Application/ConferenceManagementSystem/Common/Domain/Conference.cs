using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Conference
    {
        public int ConferenceID { get; set; }
        public string ConferenceName { get; set; }
        
        public Conference(int ConferenceID, string ConferenceName)
        {
            this.ConferenceID = ConferenceID;
            this.ConferenceName = ConferenceName;
        }
    }
}
