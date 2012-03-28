namespace RedisQueueTest
{
  using System;
  using RedisQueue;
  using RedisQueue.Bootstrap;

  class Program
  {
    static void Main(string[] args)
    {
      BootstrapManager.InitLogging();
      BootstrapManager.BootRedis();

      var queueManager = new QueueManager<Job>("urn:company:product:module:function");
      queueManager.Flush();

      queueManager.SubscribeForNewItem(
          job => job.DoWork()
        );

      Console.WriteLine("Press ENTER to stop serving...");
      Console.Read();

    }
  }
}
