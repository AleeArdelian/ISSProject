using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Validator {
    class ParticipantValidator {

        public static void Validate(string username, string password, string firstName,
            string lastName, string email) {
            if (username == null || username.Length < 3)
                throw new ValidatorException("Username must have at least 3 characters");

            if (password == null || password.Length < 3)
                throw new ValidatorException("Password must have at least 3 characters");

            if (firstName == null || firstName.Length < 2)
                throw new ValidatorException("First name must have at least 2 characters");

            if (lastName == null || lastName.Length < 2)
                throw new ValidatorException("Last name must have at least 2 characters");

            if (email == null || email.Length < 8)
                throw new ValidatorException("Email must have at least 8 characters");
            if (!email.Contains(".") || !email.Contains("@"))
                throw new ValidatorException("Invalid email format.");
        }
    }
}
