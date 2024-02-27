namespace ChallengeApp.Tests
{
    public class Tests
    {
      
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Darek", "Ma³kowski", 49);
            employee.AddScore(5);
            employee.AddScore(6);
           
            //act
            var result = employee.Result;

            // Assert
            Assert.AreEqual(11, result);                

        }
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Darek", "Ma³kowski", 49);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(9);

            //act
            var result = employee.Result;

            // Assert
            Assert.AreEqual(20, result);
        }
        [Test]
        public void WhenUserCollectNegativeScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Darek", "Ma³kowski", 49);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(9);
            employee.AddScore(-10);

            //act
            var result = employee.Result;

            // Assert
            Assert.AreEqual(10, result);

        }
    }
}