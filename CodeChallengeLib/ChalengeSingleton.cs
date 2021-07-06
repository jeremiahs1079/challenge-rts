using System;
using CodeChallengeLib.Models;

namespace CodingChallengeLib
{
    public class ChalengeSingleton
    {
        private static ChalengeSingleton instance = null;
        private static readonly object padlock = new object();

        ChalengeSingleton()
        {
        }

        public static ChalengeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ChalengeSingleton();
                    }

                    return instance;
                }
            }
        }

        public QuestionOneDTO QuestionOne(int[] arrayOfIntegers, int testNumber)
        {
            int above = 0;
            int below = 0;

            foreach (int num in arrayOfIntegers)
            {
                if (num > testNumber)
                {
                    above++;
                }
                else if (num < testNumber)
                {
                    below++;
                }
            }

            return new QuestionOneDTO
            {
                Above = above,
                Below = below
            };
        }

        public string QuestionTwo(string stringToRotate, int rotateAmount)
        {
            int stringLen = stringToRotate.Length - rotateAmount;
            return stringToRotate.Substring(stringLen, rotateAmount) + stringToRotate.Substring(0, stringLen);
        }


    }
}
