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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.tickLabel = new System.Windows.Forms.Label();
            this.debugLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.CausesValidation = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DeliveryTime,
            this.SolveTime,
            this.FinishTime,
            this.WaitTime});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(455, 581);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // DeliveryTime
            // 
            this.DeliveryTime.HeaderText = "Delivery Time";
            this.DeliveryTime.Name = "DeliveryTime";
            this.DeliveryTime.ReadOnly = true;
            // 
            // SolveTime
            // 
            this.SolveTime.HeaderText = "Solving Time";
            this.SolveTime.Name = "SolveTime";
            this.SolveTime.ReadOnly = true;
            // 
            // FinishTime
            // 
            this.FinishTime.HeaderText = "Finish Time";
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.ReadOnly = true;
            // 
            // WaitTime
            // 
            this.WaitTime.HeaderText = "Waiting time";
            this.WaitTime.Name = "WaitTime";
            this.WaitTime.ReadOnly = true;
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(473, 12);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(133, 45);
            this.startStopBtn.TabIndex = 1;
            this.startStopBtn.Text = "START!";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(473, 63);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(133, 50);
            this.restartBtn.TabIndex = 2;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // tickLabel
            // 
            this.tickLabel.AutoSize = true;
            this.tickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tickLabel.Location = new System.Drawing.Point(520, 116);
            this.tickLabel.Name = "tickLabel";
            this.tickLabel.Size = new System.Drawing.Size(35, 37);
            this.tickLabel.TabIndex = 3;
            this.tickLabel.Text = "0";
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(470, 159);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(33, 13);
            this.debugLbl.TabIndex = 4;
            this.debugLbl.Text = "blank";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 605);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.tickLabel);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitTime;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label tickLabel;
        private System.Windows.Forms.Label debugLbl;
    }
}

