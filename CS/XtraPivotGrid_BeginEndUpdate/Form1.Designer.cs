namespace XtraPivotGrid_BeginEndUpdate {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.btnBegin = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUnlocked = new System.Windows.Forms.RadioButton();
            this.rbLocked = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3});
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup2.Hierarchy = null;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 84);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(423, 417);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(12, 55);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Transpose";
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbUnlocked);
            this.groupBox1.Controls.Add(this.rbLocked);
            this.groupBox1.Location = new System.Drawing.Point(207, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pivot Grid Locking Options";
            // 
            // rbUnlocked
            // 
            this.rbUnlocked.AutoSize = true;
            this.rbUnlocked.Location = new System.Drawing.Point(6, 42);
            this.rbUnlocked.Name = "rbUnlocked";
            this.rbUnlocked.Size = new System.Drawing.Size(153, 17);
            this.rbUnlocked.TabIndex = 1;
            this.rbUnlocked.Text = "Do Not Lock the Pivot Grid";
            this.rbUnlocked.UseVisualStyleBackColor = true;
            // 
            // rbLocked
            // 
            this.rbLocked.AutoSize = true;
            this.rbLocked.Checked = true;
            this.rbLocked.Location = new System.Drawing.Point(6, 19);
            this.rbLocked.Name = "rbLocked";
            this.rbLocked.Size = new System.Drawing.Size(116, 17);
            this.rbLocked.TabIndex = 0;
            this.rbLocked.TabStop = true;
            this.rbLocked.Text = "Lock the Pivot Grid";
            this.rbLocked.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Try transposing the pivot grid with and without locking it, to see the difference" +
                " in performance.";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.FieldName = "A";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.FieldName = "B";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.FieldName = "Data";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.pivotGridControl1);
            this.MinimumSize = new System.Drawing.Size(463, 310);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.SimpleButton btnBegin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUnlocked;
        private System.Windows.Forms.RadioButton rbLocked;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
    }
}

