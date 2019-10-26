using System;
using System.Collections.Generic;

namespace Tutorial_Interface.Lesson1
{
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }

        // https://docs.microsoft.com/ja-jp/dotnet/csharp/tutorials/default-interface-methods-versions#upgrade-with-default-interface-methods
        // 以下は上記URLにあるコードだが、ビルドエラーになる。
        // error CS1061: 'IEnumerable<IOrder>' に 'Count' の定義が含まれておらず、型 'IEnumerable<IOrder>' の最初の引数を受け付けるアクセス可能な拡張メソッド 'Count' が見つかりませんでした。
        /*
        // Version 1:
        public decimal ComputeLoyaltyDiscount()
        {
            DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
//            if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))
            if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count > 10))
            {
                return 0.10m;
            }
            return 0;
        }
        */
    }
}
