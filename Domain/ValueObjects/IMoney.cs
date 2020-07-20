
namespace Domain.ValueObjects
{
    interface IMoney
    {
        public int Amount { get; }

        /// <summary>
        /// 表示用金額（束用）
        /// </summary>
        public string DisplayValueAmount { get; }
        /// <summary>
        /// 表示用金額（束用）&単位
        /// </summary>
        public string DisplayValueAmountWithUnit { get; }
    }
}
