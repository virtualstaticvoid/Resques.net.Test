namespace RedisQueueTest
{
  using System;
  using System.Windows.Forms;
  using RedisQueue;

  static class Program
  {

    public static QueueManager<Job> QueueManager;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

      RedisQueue.Bootstrap.BootstrapManager.BootRedis();

      QueueManager = new QueueManager<Job>("urn:company:product:module:function");

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());

      QueueManager.Dispose();

    }
  }
}
