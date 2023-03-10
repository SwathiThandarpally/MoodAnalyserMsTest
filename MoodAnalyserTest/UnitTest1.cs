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
        [TestMethod]
        public void CheckNullMood()
        {

            //Arrange

            NullMoodException nullMoodException = new NullMoodException(null);

            //Act
            string checknullmood = nullMoodException.ToString();


            //Assert
            Assert.AreNotEqual(null, checknullmood);
        }
        [TestMethod]

        public void CheckInvalidMood()
        {

            //Arrange

            InvalidCustomException invalidMoodException = new InvalidCustomException(string.Empty);

            //Act
            string checkinvalidmood = invalidMoodException.ToString();


            //Assert
            Assert.AreNotEqual(null, checkinvalidmood);

        }
        [TestMethod]

        public void CheckMoodREflection()
        {
            //Arrange
            MoodReflection moodReflection = new MoodReflection();

            //Act
            string checkmoodreflection = moodReflection.ToString();

            //Assert
            Assert.AreNotEqual(moodReflection, checkmoodreflection);
        }
        [TestMethod]

        public void MoodAnalyserReflection()
        {
            //Arrange
            MoodAnalyseRefactory moodAnalyseReflector = new MoodAnalyseRefactory("Happy Mood");

            //Act
            string checkmoodreflection = moodAnalyseReflector.ToString();

            //Assert
            Assert.AreNotEqual(moodAnalyseReflector, checkmoodreflection);
        }
        [TestMethod]

        public void MoodChangeReflector()
        {
            //Arrange
            MoodChangeRefactory moodChangeReflector = new MoodChangeRefactory();

            //Act
            string checkchangereflector = moodChangeReflector.ToString();

            //Assert
            Assert.AreNotEqual(checkchangereflector, moodChangeReflector);
        }
    }

}
