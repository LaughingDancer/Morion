using System.Text.RegularExpressions;
namespace app.Classes
{
    public class ValidationData
    {
        public class Validation
        {
            public bool ValidateLastName(string lastName)
            {
                if (string.IsNullOrWhiteSpace(lastName))
                    return false;
                return Regex.IsMatch(lastName, @"^[а-яА-Яa-zA-Z]+$");
            }
            public bool ValidateFirstName(string firstName)
            {
                if (string.IsNullOrWhiteSpace(firstName))
                    return false;
                return Regex.IsMatch(firstName, @"^[а-яА-Яa-zA-Z]+$");
            }
            public bool ValidateEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;
                return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            }
        }
    }
}
