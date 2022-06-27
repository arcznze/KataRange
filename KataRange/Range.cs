﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string GetAllPoint(string x)
        {
            Range text = new Range(x);

            int t = x.Length - 1;
            string a = x.Substring(0, 1);
            string b = x.Substring(t, 1);
            Char[] delimiters = { '[', '(', ',', ']', ')' };
            string[] divide = x.Split(delimiters);
            List<string> numbers = new List<string>();
            int d = int.Parse(divide[1]);
            int e = int.Parse(divide[2]);

            if (a == "[")
            {
                if (b == "]")
                {
                    for (int i = d; i < e + 1; i++)
                    {
                        numbers.Add(i.ToString());
                    }
                    string joined = String.Join(", ", numbers.ToArray());
                    return joined;
                }
                else if (b == ")")
                {
                    for (int i = d; i < e; i++)
                    {
                        numbers.Add(i.ToString());
                    }
                    string joined = String.Join(", ", numbers.ToArray());
                    return joined;
                }
                else
                    throw new NotImplementedException();
            }
            else if (a == "(")
            {
                if (b == "]")
                {
                    d += 1;
                    for (int i = d; i < e + 1; i++)
                    {
                        numbers.Add(i.ToString());
                    }
                    string joined = String.Join(", ", numbers.ToArray());
                    return joined;
                }
                else if (b == ")")
                {
                    d += 1;
                    for (int i = d; i < e; i++)
                    {
                        numbers.Add(i.ToString());
                    }
                    string joined = String.Join(", ", numbers.ToArray());
                    return joined;
                }
                else
                    throw new NotImplementedException();
            }
            else
                throw new NotImplementedException();
        }
        public string endPoints(string x)
        {
            Range t1 = new Range(x);
            int t = x.Length - 1;
            string a = x.Substring(0, 1);
            string b = x.Substring(t, 1);
            Char[] delimiters = { '[', '(', ',', ']', ')' };
            string[] divide = x.Split(delimiters);
            int d = int.Parse(divide[1]);
            int e = int.Parse(divide[2]);

            if (a == "[")
            {
                if (b == "]")
                    return "{" + d.ToString() + "," + e.ToString() + "}";
                else if (b == ")")
                {
                    e -= 1;
                    return "{" + d.ToString() + "," + e.ToString() + "}";
                }
                else
                    throw new NotImplementedException();
            }
            else if (a == "(")
            {
                d += 1;
                if (b == "]")
                    return "{" + d.ToString() + "," + e.ToString() + "}";
                else if (b == ")")
                {
                    e -= 1;
                    return "{" + d.ToString() + "," + e.ToString() + "}";
                }
                else
                    throw new NotImplementedException();
            }
            else
                throw new NotImplementedException();
        }
        public bool Contains(string x, string y)
        {
            var regex = new Regex(y);

            Range t1 = new Range(x);
            string t = t1.GetAllPoint(x);
            bool c = regex.IsMatch(t);
            return c;
        }
        public bool ContainsRange(string x, string y)
        {
            Range t1 = new Range(x);
            Range t2 = new Range(y);

            var regex = new Regex(t2.GetAllPoint(y));

            string t = t1.GetAllPoint(x);
            bool c = regex.IsMatch(t);
            return c;
        }
    }
}
