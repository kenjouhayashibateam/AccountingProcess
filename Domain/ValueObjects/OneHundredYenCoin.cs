﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    /// <summary>
    /// 百円玉
    /// </summary>
    public class OneHundredYenCoin : MoneyCategory<OneHundredYenCoin>
    {
       public OneHundredYenCoin()
        {
            Category = 100;
        }
    }
}