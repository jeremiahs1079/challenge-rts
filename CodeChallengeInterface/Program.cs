using System;
using CodeChallengeLib.Models;
using CodingChallengeLib;

namespace CodeChallengeInterface
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] testArray = { 1, 5, 2, 1, 10 };
            int testNumber = 6;

            string testString = "MyString";
            int testRotate = 2;

            QuestionOne(ref testArray, testNumber);

            QuestionTwo(testString, testRotate);
        }

        public static void QuestionOne(ref int[] arrayOfNumbers, int testNumber)
        {
            QuestionOneDTO q1 = ChalengeSingleton.Instance.QuestionOne(arrayOfNumbers, testNumber);

            Console.WriteLine($"above: {q1.Above}, below: {q1.Below}");
        }

        public static void QuestionTwo(string inputString, int rotate)
        {

            Console.WriteLine($"{ChalengeSingleton.Instance.QuestionTwo(inputString, rotate)}");
        }
    }
}
