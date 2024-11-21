using System.Text.RegularExpressions;

namespace app.Classes
{
    internal class ValidationData
    {
        public class Validation
        {
            public bool ValidateLastName(string lastName)
            {
                return Regex.IsMatch(lastName, @"^[а-яА-Яa-zA-Z]+$");
            }
            public bool ValidateFirstName(string firstName)
            {
                return Regex.IsMatch(firstName, @"^[а-яА-Яa-zA-Z]+$");
            }
            public bool ValidateEmail(string email)
            {
                return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            }
        }
    }
}
