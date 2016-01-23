namespace WindowsFormsApplication1
{
    partial class ServiceDistribution
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
            this.grdServiceDistribution = new System.Windows.Forms.DataGridView();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnServiceAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // grdServiceDistribution
            // 
            this.grdServiceDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServiceDistribution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTime,
            this.Probability});
            this.grdServiceDistribution.Location = new System.Drawing.Point(12, 35);
            this.grdServiceDistribution.Name = "grdServiceDistribution";
            this.grdServiceDistribution.Size = new System.Drawing.Size(243, 185);
            this.grdServiceDistribution.TabIndex = 0;
            // 
            // ServiceTime
            // 
            this.ServiceTime.HeaderText = "Service Time";
            this.ServiceTime.Name = "ServiceTime";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // BtnServiceAdd
            // 
            this.BtnServiceAdd.Location = new System.Drawing.Point(180, 226);
            this.BtnServiceAdd.Name = "BtnServiceAdd";
            this.BtnServiceAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnServiceAdd.TabIndex = 1;
            this.BtnServiceAdd.Text = "Add";
            this.BtnServiceAdd.UseVisualStyleBackColor = true;
            this.BtnServiceAdd.Click += new System.EventHandler(this.BtnServiceAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ServiceDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnServiceAdd);
            this.Controls.Add(this.grdServiceDistribution);
            this.Name = "ServiceDistribution";
            this.Text = "ServiceDistribution";
            this.Load += new System.EventHandler(this.ServiceDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdServiceDistribution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.Button BtnServiceAdd;
        private System.Windows.Forms.Label label1;
    }
}