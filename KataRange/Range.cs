using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRange
{
    public class Range
    {
        string test;
        public Range(string test)
        {
            this.test = test;
        }

        string FirstChar(string x)
        {
            return x.Substring(1, 1);

        }
        string SecondChar(string x)
        {
            return x.Substring(5, 1);

        }
        string FirstNumber(string x)
        {
            return x.Substring(2, 1);

        }
        string SecondNumber(string x)
        {
            return x.Substring(4, 1);

        }

        string GetAllPoint(string x)
        {

        }
    }
}
