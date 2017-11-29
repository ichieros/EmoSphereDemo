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
    public partial class ActionForm : Form
    {
        Classroom classroom;
        public ActionForm(Classroom classroom)
        {
            this.classroom = classroom;

            InitializeComponent();

            foreach (Student student in classroom.students)
            {
                cbStudents.Items.Add(student);
            }
            cbStudents.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student", "ERROR");
                return;
            }
            bool positive = false;
            if(tbPositive.Value == 1)
            {
                positive = true;
            }

            classroom.performTEacherAction((Student)cbStudents.SelectedItem, positive);

            this.Close();
        }
    }
}
