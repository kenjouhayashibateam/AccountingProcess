using Domain.ValueObjects;

namespace Domain.Entities
{
    /// <summary>
    /// 金庫の金額のトータルクラス
    /// </summary>
    public class CashBoxGrandTotal
    {
        /// <summary>
        /// トータル金額
        /// </summary>
        protected static int Total;
        /// <summary>
        /// トータル金額&スペース&単位
        /// </summary>
        public string TotalAmountWithUnitSpace
        {
            get
            {
                return TotalAmount + " " + Properties.Resources.Unit;
            }
        }
        /// <summary>
        /// トータル金額&単位
        /// </summary>
        public string TotalAmountWithUnit
        {
            get
            {
                return TotalAmount + Properties.Resources.Unit;
            }
        }
        /// <param name="oneYen">1円</param>
        /// <param name="fiveYen">5円</param>
        /// <param name="tenYen">10円</param>
        /// <param name="fiftyYen">50円</param>
        /// <param name="oneHundredYen">100円</param>
        /// <param name="fiveHundredYen">500円</param>
        /// <param name="oneThousandYen">1,000円</param>
        /// <param name="fiveThousandYen">5,000円</param>
        /// <param name="tenThousandYen">10,000円</param>
        /// <param name="oneHundredYenBundle">1円束</param>
        /// <param name="fiveHundredYenBundle">5円束</param>
        /// <param name="tenYenBundle">10円束</param>
        /// <param name="fiftyYenBundle">50円束</param>
        /// <param name="oneHundredYenBundle">100円束</param>
        /// <param name="fiveHundredYenBundle">500円束</param>
        public CashBoxGrandTotal(OneYenCoin oneYen,FiveYenCoin fiveYen,TenYenCoin tenYen,FiftyYenCoin fiftyYen, 
            OneHundredYenCoin oneHundredYen,FiveHundredYenCoin fiveHundredYen,OneThousandYenBill oneThousandYen,
            FiveThousandYenBill fiveThousandYen,TenThousandYenBill tenThousandYen,OneYenBundle oneYenBundle,
            FiveYenBundle fiveYenBundle,TenYenBundle tenYenBundle,FiftyYenBundle fiftyYenBundle,OneHundredYenBundle oneHundredYenBundle,
            FiveHundredYenBundle fiveHundredYenBundle)
        {
            Total = oneYen.Amount + fiveYen.Amount + tenYen.Amount + fiftyYen.Amount + oneHundredYen.Amount + 
                fiveHundredYen.Amount +oneThousandYen.Amount + fiveThousandYen.Amount + tenThousandYen.Amount +
                oneYenBundle.Amount + fiveYenBundle.Amount + tenYenBundle.Amount + fiftyYenBundle.Amount + 
                oneHundredYenBundle.Amount + fiveHundredYenBundle.Amount;
        }
        /// <summary>
        /// トータル金額
        /// </summary>
        public string TotalAmount
        {
            get
            {
                return Total.ToString("N");
            }
        }
    }
}
