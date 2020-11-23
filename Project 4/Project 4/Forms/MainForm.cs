using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Project_4
{
    public partial class MainForm : Form
    {
        public static bool validStudentFlag;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileStream inFile = null;
            try
            {
                inFile = new FileStream("students.ser",
                        FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();

                while (inFile.Position < inFile.Length)
                {
                    object obj = bFormatter.Deserialize(inFile);
                    if (obj.GetType() == typeof(Student))
                    {
                       Program.StudentList.Add((Student)obj);
                    }
                    else
                    {
                        Program.StudentList.Add((DormStudent)obj);
                    }
                }
                foreach (Student s in Program.StudentList)
                {
                    cbxSelectedId.Items.Add(s.Id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem opening the file or no students have been previously saved.", caption: "error");
            }
            finally
            {
                if (inFile != null)
                {
                    inFile.Close();
                }   
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validStudentFlag = true;
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            cbxSelectedId.Text = null;
            if (validStudentFlag == true)
            {
                cbxSelectedId.Items.Add(Program.StudentList.Last().Id);
            }   
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.StudentList != null)
            {
                try
                {
                    FileStream outFile = new FileStream("students.ser",
                         FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();

                    foreach (var item in Program.StudentList)
                    {
                        bf.Serialize(outFile, item);
                    }
                    outFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing list to file: " + ex.Message, caption: "Error");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxSelectedId.SelectedItem != null)
            {
                try
                {
                    int selectedId = Convert.ToInt32(cbxSelectedId.SelectedItem);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", caption: "Confirm Record Deletion", MessageBoxButtons.YesNo);
                    cbxSelectedId.SelectedItem = null;

                    if (dialogResult == DialogResult.Yes)
                    {
                        Program.StudentList.RemoveAll(student => student.Id == selectedId);
                        cbxSelectedId.Items.Remove(selectedId);
                        MessageBox.Show("Record successfully deleted", caption: "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while attempting to delete record: " + ex.Message, caption: "Error");
                    cbxSelectedId.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("No student was selected for deletion", caption: "Error");
            }
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbxSelectedId.SelectedItem != null)
            {
                try
                {
                    ChangeForm changeForm = new ChangeForm();
                    changeForm.SelectedIndex = cbxSelectedId.SelectedIndex;
                    changeForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured while attempting to change record: " + ex.Message, caption: "Error");
                    cbxSelectedId.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("No student was selected for change", caption: "Error");
            }
        }
    }
}
