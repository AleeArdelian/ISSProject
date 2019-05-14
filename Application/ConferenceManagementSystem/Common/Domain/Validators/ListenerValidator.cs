using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Validator {
    class ListenerValidator {

        public static void Validate(string cnp) {
            if (cnp == null || cnp.Length != 13)
                throw new ValidatorException("CNP must have 13 characters.");
            if (!Regex.IsMatch(cnp, @"\d"))
                throw new ValidatorException("Invalid characters. CNP can only contain digits.");
        }
    }
}
