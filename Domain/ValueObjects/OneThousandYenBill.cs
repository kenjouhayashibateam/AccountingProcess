using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    /// <summary>
    /// 千円札
    /// </summary>
    public class OneThousandYenBill : MoneyCategory<OneThousandYenBill>
    {
        public OneThousandYenBill()
        {
            Category = 1000;
        }
    }
}
