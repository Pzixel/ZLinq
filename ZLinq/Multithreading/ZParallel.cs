using System;
using System.Collections.Generic;
using System.Threading;

namespace ZLinq
{
    public static class ZParallel
    {
        public static void Foreach<T>(this ICollection<T> source, Action<T> action)
        {
            var allDone = new ManualResetEventSlim(false);
            int completed = 0;
            foreach (var item in source)
            {
                ThreadPool.QueueUserWorkItem(state =>
                {
                    var closure = (T)state;
                    action(closure);
                    if (Interlocked.Increment(ref completed) == source.Count)
                        allDone.Set();
                }, item);
            }
            allDone.Wait();
        }

        public static void Do(Action action1, Action action2)
        {
            var firstTask = QueueWaitableTask(action1);
            action2();
            firstTask.Wait();
        }

        public static ManualResetEventSlim QueueWaitableTask(Action action)
        {
            var result = new ManualResetEventSlim(false);
            ThreadPool.QueueUserWorkItem(mse =>
            {
                action();
                ((ManualResetEventSlim) mse).Set();
            }, result);
            return result;
        }
    }
}