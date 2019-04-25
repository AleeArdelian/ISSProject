using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Conference
    {
        public string ConferenceID { get; set; }
        public string ConferenceName { get; set; }

        public Conference(string ConferenceID, string ConferenceName)
        {
            this.ConferenceID = ConferenceID;
            this.ConferenceName = ConferenceName;
        }
    }
}
