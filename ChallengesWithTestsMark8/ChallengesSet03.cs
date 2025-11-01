using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.JavaScript;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            {
                if (!value)
                {
                    return true;
                }
            }
            if(vals == null);
                
                return false;
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }    
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum % 2 != 0;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c))  hasLower = true;
                else if (char.IsDigit(c))  hasNumber = true; 
                
                if (hasUpper && hasLower && hasNumber)
                {
                    return true;
                }    
            }
            return false;
        }


        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            { 
                if (val == null);
            }   
            return val [0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                if ( val == null );
            }   
            return val[val.Length -1];
        }


        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
            
        }
        
        public int LastMinusFirst(int[] nums)
        {
            if (nums == null)
            {
                nums = new int[0];
            }    
            return nums[nums.Length - 1] -  nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }   
            }  
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                
            }   
        }
    }
}
