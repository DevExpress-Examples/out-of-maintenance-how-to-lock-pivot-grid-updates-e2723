Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_BeginEndUpdate

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetDataTable()
        End Sub

        Private Sub btnBegin_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim startTime As Date = Date.Now
            ' If an appropriate option is enabled, 
            ' locks the pivot grid to prevent further updates.
            If rbLocked.Checked Then pivotGridControl1.BeginUpdate()
            Try
                ' Initiates transposition.
                Transpose()
            Finally
                ' If the pivot grid has been locked, unlocks it, allowing further updates.
                If rbLocked.Checked Then pivotGridControl1.EndUpdate()
            End Try

            ' Displays the amount of time taken by the transposition.
            Dim duration As TimeSpan = Date.Now - startTime
            MessageBox.Show("Transposition took " & duration.TotalSeconds.ToString("F2") & " seconds")
        End Sub

        ' Transposes the pivot grid by moving Row Fields to the Column Area, and vice versa.
        Private Sub Transpose()
            For Each field As PivotGridField In pivotGridControl1.Fields
                If field.Area = PivotArea.RowArea Then
                    field.Area = PivotArea.ColumnArea
                ElseIf field.Area = PivotArea.ColumnArea Then
                    field.Area = PivotArea.RowArea
                End If
            Next
        End Sub

        ' Generates pivot grid data.
        Public Shared Function GetDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.Add("A", GetType(String))
            table.Columns.Add("B", GetType(String))
            table.Columns.Add("Data", GetType(Integer))
            For i As Integer = 0 To 1000 - 1
                For j As Integer = 0 To 500 - 1
                    table.Rows.Add("A"c & i.ToString(), "B"c & j.ToString(), (CInt(i) \ 100))
                Next
            Next

            Return table
        End Function
    End Class
End Namespace
