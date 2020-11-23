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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = Enum.GetValues(typeof(StudentType));
            cbxDorm.DataSource = Enum.GetValues(typeof(DormLocation));
            cbxMeal.DataSource = Enum.GetValues(typeof(MealPlan));
            cbxType.SelectedItem = StudentType.Commuter;
            cbxDorm.SelectedItem = null;
            cbxMeal.SelectedItem = null;
            gbxDorm.Enabled = false;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((StudentType)cbxType.SelectedIndex == StudentType.Commuter)
            {
                cbxDorm.SelectedItem = null;
                cbxMeal.SelectedItem = null;
                gbxDorm.Enabled = false;
            }
            else
            {
                gbxDorm.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newId = 0;
            int index;
            try
            {
                newId = Convert.ToInt32(txbId.Text);
                index = Program.StudentList.FindIndex(s => s.Id == newId);
                if (index >= 0)
                {
                    throw new StudentIdAlreadyExistsException();
                }

                if ((StudentType)cbxType.SelectedIndex == StudentType.Commuter)
                {
                    Program.StudentList.Add(new Student(newId, txbName.Text, new List<Assignment>()));
                }
                else
                {
                    Program.StudentList.Add(new DormStudent(newId, txbName.Text, new List<Assignment>(), (DormLocation)cbxDorm.SelectedItem, (MealPlan)cbxMeal.SelectedItem));
                }
                MessageBox.Show("Student successfully added", caption: "Success");
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
