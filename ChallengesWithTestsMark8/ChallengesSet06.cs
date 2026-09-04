using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = word.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    return isPrime = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                return isPrime = true;
            }
            return isPrime = false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;
            
            for(int i = 0; i <str.Length; i++)
            {
                uindex = str[i] == str[i] ? true : false;
            }
            return index;

        }

        public int MaxConsecutiveCount(int num)
        {
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < num; j++)
                {
                    if (i != j)
                    {
                        currentCount += 1;
                    }
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new double[n];
            if(elements == null || elements.Count < n)
            {
                return nthElement;
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement[i] = elements[i];
            }
            return nthElement;
        }   
        
    }
}
