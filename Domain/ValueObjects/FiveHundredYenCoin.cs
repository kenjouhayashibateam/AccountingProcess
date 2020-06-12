using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    /// <summary>
    /// 五百円玉
    /// </summary>
    public class FiveHundredYenCoin : MoneyCategory<FiveHundredYenCoin>
    {
        public FiveHundredYenCoin()
        {
            Category = 500;
        }
    }
}
