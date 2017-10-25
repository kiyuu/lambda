using System;
using System.Timers;

namespace LambdaEventAddRemove
{
    public class LambdaEventAddRemove : IDisposable
    {
        private Timer _timer;

        /// <summary>
        /// コンストラクター
        /// </summary>
        public LambdaEventAddRemove()
        {
            _timer = new Timer();
            _timer.Interval = 500;
            _timer.Elapsed += (s, e) => Console.WriteLine("Timer 500");
        }

        /// <summary>
        /// Diposeメソッドの実装
        /// </summary>
        public void Dispose()
        {
            // 1.以下ではイベント購読解除できません。理由を説明してください。
            // _timer.Elapsed -= (s, e) => Console.WriteLine();

            // 2.イベント購読解除を実装してください。
            //   ◆制限事項
            //   　・コンストラクターの処理はサンプルですので自由に修正OK
            //     ・フィールドメンバの追加もOKです。
            //   　・Diposeメソッド内または、トリッキーですが匿名メソッド内でのイベント購読解除はOK
            //   　・System.Timers.Timerを継承して改造するのもOK
            //   　・匿名メソッド（ラムダ式)は使用したままにしてください。
            //   　　例 フィールドに以下メソッドを定義するのはNG
            //     　private void timerEvent(Object sender, ElapsedEventArgs e)
            //     　{
            //     　    Console.WriteLine("Timer 500");
            //     　}
        }
    }
}
