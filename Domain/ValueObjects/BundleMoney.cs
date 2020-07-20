using Domain.Helpers;

namespace Domain.ValueObjects
{
    /// <summary>
    /// 金銭束クラス
    /// </summary>
    public abstract class BundleMoney : MoneyCategory<BundleMoney>
    {
        protected BundleMoney(int _category) : base(_category) { }

        public override int Amount => MoneyCoinHelper.Bundle * Category * Count;
    }
}
