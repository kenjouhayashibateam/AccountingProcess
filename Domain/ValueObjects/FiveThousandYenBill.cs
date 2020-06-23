
namespace Domain.ValueObjects
{
    /// <summary>
    /// 五千円札
    /// </summary>
    public class FiveThousandYenBill : MoneyCategory<FiveThousandYenBill>
    {
        public FiveThousandYenBill()
        {
            Category = 5000;
        }
    }
}
