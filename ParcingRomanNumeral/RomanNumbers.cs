using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcingRomanNumeral
{
    class RomanNumbers
    {

        private static Dictionary<char, int> romanNumberToNormalNumber = new Dictionary<char, int>()
        {

            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C',  100},
            {'D', 500},
            {'M', 1000}

        };

        public static int ParseRomanNumberToNormalNumber(string romanNumber) 
        {

            int result = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i + 1 < romanNumber.Length && IfAdd(romanNumber[i], romanNumber[i + 1]))
                {
                    result -= romanNumberToNormalNumber[romanNumber[i]];
                }
                else 
                {
                    result += romanNumberToNormalNumber[romanNumber[i]];
                }
            }

            return result;
        }

        public static bool IfCorrectRomanNumber(string romanNumber) 
        {
            int counterIfTrue = 0;

            foreach (KeyValuePair<char,int> keyPair in romanNumberToNormalNumber) 
            {
                for (int i = 0; i < romanNumber.Length; i++)
                {
                    if (keyPair.Key == romanNumber[i])
                    {
                        counterIfTrue += 1;
                    }
                }
            }

            if (romanNumber.Length == counterIfTrue) 
            {
                return true;
            }

            return false;
        }

        private static bool IfAdd(char v1, char v2)
        {
            return romanNumberToNormalNumber[v1] < romanNumberToNormalNumber[v2];
        }


    }
}
