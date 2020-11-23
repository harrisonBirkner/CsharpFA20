using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5.Forms
{
    public partial class AssignmentsForm : Form
    {
        public int SelectedIndex { get; set; }
        public AssignmentsForm()
        {
            InitializeComponent();
        }

        private void AssignmentsForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            dgvAssignments.Rows.Clear();

            foreach (var item in Program.StudentList[SelectedIndex].Assignments)
            {
                dgvAssignments.Rows.Add();
                dgvAssignments.Rows[i].Cells[0].Value = item.Name;
                dgvAssignments.Rows[i].Cells[1].Value = item.PointsEarned;
                dgvAssignments.Rows[i].Cells[2].Value = item.PointsPossible;
                i++;
            }
        }

        private void dgvAssignments_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dgvAssignments.Rows[e.RowIndex].ErrorText = "";
            string headerText = dgvAssignments.Columns[e.ColumnIndex].HeaderText;
            double newInt;

            if (headerText.Equals("Name")) return;
            if (dgvAssignments.Rows[e.RowIndex].IsNewRow) { return; }
            if (!double.TryParse(e.FormattedValue.ToString(), out newInt) || newInt < 0)
            {
                e.Cancel = true;
                dgvAssignments.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            }
            else if (e.ColumnIndex == 2)
            {
                double pEarned = Convert.ToDouble(dgvAssignments.Rows[e.RowIndex].Cells[1].Value);

                if (pEarned > newInt)
                {
                    dgvAssignments.Rows[e.RowIndex].ErrorText = "points possible must be more than or equal to points earned";
                }
            }
        }

        private void AssignmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.StudentList[SelectedIndex].Assignments = new List<Assignment>();

            foreach (DataGridViewRow dr in dgvAssignments.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    string n = dr.Cells[0].Value.ToString();
                    double pE = Convert.ToDouble(dr.Cells[1].Value);
                    double pP = Convert.ToDouble(dr.Cells[2].Value);
                    Assignment a = new Assignment(n, pE, pP);

                    Program.StudentList[SelectedIndex].Assignments.Add(a);
                }

            }
        }
    }
}
