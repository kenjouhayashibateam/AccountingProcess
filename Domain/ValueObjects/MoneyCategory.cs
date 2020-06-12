using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public abstract class MoneyCategory<T> where T : MoneyCategory<T>
    {
        protected static int Category;
        public int Count { get; set; } = 0;
        private readonly string Unit="円";

        public int Amount
        {
            get
            {
                return Category*Count;
            }
         }  

        public string DisplayValue
        {
            get
            {
                return Amount.ToString("N");
            }
        }
        public string DisplayValueWithYen
        {
            get
            {
                return Amount + Unit;
            }
        }
    }
} 
