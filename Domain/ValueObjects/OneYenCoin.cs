
namespace Domain.ValueObjects
{
    /// <summary>
    /// 一円玉
    /// </summary>
    public class OneYenCoin : MoneyCategory<OneYenCoin>
    {
       public OneYenCoin()
        {
            Category = 1;
        }
    }
}
