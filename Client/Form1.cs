namespace RedisQueueTest
{
  using System.Windows.Forms;

  public partial class Form1 : Form
  {
    private int sequence = 1;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      Program.QueueManager.Push(new Job { Param1 = (++sequence).ToString(), Param2 = " is a ", Param3 = "test" }, true);
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      for (int i = 0; i < 100; i++)
      {
        Program.QueueManager.Push(new Job { Param1 = (++sequence).ToString(), Param2 = " is a ", Param3 = "test" }, true);
      }
    }

    private void button3_Click(object sender, System.EventArgs e)
    {
      Program.QueueManager.PushNewItemNotification();
    }

    private void button4_Click(object sender, System.EventArgs e)
    {
      listBox1.Items.Clear();
      listBox1.Items.AddRange(Program.QueueManager.GetElements());
    }
  }
}
