using System;
using System.Timers;

namespace LambdaEventAddRemove
{
    public class LambdaEventAddRemove : IDisposable
    {
        private Timer _timer;
        private bool _disposable;

        /// <summary>
        /// コンストラクター
        /// </summary>
        public LambdaEventAddRemove()
        {
            _disposable = false;
            _timer = new Timer();
            _timer.Interval = 1;
            ElapsedEventHandler elapsedEvent = null;
            elapsedEvent = (s, e) =>
             {
                 if(_disposable)
                 {
                     _timer.Elapsed -= elapsedEvent;
                 }
                 Console.WriteLine("Timer 500");
             };
            _timer.Elapsed += elapsedEvent;
            _timer.Start();
        }

        /// <summary>
        /// Diposeメソッドの実装
        /// </summary>
        public void Dispose()
        {
            _disposable = true;
            System.Threading.Thread.Sleep(50);
            _timer.Stop();
        }
    }
}
