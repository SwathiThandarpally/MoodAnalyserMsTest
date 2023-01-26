using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void GiveMoodShouldReturnSadMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodAnalyser mood = new MoodAnalyser();
            string AcutalResult = mood.Mood(sadmood);
            string expected = "Sad";
            Assert.AreEqual(expected, AcutalResult);
        }
        [TestMethod]
        public void GiveMoodShouldReturnHappMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodAnalyser mood = new MoodAnalyser();
            string AcutalResult = mood.Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, AcutalResult);
        }
    }
}
