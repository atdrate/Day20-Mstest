using MoodAnalyzer;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMsgReturnHappy()
        {
            //Arrange
            string msg = "i am in happy mood";
            string expected = "happy";
            //act
            AnalyzeMood analyzeMood = new AnalyzeMood(msg);
            var actual = analyzeMood.Mood();
            //assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void GivenMsgReturnSad()
        {
            //Arrange
            string msg = "i am in sad mood";
            string expected = "sad";
            //act
            AnalyzeMood analyzeMood = new AnalyzeMood(msg);
            var actual = analyzeMood.Mood();
            //assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
    }
    
}