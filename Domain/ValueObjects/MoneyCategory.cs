
namespace Domain.ValueObjects
{
    public abstract class MoneyCategory<T> where T : MoneyCategory<T>
    {
        public MoneyCategory(int _category)
        {
            Category = _category;
        }
        /// <summary>
        /// 金種の数字
        /// </summary>
        public readonly int Category;
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; } = 0;
       
        public virtual int Amount { get; }
        /// <summary>
        /// 表示用金額
        /// </summary>
        public string DisplayValue
        {
            get
            {
                return Amount.ToString("N");
            }
        }
        /// <summary>
        /// 表示用金額&単位
        /// </summary>
        public string DisplayValueWithUnit
        {
            get
            {
                return DisplayValue + Properties.Resources.Unit;
            }
        }
    }
}
