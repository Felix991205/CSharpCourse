using System;
using System.IO;
using System.Threading;


class Test
{
	static void Main()
	{
        ThreadPool.SetMaxThreads(3, 3); // ���ڵ���CPU����, 2�������̡߳�2���첽I/O�߳�
        int workerThreads, ioThreads;
        ThreadPool.GetMaxThreads(out workerThreads, out ioThreads);
        Console.WriteLine($"workerThreads��{workerThreads},completionThreads��{ioThreads}");

        for (int i = 1; i < 100; i++){
            ThreadPool.QueueUserWorkItem(new WaitCallback(Fun), i);
        }
        Console.ReadKey();
	}

	static void Fun(object obj )
	{
        int n = (int)obj;
        Console.WriteLine(
              $"��ǰֵΪ��{n}," +
              $"�߳�ID={Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(200);
	}



}
