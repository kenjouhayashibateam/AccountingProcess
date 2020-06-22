﻿using Domain.Entities;
using Domain.ValueObjects;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace WPF.ViewModels
{
    public class RemainingMoneyCalculationViewModel : BaseViewModel
    {
        public OneYenCoin OneYen
        {
            get
            {
                return oneYen;
            }
            set
            {
                oneYen = value;
                CallPropertyChanged();
            }
        }
        public FiveYenCoin FiveYen
        {
            get
            {
                return fiveYen;
            }
            set
            {
                fiveYen = value;
                CallPropertyChanged();
            }
        }
        public TenYenCoin TenYen
        {
            get
            {
                return tenYen;
            }
            set
            {
                tenYen = value;
                CallPropertyChanged();
            }
        }
        public FiftyYenCoin FiftyYen
        {
            get
            {
                return fiftyYen;
            }
            set
            {
                fiftyYen = value;
                CallPropertyChanged();
            }
        }
        public OneHundredYenCoin OneHundredYen
        {
            get
            {
                return oneHundredYen;
            }
            set
            {
                oneHundredYen = value;
                CallPropertyChanged();
            }
        }
        public FiveHundredYenCoin FiveHundredYen
        {
            get
            {
                return fiveHundredYen;
            }
            set
            {
                fiveHundredYen = value;
                CallPropertyChanged();
            }
        }
        public OneThousandYenBill OneThousandYen
        {
            get
            {
                return oneThousandYen;
            }
            set
            {
                oneThousandYen = value;
                CallPropertyChanged();
            }
        }
        public FiveThousandYenBill FiveThousandYen
        {
            get
            {
                return fiveThousandYen;
            }
            set
            {
                fiveThousandYen = value;
                CallPropertyChanged();
            }
        }
        public TenThousandYenBill TenThousandYen
        {
            get
            {
                return tenThousandYen;
            }
            set
            {
                tenThousandYen = value;
                CallPropertyChanged();
            }
        }

        public CashBoxGrandTotal TotalAmount
        {
            get
            {
                return TotalAmount;
            }
        }
        
        private OneYenCoin oneYen;
        private FiveYenCoin fiveYen;
        private TenYenCoin tenYen;
        private FiftyYenCoin fiftyYen;
        private OneHundredYenCoin oneHundredYen;
        private FiveHundredYenCoin fiveHundredYen;
        private OneThousandYenBill oneThousandYen;
        private FiveThousandYenBill fiveThousandYen;
        private TenThousandYenBill tenThousandYen;
    }
}
