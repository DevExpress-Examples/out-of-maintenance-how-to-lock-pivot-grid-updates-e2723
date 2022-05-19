Imports Microsoft.VisualBasic
Imports System
Namespace XtraPivotGrid_BeginEndUpdate
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim PivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.btnBegin = New DevExpress.XtraEditors.SimpleButton()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbUnlocked = New System.Windows.Forms.RadioButton()
            Me.rbLocked = New System.Windows.Forms.RadioButton()
            Me.label3 = New System.Windows.Forms.Label()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3})
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1, PivotGridGroup2})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 84)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(423, 417)
            Me.pivotGridControl1.TabIndex = 0
            '
            'pivotGridField1
            '
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField1.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "A"
            Me.pivotGridField1.DataBinding = DataSourceColumnBinding1
            Me.pivotGridField1.Name = "pivotGridField1"
            '
            'pivotGridField2
            '
            Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField2.AreaIndex = 0
            DataSourceColumnBinding2.ColumnName = "B"
            Me.pivotGridField2.DataBinding = DataSourceColumnBinding2
            Me.pivotGridField2.Name = "pivotGridField2"
            '
            'pivotGridField3
            '
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField3.AreaIndex = 0
            DataSourceColumnBinding3.ColumnName = "Data"
            Me.pivotGridField3.DataBinding = DataSourceColumnBinding3
            Me.pivotGridField3.Name = "pivotGridField3"
            '
            'btnBegin
            '
            Me.btnBegin.Location = New System.Drawing.Point(12, 55)
            Me.btnBegin.Name = "btnBegin"
            Me.btnBegin.Size = New System.Drawing.Size(75, 23)
            Me.btnBegin.TabIndex = 1
            Me.btnBegin.Text = "Transpose"
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.rbUnlocked)
            Me.groupBox1.Controls.Add(Me.rbLocked)
            Me.groupBox1.Location = New System.Drawing.Point(207, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(228, 66)
            Me.groupBox1.TabIndex = 2
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Pivot Grid Locking Options"
            '
            'rbUnlocked
            '
            Me.rbUnlocked.AutoSize = True
            Me.rbUnlocked.Location = New System.Drawing.Point(6, 42)
            Me.rbUnlocked.Name = "rbUnlocked"
            Me.rbUnlocked.Size = New System.Drawing.Size(153, 17)
            Me.rbUnlocked.TabIndex = 1
            Me.rbUnlocked.Text = "Do Not Lock the Pivot Grid"
            Me.rbUnlocked.UseVisualStyleBackColor = True
            '
            'rbLocked
            '
            Me.rbLocked.AutoSize = True
            Me.rbLocked.Checked = True
            Me.rbLocked.Location = New System.Drawing.Point(6, 19)
            Me.rbLocked.Name = "rbLocked"
            Me.rbLocked.Size = New System.Drawing.Size(116, 17)
            Me.rbLocked.TabIndex = 0
            Me.rbLocked.TabStop = True
            Me.rbLocked.Text = "Lock the Pivot Grid"
            Me.rbLocked.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(12, 12)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(189, 40)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Try transposing the pivot grid with and without locking it, to see the difference" &
    " in performance."
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(447, 513)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnBegin)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.MinimumSize = New System.Drawing.Size(463, 310)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents btnBegin As DevExpress.XtraEditors.SimpleButton
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private rbUnlocked As System.Windows.Forms.RadioButton
		Private rbLocked As System.Windows.Forms.RadioButton
		Private label3 As System.Windows.Forms.Label
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

