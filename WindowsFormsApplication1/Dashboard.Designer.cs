namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtWaitingPerTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtWaitingPerMin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWaitingPerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWaitingPerMin)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtWaitingPerTime
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtWaitingPerTime.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtWaitingPerTime.Legends.Add(legend1);
            this.chrtWaitingPerTime.Location = new System.Drawing.Point(0, -1);
            this.chrtWaitingPerTime.Name = "chrtWaitingPerTime";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Customer";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chrtWaitingPerTime.Series.Add(series1);
            this.chrtWaitingPerTime.Size = new System.Drawing.Size(667, 300);
            this.chrtWaitingPerTime.TabIndex = 0;
            this.chrtWaitingPerTime.Text = "chart1";
            // 
            // chrtWaitingPerMin
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtWaitingPerMin.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtWaitingPerMin.Legends.Add(legend2);
            this.chrtWaitingPerMin.Location = new System.Drawing.Point(0, 305);
            this.chrtWaitingPerMin.Name = "chrtWaitingPerMin";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Customer";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chrtWaitingPerMin.Series.Add(series2);
            this.chrtWaitingPerMin.Size = new System.Drawing.Size(667, 300);
            this.chrtWaitingPerMin.TabIndex = 1;
            this.chrtWaitingPerMin.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 607);
            this.Controls.Add(this.chrtWaitingPerMin);
            this.Controls.Add(this.chrtWaitingPerTime);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtWaitingPerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWaitingPerMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWaitingPerTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWaitingPerMin;
    }
}