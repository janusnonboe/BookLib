using BookLib;
using System.Security.Cryptography.X509Certificates;
namespace BookLibUnitTest
{
    [TestClass()]
    public class BookTests
    {
        private Teacher teacher = new Teacher { Id = 1, Name = "", Salary = -12 };
        [TestMethod]
        public void TestMethodName()
        {
            teacher.validateName();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.validateName);

        }
        [TestMethod()]
        public void TestMethodSalery()
        {
            teacher.validateSalery();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {  teacher.validateSalery(); });
            
        }
    }
}