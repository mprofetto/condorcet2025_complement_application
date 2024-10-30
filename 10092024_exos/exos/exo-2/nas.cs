using System;
using System.Linq;

namespace Identity
{
    public class NAS
    {
        private string value;

        public NAS(string input)
        {
            value = input;
        }

        public bool isValid()
        {
            return sizeIsValid() && isNumeric() && algoIsValid();
        }

        private bool sizeIsValid()
        {
            return value.Length == 9;
        }

        private bool isNumeric()
        {
            return value.All(char.IsDigit);
        }

        private bool algoIsValid()
        {
            int sum = 0;
            int cypher;
            int index = 1;

            foreach (char c in value)
            {
                cypher = (int)char.GetNumericValue(c);
                if (index % 2 == 0)    
                    cypher *= 2;
                if (cypher != 0 && cypher >= 10)
                    cypher = (cypher % 10) + (cypher / 10);
                sum += cypher;
                ++index;
            }
            return sum % 10 == 0;
        }
    }
}