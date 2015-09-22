using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace taskScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Dispatcher = new Dispatcher();
            Dispatcher.UpdateStatus += DispatcherOnUpdateStatus;
            
            processBindingSource.DataSource = Dispatcher.AllTasks;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = processBindingSource;
        }

        private void DispatcherOnUpdateStatus(object sender, ProcessUpdateInfo args)
        {
            Invoke((Action) (() =>
            {
                debugLbl.Text = $"allTasks:{Dispatcher.AllTasks.Count}";
                if (args.NewTask != null)
                {
                    Dispatcher.AllTasks.Add(args.NewTask);
                }
                dataGridView.Refresh();
            }));
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

                //Invoke((Action)(() => tickLabel.Text = Dispatcher.CurrentTick.ToString()));
                //debugLbl.Text =
                //    $"allTasks:{Dispatcher.AllTasks.Count}\nin wait:{Dispatcher.WaitLine.Count}\nstandby:{Dispatcher.Standby}";

                //if (Dispatcher.AllTasks.Count > 15)
                //{
                //    Debug.WriteLine("AHTUNG!!   " + Dispatcher.AllTasks.Count);
                //}  
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
