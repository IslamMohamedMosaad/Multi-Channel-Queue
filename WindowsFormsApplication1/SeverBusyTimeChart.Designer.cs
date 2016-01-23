namespace WindowsFormsApplication1
{
    partial class SeverBusyTimeChart
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
            this.chrtServerBusy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtServerBusy)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtServerBusy
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtServerBusy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtServerBusy.Legends.Add(legend1);
            this.chrtServerBusy.Location = new System.Drawing.Point(12, 12);
            this.chrtServerBusy.Name = "chrtServerBusy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Busy";
            this.chrtServerBusy.Series.Add(series1);
            this.chrtServerBusy.Size = new System.Drawing.Size(390, 344);
            this.chrtServerBusy.TabIndex = 0;
            this.chrtServerBusy.Text = "chrtServerBusy";
            // 
            // SeverBusyTimeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 368);
            this.Controls.Add(this.chrtServerBusy);
            this.Name = "SeverBusyTimeChart";
            this.Text = "SeverBusyTimeChart";
            this.Load += new System.EventHandler(this.SeverBusyTimeChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtServerBusy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtServerBusy;
    }
}