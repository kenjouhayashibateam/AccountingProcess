
namespace Domain.ValueObjects
{
    /// <summary>
    /// 五十円玉
    /// </summary>
    public class FiftyYenCoin : MoneyCategory<FiftyYenCoin>
    {
        public FiftyYenCoin()
        {
            Category = 50;
        }
    }
}
