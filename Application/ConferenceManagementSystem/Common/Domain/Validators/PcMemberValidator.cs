using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Validator {
    class PcMemberValidator {

        public static void Validate(string cnp, string affiliation, string website) {
            if (cnp == null || cnp.Length != 13)
                throw new ValidatorException("CNP must have 13 characters.");
            if (!Regex.IsMatch(cnp, @"\d"))
                throw new ValidatorException("Invalid characters. CNP can only contain digits.");

            if (affiliation == null)
                throw new ValidatorException("Affiliation can not be null");

            if (website == null || website.Length < 5)
                throw new ValidatorException("Website must have at least 5 characters");
            if (!website.Contains("."))
                throw new ValidatorException("Invalid website format.");
        }
    }
}
