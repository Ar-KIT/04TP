using System;
using System.Threading;
using System.Windows.Forms;

namespace TrackThread
{
    public partial class frmTrackThread : Form
    {
        Thread threadA;
        Thread threadB;
        Thread threadC;
        Thread threadD;
        public frmTrackThread()
        {
            InitializeComponent();
        }
        private void InitializeThreads()
        {
            threadA = new Thread(MyThreadClass.Thread1);
            threadB = new Thread(MyThreadClass.Thread2);
            threadC = new Thread(MyThreadClass.Thread1);
            threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;
        }

        private void btnRunThread_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            InitializeThreads();
            lblTrackThread.Text = ("-Thread Processing-");

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            lblTrackThread.Text = ("-End of Thread-");
        }
    }

    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }

    }
}
