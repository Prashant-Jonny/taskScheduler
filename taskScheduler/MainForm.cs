using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskScheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dispatcher = new Dispatcher();
        }
        private bool running { get; set; } = false;
        private Dispatcher dispatcher { get; set; }
        private Dictionary<int, DataGridViewRow> idToRowDictionary = new Dictionary<int, DataGridViewRow>();

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                running = true;
                backgroundWorker1.RunWorkerAsync();
                startStopBtn.Text = "STOP";
            }
            else
            {
                running = false;
                startStopBtn.Text = "START!";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(running)
            {
                dispatcher.RunTick();
                tickLabel.Text = dispatcher.CurrentTick.ToString();
                debugLbl.Text = string.Format("allTasks:{0}\nin wait:{1}\nstandby:{2}", 
                    dispatcher.allTasks.Count, dispatcher.waitLine.Count, dispatcher.Standby);
                updateTable();
            }
            running = false;
        }

        private void redrawRow(Process p)
        {
            p.WasUpdated = false;
            var row = getRowAt(p.Id);
            var finishTimeColumnValue = (p.TimeToSolve != p.Progress ? p.ProcessStatus() : (p.SolvedTime()).ToString());
            row.SetValues(p.Id, p.DeliveryTick, p.TimeToSolve, finishTimeColumnValue, p.WaitTime);
        }

        private void updateTable()
        {
            foreach (var p in dispatcher.allTasks.Where(p => p.WasUpdated))
            {
                redrawRow(p);
            }
        }

        private DataGridViewRow getRowAt(int id)
        {
            if (!idToRowDictionary.ContainsKey(id))
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                int index = dataGridView.Rows.Add(id,row);
                idToRowDictionary[id] = dataGridView.Rows[index];
                return dataGridView.Rows[index];
            }
            return idToRowDictionary[id];
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Process.createdProcesses = 0;
            tickLabel.Text = "0";
            dispatcher = new Dispatcher();
            idToRowDictionary.Clear();
            dataGridView.Rows.Clear();
        }
    }
}
