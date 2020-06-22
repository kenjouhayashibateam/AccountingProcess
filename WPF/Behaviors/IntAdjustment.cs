using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WPF.Behaviors
{
    public class IntAdjustment
    {
        public static int NumberConvert(string value)
        {
            Regex regex = new Regex(@"0-9");
            if (regex.IsMatch(value))
            {
                return Int32.Parse(value);
            }
            else
            {
                return 0;
            }
        }
    }
}
