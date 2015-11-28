namespace taskScheduler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.debugLbl = new System.Windows.Forms.Label();
            this.avgWaitForIntensityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avgStandbyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avgWaitForPriorityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.minComplexity = new System.Windows.Forms.NumericUpDown();
            this.maxComplexity = new System.Windows.Forms.NumericUpDown();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForIntensityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgStandbyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForPriorityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minComplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxComplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(545, 12);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(133, 45);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "START!";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(545, 154);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(0, 13);
            this.debugLbl.TabIndex = 4;
            // 
            // avgWaitForIntensityChart
            // 
            chartArea1.Name = "ChartArea1";
            this.avgWaitForIntensityChart.ChartAreas.Add(chartArea1);
            this.avgWaitForIntensityChart.Location = new System.Drawing.Point(12, 301);
            this.avgWaitForIntensityChart.Name = "avgWaitForIntensityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.avgWaitForIntensityChart.Series.Add(series1);
            this.avgWaitForIntensityChart.Size = new System.Drawing.Size(527, 282);
            this.avgWaitForIntensityChart.TabIndex = 7;
            this.avgWaitForIntensityChart.Text = "avgWaitForIntensityChart";
            // 
            // avgStandbyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.avgStandbyChart.ChartAreas.Add(chartArea2);
            this.avgStandbyChart.Location = new System.Drawing.Point(12, 12);
            this.avgStandbyChart.Name = "avgStandbyChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.avgStandbyChart.Series.Add(series2);
            this.avgStandbyChart.Size = new System.Drawing.Size(527, 282);
            this.avgStandbyChart.TabIndex = 8;
            this.avgStandbyChart.Text = "avgStandbyChart";
            // 
            // avgWaitForPriorityChart
            // 
            chartArea3.Name = "ChartArea1";
            this.avgWaitForPriorityChart.ChartAreas.Add(chartArea3);
            this.avgWaitForPriorityChart.Location = new System.Drawing.Point(685, 12);
            this.avgWaitForPriorityChart.Name = "avgWaitForPriorityChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.avgWaitForPriorityChart.Series.Add(series3);
            this.avgWaitForPriorityChart.Size = new System.Drawing.Size(543, 571);
            this.avgWaitForPriorityChart.TabIndex = 9;
            this.avgWaitForPriorityChart.Text = "avgWaitForPriorityChart";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(549, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // minComplexity
            // 
            this.minComplexity.Location = new System.Drawing.Point(551, 147);
            this.minComplexity.Name = "minComplexity";
            this.minComplexity.Size = new System.Drawing.Size(120, 20);
            this.minComplexity.TabIndex = 11;
            this.minComplexity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // maxComplexity
            // 
            this.maxComplexity.Location = new System.Drawing.Point(551, 209);
            this.maxComplexity.Name = "maxComplexity";
            this.maxComplexity.Size = new System.Drawing.Size(120, 20);
            this.maxComplexity.TabIndex = 12;
            this.maxComplexity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(taskScheduler.Process);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Step";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Min complexity(ticks)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max complexity(ticks)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxComplexity);
            this.Controls.Add(this.minComplexity);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.avgWaitForPriorityChart);
            this.Controls.Add(this.avgStandbyChart);
            this.Controls.Add(this.avgWaitForIntensityChart);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.startStopBtn);
            this.Name = "MainForm";
            this.Text = "Task scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForIntensityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgStandbyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForPriorityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minComplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxComplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label debugLbl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wasUpdatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource processBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgWaitForIntensityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgStandbyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgWaitForPriorityChart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown minComplexity;
        private System.Windows.Forms.NumericUpDown maxComplexity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

