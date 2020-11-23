using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class ChangeForm : Form
    {
        public int SelectedIndex { get; set; }
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = Enum.GetValues(typeof(StudentType));
            cbxDorm.DataSource = Enum.GetValues(typeof(DormLocation));
            cbxMeal.DataSource = Enum.GetValues(typeof(MealPlan));
            txbId.Text = Convert.ToString(Program.StudentList[SelectedIndex].Id);
            txbName.Text = Program.StudentList[SelectedIndex].Name;

            if (Program.StudentList[SelectedIndex] is DormStudent)
            {
                DormStudent ds = (DormStudent)Program.StudentList[SelectedIndex];
                cbxMeal.SelectedItem = ds.MealPlan;
                cbxDorm.SelectedItem = ds.Location;
                cbxType.SelectedItem = StudentType.Dorm;
            }
            else
            {
                gbxDorm.Enabled = false;
                cbxType.SelectedItem = StudentType.Commuter;
            }

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((StudentType)cbxType.SelectedItem == StudentType.Dorm)
            {
                gbxDorm.Enabled = true;
            }
            else
            {
                cbxDorm.SelectedItem = null;
                cbxMeal.SelectedItem = null;
                gbxDorm.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int newId = 0;
            int index;
            List<Assignment> newAssignments = Program.StudentList[SelectedIndex].Assignments;
            try
            {
                newId = Convert.ToInt32(txbId.Text);
                index = Program.StudentList.FindIndex(s => s.Id == newId);
                if (index >= 0)
                {
                    throw new StudentIdAlreadyExistsException();
                }
                if ((StudentType)cbxType.SelectedItem == StudentType.Commuter)
                {
                    Program.StudentList[SelectedIndex] = new Student(newId, txbName.Text, newAssignments);   
                }
                else
                {
                    Program.StudentList[SelectedIndex] = new DormStudent(newId, txbName.Text, newAssignments,
                                                          (DormLocation)cbxDorm.SelectedItem, (MealPlan)cbxMeal.SelectedItem);        
                }
                MessageBox.Show("Student successfully changed", caption: "Success");
                MainForm.validStudentFlag = true;
                this.Close();
            }
            catch (StudentIdAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message, caption: "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, caption: "Error");
                MainForm.validStudentFlag = false;
            }
        }
    }
}
