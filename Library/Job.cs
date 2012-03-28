namespace RedisQueueTest
{
  using System;
  using System.Threading;

  public class Job
  {

    public string Param1 { get; set; }
    public string Param2 { get; set; }
    public string Param3 { get; set; }

    public void DoWork()
    {
      Console.WriteLine("Working on {0}, {1}, {2}", Param1, Param2, Param3);
      Thread.Sleep(300);
    }

  }
}
