namespace WindowsFormsApplication1
{
    partial class InterarrivalDistribution
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
            this.grdInterarrival = new System.Windows.Forms.DataGridView();
            this.InterarrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInterarrivalAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInterarrival)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInterarrival
            // 
            this.grdInterarrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInterarrival.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTime,
            this.Probability});
            this.grdInterarrival.Location = new System.Drawing.Point(12, 12);
            this.grdInterarrival.Name = "grdInterarrival";
            this.grdInterarrival.Size = new System.Drawing.Size(243, 183);
            this.grdInterarrival.TabIndex = 0;
            // 
            // InterarrivalTime
            // 
            this.InterarrivalTime.HeaderText = "Interarrival Time";
            this.InterarrivalTime.Name = "InterarrivalTime";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // BtnInterarrivalAdd
            // 
            this.BtnInterarrivalAdd.Location = new System.Drawing.Point(180, 226);
            this.BtnInterarrivalAdd.Name = "BtnInterarrivalAdd";
            this.BtnInterarrivalAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnInterarrivalAdd.TabIndex = 1;
            this.BtnInterarrivalAdd.Text = "Add";
            this.BtnInterarrivalAdd.UseVisualStyleBackColor = true;
            this.BtnInterarrivalAdd.Click += new System.EventHandler(this.BtnInterarrivalAdd_Click);
            // 
            // InterarrivalDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 261);
            this.Controls.Add(this.BtnInterarrivalAdd);
            this.Controls.Add(this.grdInterarrival);
            this.Name = "InterarrivalDistribution";
            this.Text = "InterarrivalDistribution";
            ((System.ComponentModel.ISupportInitialize)(this.grdInterarrival)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInterarrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.Button BtnInterarrivalAdd;
    }
}