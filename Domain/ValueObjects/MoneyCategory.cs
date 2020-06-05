using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class MoneyCategory
    {
        public int Category { get; }
        public int Count { get; set; }

        public MoneyCategory(int _category,int _count)
        {
            Category = _category;
            Count = _count;
        }

        public int Amount
        {
            get
            {
                return Category*Count;
            }
         }        
    }
} 
