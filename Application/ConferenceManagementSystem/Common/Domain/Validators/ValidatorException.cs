using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validator {
    public class ValidatorException : System.Exception 
    {
        private string message;

        public ValidatorException(string message) {
            this.message = message;
        }
    }
}
