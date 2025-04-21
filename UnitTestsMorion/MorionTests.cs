using Microsoft.VisualStudio.TestTools.UnitTesting;
using app.Classes;

namespace UnitTestsMorion
{
    [TestClass]
    public class ValidationDataTests
    {
        private readonly ValidationData.Validation _validator = new ValidationData.Validation();

        [DataTestMethod]
        [DataRow("Иванов", true)]
        [DataRow("Petrov", true)]
        [DataRow("Smith", true)]
        [DataRow("Смирнов", true)]
        [DataRow("Иванов123", false)]
        [DataRow("Petrov!", false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow(null, false)]
        public void ValidateLastName_Tests(string input, bool expected)
        {
            Assert.AreEqual(expected, _validator.ValidateLastName(input));
        }

        [DataTestMethod]
        [DataRow("Алексей", true)]
        [DataRow("John", true)]
        [DataRow("Мария", true)]
        [DataRow("Anna", true)]
        [DataRow("Name123", false)]
        [DataRow("First Name", false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow(null, false)]
        public void ValidateFirstName_Tests(string input, bool expected)
        {
            Assert.AreEqual(expected, _validator.ValidateFirstName(input));
        }

        [DataTestMethod]
        [DataRow("test@example.com", true)]
        [DataRow("user.name@domain.co.uk", true)]
        [DataRow("firstname.lastname@example.com", true)]
        [DataRow("plainstring", false)]
        [DataRow("@no-user.com", false)]
        [DataRow("no-at.com", false)]
        [DataRow("user@.com", false)]
        [DataRow("", false)]
        [DataRow(null, false)]
        public void ValidateEmail_Tests(string input, bool expected)
        {
            Assert.AreEqual(expected, _validator.ValidateEmail(input));
        }
    }
}