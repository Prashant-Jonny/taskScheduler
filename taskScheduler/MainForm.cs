using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace taskScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Dispatcher = new Dispatcher();
            
            processBindingSource.DataSource = Dispatcher.AllTasks;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = processBindingSource;
        }
        private bool Running { get; set; } = false;
        private Dispatcher Dispatcher { get; set; }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                Running = true;
                backgroundWorker1.RunWorkerAsync();
                startStopBtn.Text = @"STOP";
            }
            else
            {
                Running = false;
                startStopBtn.Text = @"START!";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(Running)
            {
                Dispatcher.RunTick();

                tickLabel.Text = Dispatcher.CurrentTick.ToString();
                debugLbl.Text =
                    $"allTasks:{Dispatcher.AllTasks.Count}\nin wait:{Dispatcher.WaitLine.Count}\nstandby:{Dispatcher.Standby}";  
            }
            Running = false;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Process.CreatedProcesses = 0;
            tickLabel.Text = @"0";
            Dispatcher = new Dispatcher();
            dataGridView.DataSource = Dispatcher.AllTasks;
        }
    }
}
