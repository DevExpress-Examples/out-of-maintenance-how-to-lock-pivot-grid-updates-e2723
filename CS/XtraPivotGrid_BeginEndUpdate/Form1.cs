using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_BeginEndUpdate {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            pivotGridControl1.DataSource = GetDataTable();
        }
        private void btnBegin_Click(object sender, EventArgs e) {
            DateTime startTime = DateTime.Now;

            // If an appropriate option is enabled, 
            // locks the pivot grid to prevent further updates.
            if (rbLocked.Checked) pivotGridControl1.BeginUpdate();
            try {

                // Initiates transposition.
                Transpose();
            }
            finally {

                // If the pivot grid has been locked, unlocks it, allowing further updates.
                if (rbLocked.Checked) pivotGridControl1.EndUpdate();
            }

            // Displays the amount of time taken by the transposition.
            TimeSpan duration = DateTime.Now - startTime;
            MessageBox.Show("Transposition took " + 
                duration.TotalSeconds.ToString("F2") + " seconds");
        }

        // Transposes the pivot grid by moving Row Fields to the Column Area, and vice versa.
        private void Transpose() {
                foreach(PivotGridField field in pivotGridControl1.Fields) {
                    if (field.Area == PivotArea.RowArea)
                        field.Area = PivotArea.ColumnArea;
                    else if (field.Area == PivotArea.ColumnArea)
                        field.Area = PivotArea.RowArea;
                }
        }

        // Generates pivot grid data.
        public static DataTable GetDataTable() {
            DataTable table = new DataTable();
            table.Columns.Add("A", typeof(string));
            table.Columns.Add("B", typeof(string));
            table.Columns.Add("Data", typeof(int));
            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 500; j++)
                    table.Rows.Add('A' + i.ToString(), 'B' + j.ToString(), ((int)i / 100));
            return table;
        }
    }
}