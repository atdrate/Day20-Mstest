using MoodAnalyzer;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_nullmood_Expecting_Happy_Results()
        {
            //Arrange;
            AnalyzeMood mood = new AnalyzeMood(null);
            string expected = "happy";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

    }
    
}