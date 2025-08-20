using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (CountOfElementsIsEven(vals))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public struct void CharacterIsNotALetter()
        {
            return !Char.IsLetter();
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }
        
        public bool IsNumberOdd(int num)
        {
           return (num % 1 ! == 0);
           
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
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }    
            return total;
        }

        public int SumEvens(int[] numbers)
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
        

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = numbers.Sum();
            return sum % 2 != 0;
        }        

            public long CountOfPositiveOddsBelowNumber(long number)
            {
                if (number <= 1)
                {
                    return 0;
                }
                else
                {
                    return (number - 1) / 2;
                }
                
            } 
            
        }
    }
