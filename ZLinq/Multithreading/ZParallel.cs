using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ZLinq
{
    public static class ZParallel
    {
    public static void Foreach<T>(ICollection<T> source, Action<T> action)
    {
        var toBeProcessedOnMainThread = (int) Math.Ceiling((double)source.Count / Environment.ProcessorCount);
        var countdown = new CountdownEvent(source.Count - toBeProcessedOnMainThread);
        ConcurrentBag<Exception> exceptionsBag = null;
        var onMainThread = source.Take(toBeProcessedOnMainThread);
        foreach (var item in source.Skip(toBeProcessedOnMainThread))
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                var closure = (T)state;
                try
                {
                    action(closure);
                }
                catch (Exception ex)
                {
                    HandleException(ref exceptionsBag, countdown, ex);
                }
                finally
                {
                    countdown.Signal();
                }
            }, item);
        }
        foreach (T value in onMainThread)
        {
            try
            {
                action(value);
            }
            catch (Exception ex)
            {
                HandleException(ref exceptionsBag, countdown, ex);
            }
        }
        countdown.Wait();
        if (exceptionsBag != null)
            throw new AggregateException(exceptionsBag);
    }

    private static void HandleException(ref ConcurrentBag<Exception> exceptions, object syncRoot, Exception ex)
    {
        if (exceptions == null)
            lock (syncRoot)
                if (exceptions == null)
                    exceptions = new ConcurrentBag<Exception>();

        exceptions.Add(ex);
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