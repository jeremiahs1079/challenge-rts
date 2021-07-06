using System;
using Xunit;

namespace CodingLibTests.Tests
{
    public class QuestionTwoTests
    {

        [Fact(DisplayName = "'MyString' rotate 2")]
        public void TestMyString2()
        {
            string testString = "MyString";
            string expectedString = "ngMyStri";
            int testRotate = 2;

            string rotatedString = CodingChallengeLib.ChalengeSingleton.Instance.QuestionTwo(testString, testRotate);

            Assert.True(expectedString.Equals(rotatedString));

        }

        [Fact(DisplayName = "'MyString' rotate 0")]
        public void TestMyString0()
        {
            string testString = "MyString";
            string expectedString = "MyString";
            int testRotate = 0;

            string rotatedString = CodingChallengeLib.ChalengeSingleton.Instance.QuestionTwo(testString, testRotate);

            Assert.True(expectedString.Equals(rotatedString));

        }

    }
}
