
using System.Security.Cryptography.X509Certificates;

namespace Domain.ValueObjects
{
    /// <summary>
    /// 金種クラス
    /// </summary>
    public abstract class SingleMoney : MoneyCategory<SingleMoney>
    {
        protected SingleMoney(int _category) : base(_category) { }

        public override int Amount => Category * Count;
    }
} 
