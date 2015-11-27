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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.debugLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgWaitForIntensityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avgStandbyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avgWaitForPriorityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeToSolveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForIntensityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgStandbyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForPriorityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Priority,
            this.timeToSolveDataGridViewTextBoxColumn,
            this.progressDataGridViewTextBoxColumn,
            this.deliveryTickDataGridViewTextBoxColumn,
            this.waitTimeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.processBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 11);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.Size = new System.Drawing.Size(527, 226);
            this.dataGridView.TabIndex = 5;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            // 
            // avgWaitForIntensityChart
            // 
            chartArea1.Name = "ChartArea1";
            this.avgWaitForIntensityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.avgWaitForIntensityChart.Legends.Add(legend1);
            this.avgWaitForIntensityChart.Location = new System.Drawing.Point(685, 13);
            this.avgWaitForIntensityChart.Name = "avgWaitForIntensityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.avgWaitForIntensityChart.Series.Add(series1);
            this.avgWaitForIntensityChart.Size = new System.Drawing.Size(543, 225);
            this.avgWaitForIntensityChart.TabIndex = 7;
            this.avgWaitForIntensityChart.Text = "avgWaitForIntensityChart";
            // 
            // avgStandbyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.avgStandbyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.avgStandbyChart.Legends.Add(legend2);
            this.avgStandbyChart.Location = new System.Drawing.Point(12, 243);
            this.avgStandbyChart.Name = "avgStandbyChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
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
            legend3.Name = "Legend1";
            this.avgWaitForPriorityChart.Legends.Add(legend3);
            this.avgWaitForPriorityChart.Location = new System.Drawing.Point(685, 244);
            this.avgWaitForPriorityChart.Name = "avgWaitForPriorityChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.avgWaitForPriorityChart.Series.Add(series3);
            this.avgWaitForPriorityChart.Size = new System.Drawing.Size(543, 282);
            this.avgWaitForPriorityChart.TabIndex = 9;
            this.avgWaitForPriorityChart.Text = "avgWaitForPriorityChart";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(548, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeToSolveDataGridViewTextBoxColumn
            // 
            this.timeToSolveDataGridViewTextBoxColumn.DataPropertyName = "TimeToSolve";
            this.timeToSolveDataGridViewTextBoxColumn.HeaderText = "TimeToSolve";
            this.timeToSolveDataGridViewTextBoxColumn.Name = "timeToSolveDataGridViewTextBoxColumn";
            // 
            // progressDataGridViewTextBoxColumn
            // 
            this.progressDataGridViewTextBoxColumn.DataPropertyName = "Progress";
            this.progressDataGridViewTextBoxColumn.HeaderText = "Progress";
            this.progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            this.progressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryTickDataGridViewTextBoxColumn
            // 
            this.deliveryTickDataGridViewTextBoxColumn.DataPropertyName = "DeliveryTick";
            this.deliveryTickDataGridViewTextBoxColumn.HeaderText = "DeliveryTick";
            this.deliveryTickDataGridViewTextBoxColumn.Name = "deliveryTickDataGridViewTextBoxColumn";
            this.deliveryTickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waitTimeDataGridViewTextBoxColumn
            // 
            this.waitTimeDataGridViewTextBoxColumn.DataPropertyName = "WaitTime";
            this.waitTimeDataGridViewTextBoxColumn.HeaderText = "WaitTime";
            this.waitTimeDataGridViewTextBoxColumn.Name = "waitTimeDataGridViewTextBoxColumn";
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(taskScheduler.Process);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 533);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.avgWaitForPriorityChart);
            this.Controls.Add(this.avgStandbyChart);
            this.Controls.Add(this.avgWaitForIntensityChart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.startStopBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForIntensityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgStandbyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgWaitForPriorityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label debugLbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wasUpdatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource processBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgWaitForIntensityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgStandbyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgWaitForPriorityChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeToSolveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

