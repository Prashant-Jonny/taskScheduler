using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            //dataGridView.AutoGenerateColumns = true;
            //dataGridView.DataSource = processBindingSource;

            IntencityCycleFinished += IntencityCycleFinishedCallback;
            numericUpDown1.Maximum = Steps - 1;
            numericUpDown1.Value = 0;
            numericUpDown1.Minimum = 0;
            
        }

        private void DispatcherOnUpdateStatus(object sender, ProcessUpdateInfo args)
        {               
            Invoke((Action) (() =>
            {
                //tickLabel.Text = $"{Dispatcher.CurrentTick}";
                //double avg = Dispatcher.AllTasks.Aggregate<Process, double>(0, (current, i) => current + i.WaitTime) / Dispatcher.AllTasks.Count;
                //debugLbl.Text = $"allTasks:{Dispatcher.AllTasks.Count}\nin wait:{Dispatcher.WaitLine.Sum(x=>x.Count)}\nstandby:{Dispatcher.Standby}\navg wait:{avg:0.00}";
                if (args.NewTask != null)
                {
                    //Dispatcher.AllTasks.Add(args.NewTask);
                }
                //dataGridView.Refresh();
            }));
        }

        private bool Running { get; set; }
        private Dispatcher Dispatcher { get; set; }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                Running = true;
                InitCharts();
                backgroundWorker1.RunWorkerAsync();
                startStopBtn.Text = @"STOP";
            }
            else
            {
                Running = false;
                startStopBtn.Text = @"START!";
            }
        }

        public void InitCharts()
        {
            //init waitTime (intensity) chart
            avgWaitForIntensityChart.Series.Clear();
            var mySeries = new Series
            {
                Name = "mySeries",
                Color = System.Drawing.Color.RoyalBlue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3
            };
            avgWaitForIntensityChart.Series.Add(mySeries);
            //init standBy chart
            avgStandbyChart.Series.Clear();
            mySeries = new Series
            {
                Name = "mySeries",
                Color = System.Drawing.Color.RoyalBlue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3
            };
            avgStandbyChart.Series.Add(mySeries);
        }
        public const int Steps = 20;
        public double[,]WaitTimeForPriority = new double[Steps, Dispatcher.MaxPriority];
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            double probability = 0;
            double step = (1.0 - probability)/Steps;
            int []standByTime = new int[Steps];
            double []waitTimeForIntensity = new double[Steps];
            
            for (int s = 0; s < Steps && Running; s++)
            {
                var probability1 = probability;
                Invoke((Action) (() =>
                {
                    Dispatcher = new Dispatcher
                    {
                        TaskAdditionProbability = probability1,
                        MinComplexity = (int) minComplexity.Value,
                        MaxComplexity = (int) maxComplexity.Value
                    };
                    Dispatcher.UpdateStatus += DispatcherOnUpdateStatus;

                }));
                for (int i = 0; i < 200; i++)
                {
                    Dispatcher.RunTick();
                }
                Dispatcher.GenerateTasks = false;
                for (int i = 0; i < 500; i++)
                {
                    Dispatcher.RunTick();
                }
                standByTime[s] = Dispatcher.Standby;
                waitTimeForIntensity[s] = Dispatcher.AllTasks.Any() ? Dispatcher.AllTasks.Average(t => t.WaitTime) : 0;
                for (int i = 0; i < Dispatcher.MaxPriority; i++)
                {
                    if (Dispatcher.AllTasksGrouped[i].Any())
                        WaitTimeForPriority[s, i] = Dispatcher.AllTasksGrouped[i].Average(x => x.WaitTime);
                }
                IntencityCycleFinished?.Invoke(new PlotsData
                {
                    Step = s,
                    Intensity = probability,
                    WaitTime = waitTimeForIntensity[s],
                    StandBy = standByTime[s]/(double)Dispatcher.CurrentTick,
                });
                probability += step;
            }
            Invoke((Action) (() =>
            {
                Running = false;
                startStopBtn.Text = @"START!";
            }));

        }

        public class PlotsData
        {
            public int Step { get; set; }
            public double StandBy { get; set; }
            public double WaitTime { get; set; }
            public double Intensity { get; set; }
        }

        public delegate void IntencityCycleFinishedDelegate(PlotsData data);
        
        public event IntencityCycleFinishedDelegate IntencityCycleFinished;

        public Series[] WaitByPriorityChart { get; set; }  = new Series[Steps];

        public void IntencityCycleFinishedCallback(PlotsData data)
        {
            Invoke((Action)(() =>
            {
                avgWaitForIntensityChart.Series["mySeries"].Points.AddXY(data.Intensity, data.WaitTime);
                avgWaitForIntensityChart.Invalidate();
                avgStandbyChart.Series["mySeries"].Points.AddXY(data.Intensity, data.StandBy);
                avgStandbyChart.Invalidate();

                var series = new Series
                {
                    Name = "mySeries",
                    Color = System.Drawing.Color.RoyalBlue,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Column,
                    BorderWidth = 3
                };

                for (int i = 0; i < Dispatcher.MaxPriority; i++)
                {
                    series.Points.AddXY(i, WaitTimeForPriority[data.Step, i]);
                }
                WaitByPriorityChart[data.Step] = series;
                numericUpDown1.Value = data.Step;
            }));
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            avgWaitForPriorityChart.Series.Clear();
            if (WaitByPriorityChart[(int) numericUpDown1.Value] != null)
            {
                avgWaitForPriorityChart.Series.Add(WaitByPriorityChart[(int) numericUpDown1.Value]);
                avgWaitForPriorityChart.Invalidate();
                avgWaitForPriorityChart.ChartAreas[0].AxisY.Maximum =
                    WaitByPriorityChart[(int) numericUpDown1.Value].Points.Max(x => x.YValues[0]);
            }
        }
    }
}
