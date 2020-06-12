using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    /// <summary>
    /// 百円玉
    /// </summary>
    public class OneHundredCoin : MoneyCategory<OneHundredCoin>
    {
       public OneHundredCoin()
        {
            Category = 100;
        }
    }
}
