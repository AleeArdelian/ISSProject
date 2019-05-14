using System.Text.RegularExpressions;

namespace Common.Validator
{
    class AuthorValidator {

        public static void Validate(string cnp, string affiliation, string username, 
            string password, string firstName, string lastName, string email) {
            if (cnp == null || cnp.Length != 13)
                throw new ValidatorException("CNP must have 13 characters.");
            if (!Regex.IsMatch(cnp, @"\d"))
                throw new ValidatorException("Invalid characters. CNP can only contain digits.");

            if (affiliation == null)
                throw new ValidatorException("Affiliation can not be null");

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
