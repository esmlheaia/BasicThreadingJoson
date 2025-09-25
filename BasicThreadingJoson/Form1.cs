using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreadingJoson
{
    public partial class FrmBasicThread : Form
    {
        private Thread threadA, threadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
            lblThread.Text = "Start Thread";
            Console.WriteLine("-Thread 1 Start-");
            ThreadStart thread1 = new ThreadStart(MyThreadClass.Thread1);
            
            threadA = new Thread(new ThreadStart(thread1));
            threadA.Name = "Thread A process";
            
            threadB = new Thread(new ThreadStart(thread1));
            threadB.Name = "Thread B process";
            
            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            lblThread.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");
        }
    }
}
