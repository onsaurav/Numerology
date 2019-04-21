using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Numerology
{
    public class Common
    {
        Regex r = new Regex("^[a-zA-Z0-9]*$");

        public int GetNumber(string text)
        {
            int number = 0;
            for (int i = 0; i < text.Trim().Length; i++)
            {
                if (r.IsMatch(text.Substring(i, 1)))
                {
                    int checknumber = 0;
                    int.TryParse(text.Substring(i, 1).ToLower(), out checknumber);
                    if (checknumber != 0)
                    {
                        number += checknumber;
                    }
                    else
                    {
                        if (text.Substring(i, 1).ToLower().Equals("a"))
                            number += 1;
                        else if (text.Substring(i, 1).ToLower().Equals("b"))
                            number += 2;
                        else if (text.Substring(i, 1).ToLower().Equals("c"))
                            number += 3;
                        else if (text.Substring(i, 1).ToLower().Equals("d"))
                            number += 4;
                        else if (text.Substring(i, 1).ToLower().Equals("e"))
                            number += 5;
                        else if (text.Substring(i, 1).ToLower().Equals("f"))
                            number += 6;
                        else if (text.Substring(i, 1).ToLower().Equals("g"))
                            number += 7;
                        else if (text.Substring(i, 1).ToLower().Equals("h"))
                            number += 8;
                        else if (text.Substring(i, 1).ToLower().Equals("i"))
                            number += 9;
                        else if (text.Substring(i, 1).ToLower().Equals("j"))
                            number += 10;
                        else if (text.Substring(i, 1).ToLower().Equals("k"))
                            number += 11;
                        else if (text.Substring(i, 1).ToLower().Equals("l"))
                            number += 12;
                        else if (text.Substring(i, 1).ToLower().Equals("m"))
                            number += 13;
                        else if (text.Substring(i, 1).ToLower().Equals("n"))
                            number += 14;
                        else if (text.Substring(i, 1).ToLower().Equals("o"))
                            number += 15;
                        else if (text.Substring(i, 1).ToLower().Equals("p"))
                            number += 16;
                        else if (text.Substring(i, 1).ToLower().Equals("q"))
                            number += 17;
                        else if (text.Substring(i, 1).ToLower().Equals("r"))
                            number += 18;
                        else if (text.Substring(i, 1).ToLower().Equals("s"))
                            number += 19;
                        else if (text.Substring(i, 1).ToLower().Equals("t"))
                            number += 20;
                        else if (text.Substring(i, 1).ToLower().Equals("u"))
                            number += 21;
                        else if (text.Substring(i, 1).ToLower().Equals("v"))
                            number += 22;
                        else if (text.Substring(i, 1).ToLower().Equals("w"))
                            number += 23;
                        else if (text.Substring(i, 1).ToLower().Equals("x"))
                            number += 24;
                        else if (text.Substring(i, 1).ToLower().Equals("y"))
                            number += 25;
                        else if (text.Substring(i, 1).ToLower().Equals("z"))
                            number += 26;
                    }
                }
            }
            number = FinalizeNumber(number);
            return number;
        }

        private int FinalizeNumber(int number)
        {
            int sum = 0;
            string totalNumberString = number.ToString();
            for (int i = 0; i < totalNumberString.Trim().Length; i++)
            {
                number = 0;
                int.TryParse(totalNumberString.Substring(i, 1), out number);
                sum += number;
            }
            if (sum > 9)
                sum = FinalizeNumber(sum);
            return sum;
        }
    }
}
