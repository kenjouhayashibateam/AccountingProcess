
namespace Domain.ValueObjects
{
    /// <summary>
    /// 金種クラス
    /// </summary>
    /// <typeparam name="T">金種</typeparam>
    public abstract class MoneyCategory<T> where T : MoneyCategory<T>
    {
        /// <summary>
        /// 金種の数字
        /// </summary>
        protected static int Category;
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; } = 0;
        /// <summary>
        /// 金額
        /// </summary>
        public int Amount
        {
            get
            {
                return Category*Count;
            }
         }  
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
        /// <summary>
        /// 表示用金額（束用）
        /// </summary>
        public string DisplayValueBundleAmount
        {
            get
            {
                return (Category * Count * 50).ToString("N");
            }
        }
        /// <summary>
        /// 表示用金額（束用）&単位
        /// </summary>
        public string DisplayValueBundleAmountWithUnit
        {
            get
            {
                return DisplayValueBundleAmount + Properties.Resources.Unit;
            }
        }
    }
} 
