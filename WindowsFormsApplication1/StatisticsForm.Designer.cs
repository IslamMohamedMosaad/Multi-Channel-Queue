namespace WindowsFormsApplication1
{
    partial class StatisticsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvgWaitingTime = new System.Windows.Forms.TextBox();
            this.txtProbCustWait = new System.Windows.Forms.TextBox();
            this.TxtMaxQueueLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdServerStatistics = new System.Windows.Forms.DataGridView();
            this.ServerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyOfServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilityofidle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalidletime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdServerStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "The average customer waiting time in the queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "The probability that a customer wait in the queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "The maximum queue length";
            // 
            // txtAvgWaitingTime
            // 
            this.txtAvgWaitingTime.Location = new System.Drawing.Point(333, 22);
            this.txtAvgWaitingTime.Name = "txtAvgWaitingTime";
            this.txtAvgWaitingTime.ReadOnly = true;
            this.txtAvgWaitingTime.Size = new System.Drawing.Size(100, 20);
            this.txtAvgWaitingTime.TabIndex = 10;
            // 
            // txtProbCustWait
            // 
            this.txtProbCustWait.Location = new System.Drawing.Point(333, 51);
            this.txtProbCustWait.Name = "txtProbCustWait";
            this.txtProbCustWait.ReadOnly = true;
            this.txtProbCustWait.Size = new System.Drawing.Size(100, 20);
            this.txtProbCustWait.TabIndex = 11;
            // 
            // TxtMaxQueueLength
            // 
            this.TxtMaxQueueLength.Location = new System.Drawing.Point(227, 88);
            this.TxtMaxQueueLength.Name = "TxtMaxQueueLength";
            this.TxtMaxQueueLength.ReadOnly = true;
            this.TxtMaxQueueLength.Size = new System.Drawing.Size(100, 20);
            this.TxtMaxQueueLength.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Servers\' statistics";
            // 
            // grdServerStatistics
            // 
            this.grdServerStatistics.AllowUserToAddRows = false;
            this.grdServerStatistics.AllowUserToDeleteRows = false;
            this.grdServerStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServerStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerNumber,
            this.efficiencyOfServer,
            this.AverageServiceTime,
            this.probabilityofidle,
            this.totalidletime});
            this.grdServerStatistics.Location = new System.Drawing.Point(15, 152);
            this.grdServerStatistics.Name = "grdServerStatistics";
            this.grdServerStatistics.ReadOnly = true;
            this.grdServerStatistics.Size = new System.Drawing.Size(543, 150);
            this.grdServerStatistics.TabIndex = 14;
            // 
            // ServerNumber
            // 
            this.ServerNumber.HeaderText = "Server number";
            this.ServerNumber.Name = "ServerNumber";
            this.ServerNumber.ReadOnly = true;
            // 
            // efficiencyOfServer
            // 
            this.efficiencyOfServer.HeaderText = "Efficiency of server";
            this.efficiencyOfServer.Name = "efficiencyOfServer";
            this.efficiencyOfServer.ReadOnly = true;
            // 
            // AverageServiceTime
            // 
            this.AverageServiceTime.HeaderText = "Average Service Time";
            this.AverageServiceTime.Name = "AverageServiceTime";
            this.AverageServiceTime.ReadOnly = true;
            // 
            // probabilityofidle
            // 
            this.probabilityofidle.HeaderText = "Probability of idle";
            this.probabilityofidle.Name = "probabilityofidle";
            this.probabilityofidle.ReadOnly = true;
            // 
            // totalidletime
            // 
            this.totalidletime.HeaderText = "Total idle time";
            this.totalidletime.Name = "totalidletime";
            this.totalidletime.ReadOnly = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 314);
            this.Controls.Add(this.grdServerStatistics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMaxQueueLength);
            this.Controls.Add(this.txtProbCustWait);
            this.Controls.Add(this.txtAvgWaitingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdServerStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAvgWaitingTime;
        private System.Windows.Forms.TextBox txtProbCustWait;
        private System.Windows.Forms.TextBox TxtMaxQueueLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdServerStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyOfServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilityofidle;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalidletime;
    }
}