using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class OneYenCoin
    {
        public int Count { get; }

        public OneYenCoin(int _count)
        {
            Count = _count;
        }

        public int Amount()
        {
            return 0;
        }
    }
} 
