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

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                drawAll();
                running = true;
                backgroundWorker1.RunWorkerAsync();
                startStopBtn.Text = "STOP";
            }
            else
            {
                running = false;
                Process.createdProcesses = 0;
                tickLabel.Text = "0";
                dispatcher = new Dispatcher();
                dataGridView1.Rows.Clear();
                startStopBtn.Text = "START!";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i < 40; i++)
            {
                dispatcher.RunTick();
                tickLabel.Text = dispatcher.CurrentTick.ToString();
                debugLbl.Text = string.Format("allTasks:{0}, in wait:{1}", dispatcher.allTasks.Count, dispatcher.waitLine.Count);
                updateTable();
            }
        }

        private void drawAll()
        {
            dataGridView1.Rows.Clear();
            foreach(var p in dispatcher.allTasks)
            {
                
                var row = getRowAt(p.Id);
                var finishTimeColumnValue = (p.TimeToSolve != p.Progress ? "??" : (p.SolvedTime()).ToString());
                row.SetValues(p.Id, p.DeliveryTick, p.TimeToSolve, finishTimeColumnValue, p.WaitTime);
            }
        }

        private void updateTable()
        {
            foreach (var p in dispatcher.allTasks.Where(p => p.WasUpdated))
            {
                p.WasUpdated = false;
                var row = getRowAt(p.Id);
                var finishTimeColumnValue = (p.TimeToSolve != p.Progress ? "??" : p.SolvedTime().ToString());
                row.SetValues(p.Id, p.DeliveryTick, p.TimeToSolve,  finishTimeColumnValue, p.WaitTime);
            }
        }

        private Dictionary<int, DataGridViewRow> idToRowDictionary = new Dictionary<int, DataGridViewRow>();

        private DataGridViewRow getRowAt(int id)
        {
            if (!idToRowDictionary.ContainsKey(id))
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                int index = dataGridView1.Rows.Add(id,row);
                idToRowDictionary[id] = dataGridView1.Rows[index];
                return dataGridView1.Rows[index];
            }
            return idToRowDictionary[id];
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Process.createdProcesses = 0;
            tickLabel.Text = "0";
            dispatcher = new Dispatcher();
            dataGridView1.Rows.Clear();
            drawAll();
        }
    }
}
