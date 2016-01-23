namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnInterarrivalAdd = new System.Windows.Forms.Button();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelectionMethod = new System.Windows.Forms.ComboBox();
            this.txtCustomersCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grdResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInterarrivalAdd
            // 
            this.btnInterarrivalAdd.Location = new System.Drawing.Point(16, 28);
            this.btnInterarrivalAdd.Name = "btnInterarrivalAdd";
            this.btnInterarrivalAdd.Size = new System.Drawing.Size(90, 34);
            this.btnInterarrivalAdd.TabIndex = 5;
            this.btnInterarrivalAdd.Text = "Add Interarrival table";
            this.btnInterarrivalAdd.UseVisualStyleBackColor = true;
            this.btnInterarrivalAdd.Click += new System.EventHandler(this.btnInterarrivalAdd_Click);
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(196, 28);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(90, 35);
            this.btnAddServer.TabIndex = 12;
            this.btnAddServer.Text = "Add Server\'s table";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Server Selection Method";
            // 
            // cmbSelectionMethod
            // 
            this.cmbSelectionMethod.FormattingEnabled = true;
            this.cmbSelectionMethod.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbSelectionMethod.Location = new System.Drawing.Point(165, 89);
            this.cmbSelectionMethod.Name = "cmbSelectionMethod";
            this.cmbSelectionMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectionMethod.TabIndex = 14;
            // 
            // txtCustomersCount
            // 
            this.txtCustomersCount.Location = new System.Drawing.Point(165, 131);
            this.txtCustomersCount.Name = "txtCustomersCount";
            this.txtCustomersCount.Size = new System.Drawing.Size(58, 20);
            this.txtCustomersCount.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Customers Count";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(211, 177);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grdResult
            // 
            this.grdResult.AllowUserToAddRows = false;
            this.grdResult.AllowUserToDeleteRows = false;
            this.grdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(307, 13);
            this.grdResult.Name = "grdResult";
            this.grdResult.ReadOnly = true;
            this.grdResult.Size = new System.Drawing.Size(753, 324);
            this.grdResult.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 349);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCustomersCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSelectionMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddServer);
            this.Controls.Add(this.btnInterarrivalAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInterarrivalAdd;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSelectionMethod;
        private System.Windows.Forms.TextBox txtCustomersCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView grdResult;
    }
}

