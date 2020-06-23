
namespace Domain.ValueObjects
{
    /// <summary>
    /// 一万円札
    /// </summary>
    public class TenThousandYenBill : MoneyCategory<TenThousandYenBill>
    {
        public TenThousandYenBill()
        {
            Category = 10000;
        }
    }
}
