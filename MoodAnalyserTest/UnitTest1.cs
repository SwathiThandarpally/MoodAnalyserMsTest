using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSadMood()
        {

            //Arrange
            MoodAnalyserProblem.MoodAnalyser moodAnalyser1 = new MoodAnalyser("Iam in Sad Mood");


            //Act
            string checksadmood = moodAnalyser1.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD", checksadmood);
        }
        public void CheckHappyMood()
        {

            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Mood");

            //Act
            string checkhappymood = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", checkhappymood);
        }
    }

}
