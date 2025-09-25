using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (CharacterIsALetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
                
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CharacterIsNotALetter(char c)
        {
            if (!Char.IsLetter(c));
            {
                Console.WriteLine($"The character '{c}' is not a letter.");
            }
            
        }


        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0);
            {
                return true;
            }
            
        }

        

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0.0;
            }

            double minValue = double.MaxValue;
            double maxValue = double.MinValue;

            return minValue + maxValue;
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length + str2.Length) / 2;
        }


        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
                
            int sum = 0;
            foreach (int number in numbers)
            {   
                if (number % 2 == 0)
                {
                    return sum += number;
                }
            }
            return sum;
        }

        public bool IsNumberOdd(int numbers)
        {
            if (numbers % 2 != 0)
                {
                    return true;
                }
            return false;
        }   
        
        public long CountOfPositiveOddsBelowNumber(long number)
        {
                if (number <= 1)
                {
                    return 0;
                }
                else
                {
                    return (number - 1 / 2);
                }
        }

        public bool IsSumOdd(List<int> number)
        {
            throw new NotImplementedException();
        }
        
    }
}