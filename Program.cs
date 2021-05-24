using System;
using System.Linq;
using System.Text;

namespace BinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool validated = ValidateBinaryString("110010");
            //bool validated = ValidateBinaryString("11010");
            //bool validated = ValidateBinaryString("1101100");
            // bool validated = ValidateBinaryString("1101001088");
            bool validated = ValidateBinaryString("1101001011");
        }

        private static bool ValidateBinaryString(string input)
        {
            #region < Declaration>
            int zeroCount = 0;

            int oneCount = 0;

            bool prefixesFound = false;

            int prefixZeroCount = 0;

            int prefixoneCount = 0;
            #endregion

            #region < Check for 0 and 1 are equal in the given string >
            zeroCount = input.Count(x => x == '0');

            oneCount = input.Count(x => x == '1');

            // check for 0 and 1 are equal in the given string.
            if (zeroCount != oneCount)
            {
                return false;
            }
            #endregion

            #region < Prefixes generation >

            for (int y = 0; y < input.Length - 1; y++)
            {
                // generate prefixes
                string prefix = input.Substring(0, (y + 1));

                char[] prefixArr = prefix.ToCharArray();

                prefixZeroCount = 0;

                prefixoneCount = 0;

                for (int x = 0; x < prefixArr.Length; x++)
                {
                    if (prefixArr[x] == '0') //110010
                    {
                        prefixZeroCount++;
                    }
                    else if (prefixArr[x] == '1')
                    {
                        prefixoneCount++;
                    }
                    else
                    {
                        // return false if string contains non 0 or non 1 characters.
                        return false;
                    }
                }

                //check prefix has equal 0 and 1 s.
                if (prefixZeroCount == prefixoneCount)
                {
                    prefixesFound = true;
                }
            }

            //prefixes with valid format found.
            if (prefixesFound)
            {
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }
    }
}
