using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] lowerCharArray = lowerAlphabet.ToCharArray();
            string upperAlphabet = lowerAlphabet.ToUpper();
            char[] upperCharArray = upperAlphabet.ToCharArray();

            for (int i = 0; i < lowerCharArray.Length; i++)
            {
                if (lowerCharArray[i] == c)
                {
                    return true;
                }
            }

            for (int i = 0; i < upperCharArray.Length; i++)
            {
                if (upperCharArray[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 != 0)
            {
                return false;
            }
            else
            {return true;
            }
        }
        
        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }
        
        
        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
            return numbers.Sum();
        }


        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            //int sum = 0;
            //foreach (int number in numbers)
            //{
                //if (number[i] % 2 == 0)
                //{
                    //sum += numbers[i];
               // }
          //  }

            return numbers.Where(x => x % 2 == 0).Sum();
         }

        public bool IsSumOdd(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            //long sum = 0;
            //foreach (int number in numbers)
            //{
             //   sum += number;
            //}

            return numbers.Sum() % 2 != 0;
        }

        
        public bool IsNumberOdd(int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }

            return false;
        }


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;
        }

    }

}