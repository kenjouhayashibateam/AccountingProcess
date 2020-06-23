
namespace Domain.ValueObjects
{
    /// <summary>
    ///  十円玉
    ///  </summary>
     public class TenYenCoin:MoneyCategory<TenYenCoin>
    {
        public TenYenCoin()
        {
            Category = 10;
        }
    }
}
