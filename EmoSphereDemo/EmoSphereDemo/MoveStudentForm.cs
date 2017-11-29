using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoSphereDemo
{
    public partial class MoveStudentForm : Form
    {

        Student[] students;
        public MoveStudentForm(Student[] students)
        {
            this.students = students;



            InitializeComponent();
            foreach (Student student in students)
            {
                cbStudents.Items.Add(student);
            }
            cbStudents.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(cbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student", "ERROR");
                return;
            }

            foreach (Student student in students)
            {
                if(student.ChairIndex == (int)nudChairIndex.Value)
                {
                    MessageBox.Show("There is already a student in that chair!", "ERROR");
                    return;
                }
            }


            Student s = cbStudents.SelectedItem as Student;
            s.ChairIndex = (int)nudChairIndex.Value;

            this.Close();
        }
    }
}
