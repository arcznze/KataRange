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
            Range text = new Range(x);
            if (FirstChar(x) == "[")
            {
                if (SecondChar(x) == "]")
                {
                    int t = int.Parse(FirstNumber(x)) + 1;
                    int y = int.Parse(SecondNumber(x));
                    for (int i = 0; i < y; i++)
                    {
                        t += i;
                        return t.ToString();
                    }
                }
                else if (SecondChar(x) == ")")
                {
                    int t = int.Parse(FirstNumber(x)) + 1;
                    int y = int.Parse(SecondNumber(x) + 1);
                    for (int i = 0; i < y; i++)
                    {
                        t += i;
                        return t.ToString();
                    }
                }
                return "";
            }
            else if (FirstChar(x) == "(")
            {
                if (SecondChar(x) == "]")
                {
                    int t = int.Parse(FirstNumber(x));
                    int y = int.Parse(SecondNumber(x));
                    for (int i = 0; i < y; i++)
                    {
                        t += i;
                        return t.ToString();
                    }
                }
                else if (SecondChar(x) == ")")
                {
                    int t = int.Parse(FirstNumber(x));
                    int y = int.Parse(SecondNumber(x) + 1);
                    for (int i = 0; i < y; i++)
                    {
                        t += i;
                        return t.ToString();
                    }
                }
                return "";
            }
            else
                throw new Exception();
        }
    }
}
