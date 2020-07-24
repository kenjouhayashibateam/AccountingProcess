using Domain.Entities;
using Domain.ValueObjects;

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
                OneYenTotal=oneYen.DisplayValueWithUnit
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
        public OneYenBundle OneYenBundle
        {
            get
            {
                return oneYenBundle;
            }
            set
            {
                oneYenBundle = value;
                CallPropertyChanged();
            }
        }
        public FiveYenBundle FiveYenBundle
        {
            get
            {
                return fiveYenBundle;
            }
            set
            {
                fiveYenBundle = value;
                CallPropertyChanged();
            }
        }
        public TenYenBundle TenYenBundle
        {
            get
            {
                return tenYenBundle;
            }
            set
            {
                tenYenBundle = value;
                CallPropertyChanged();
            }
        }
        public FiftyYenBundle FiftyYenBundle
        {
            get
            {
                return fiftyYenBundle;
            }
            set
            {
                fiftyYenBundle = value;
                CallPropertyChanged();
            }
        }
        public OneHundredYenBundle OneHundredYenBundle
        {
            get
            {
                return oneHundredYenBundle;
            }
            set
            {
                oneHundredYenBundle = value;
                CallPropertyChanged();
            }
        }

        public FiveHundredYenBundle FiveHundredYenBundle
        {
            get
            {
                return fiveHundredYenBundle;
            }
            set
            {
                fiveHundredYenBundle = value;
                CallPropertyChanged();
            }
        }

        public CashBoxGrandTotal TotalAmount 
        {
            get
            {
                return totalAmount;
            }
            set
            {
                totalAmount = value;
                CallPropertyChanged();
            }
        }

        public string OneYenTotal
        {
            get
            {
                return oneYenTotal;
            }
            set
            {
                oneYenTotal = value;
                CallPropertyChanged();
            }
        }

        private string oneYenTotal;
        private FiveHundredYenBundle fiveHundredYenBundle;
        private OneHundredYenBundle oneHundredYenBundle;
        private FiftyYenBundle fiftyYenBundle;
        private TenYenBundle tenYenBundle;
        private FiveYenBundle fiveYenBundle;
        private OneYenBundle oneYenBundle;
        private OneYenCoin oneYen;
        private FiveYenCoin fiveYen;
        private TenYenCoin tenYen;
        private FiftyYenCoin fiftyYen;
        private OneHundredYenCoin oneHundredYen;
        private FiveHundredYenCoin fiveHundredYen;
        private OneThousandYenBill oneThousandYen;
        private FiveThousandYenBill fiveThousandYen;
        private TenThousandYenBill tenThousandYen;
        private CashBoxGrandTotal totalAmount;

        private void TotalCalculation()
        {
            TotalAmount = new CashBoxGrandTotal(OneYen, FiveYen, TenYen, FiftyYen, OneHundredYen, FiveHundredYen, OneThousandYen,
                FiveThousandYen, TenThousandYen, OneYenBundle, FiveYenBundle, TenYenBundle, FiftyYenBundle, OneHundredYenBundle,
                FiveHundredYenBundle);
        }
    }
}
