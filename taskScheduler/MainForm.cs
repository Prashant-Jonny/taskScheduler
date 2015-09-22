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
                tickLabel.Text = $"{Dispatcher.CurrentTick}";
                double avg = 0;
                foreach(var i in Dispatcher.AllTasks)
                {
                    avg += i.WaitTime;
                }
                avg /= Dispatcher.AllTasks.Count;
                debugLbl.Text = $"allTasks:{Dispatcher.AllTasks.Count}\nin wait:{Dispatcher.WaitLine.Count}\nstandby:{Dispatcher.Standby}\navg wait:{avg}";
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
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Process.CreatedProcesses = 0;
            tickLabel.Text = @"0";
            Dispatcher = new Dispatcher();
            processBindingSource.DataSource = Dispatcher.AllTasks;
            checkBox1.Checked = true;
            Dispatcher.UpdateStatus += DispatcherOnUpdateStatus;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
               Dispatcher.GenerateTasks = checkBox1.Checked;
        }
    }
}
