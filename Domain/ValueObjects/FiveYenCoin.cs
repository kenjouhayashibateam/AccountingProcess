
namespace Domain.ValueObjects
{
     /// <summary>
     /// 五円玉
     /// </summary>
     public class FiveYenCoin:MoneyCategory<FiveYenCoin>
    {
       
        public FiveYenCoin()
        {
            Category = 5;
        }
    }
}
