
namespace ChallengeApp.Tests
{ 
    public class TypeTests
    {
        [Test]
        public void WhenNumbersAreTheSame()
        {
            // arrange
            int number1 = 44;
            int number2 = 44;
         
            // Assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenFloatNumbersAreDifferent()
        {
            // arrange
            float number3 = 4.44F;
            float number4 = 44.4F;

            // Assert
            Assert.AreNotEqual(number3, number4);
        }


        [Test]
        public void WhenEmployeeAreTheSame()
        {
            // arrange
            var employee1 = GetEmployee("Darek", "Kowalski", 39);
            var employee2 = GetEmployee("Darek", "Kowalski", 39);
           
            // Assert
           Assert.AreNotEqual(employee1, employee2);

        }

        [Test]
        public void WhenEmployeeNameAreTheSame()
        {
            // arrange
            var employee1 = GetEmployee("Darek", "Kowalski", 39);
            var employee2 = GetEmployee("Darek", "Nowak", 44);

            // Assert
            Assert.AreEqual(employee1.Name, employee2.Name);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
