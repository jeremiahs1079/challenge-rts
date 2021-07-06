using System;
using Xunit;

namespace CodingLibTests.Tests
{
    public class QuestionOneTests
    {
        [Fact(DisplayName = "All items in Array are below Threshold")]
        public void AllBelow()
        {
            int[] allBelow = { 1, 2, 3, 4, 5 };
            int threshold = 6;

            Assert.Equal(5, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Below);
            Assert.Equal(0, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Above);


        }

        [Fact(DisplayName = "All items in Array are above Threshold")]
        public void AllAbove()
        {
            int[] allBelow = { 1, 2, 3, 4, 5 };
            int threshold = 0;

            Assert.Equal(5, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Above);
            Assert.Equal(0, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Below);


        }

        [Fact(DisplayName = "One item is equal all others are Below")]
        public void OneEqualRestBelow()
        {
            int[] allBelow = { 1, 2, 3, 4, 5 };
            int threshold = 5;

            Assert.Equal(4, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Below);
            Assert.Equal(0, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Above);


        }

        [Fact(DisplayName = "One item is equal all others are Above")]
        public void OneEqualRestAbove()
        {
            int[] allBelow = { 1, 2, 3, 4, 5 };
            int threshold = 1;

            Assert.Equal(0, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Below);
            Assert.Equal(4, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Above);


        }

        [Fact(DisplayName = "Empty Array shoould have 0 above and below")]
        public void EmptyArray()
        {
            int[] allBelow = {};
            int threshold = 1;

            Assert.Equal(0, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Below);
            Assert.Equal(0, CodingChallengeLib.ChalengeSingleton.Instance.QuestionOne(allBelow, threshold).Above);


        }
    }
}
