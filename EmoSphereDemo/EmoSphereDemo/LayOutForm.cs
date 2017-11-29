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
    public partial class LayOutForm : Form
    {
        Student[] students;
        public LayOutForm(Student[] students)
        {

            InitializeComponent();
            this.students = students;
            updateUI();
        }

        private void updateUI()
        {

            List<Control> list = new List<Control>();

            GetAllControl(this, list);

            List<Label> allLabels = new List<Label>();

            foreach (Control control in list)
            {
                if (control.GetType() == typeof(Label))
                {
                    allLabels.Add((Label)control);
                }
            }

            foreach (Student student in students)
            {
                foreach (Label lbl in allLabels)
                {
                    if(lbl.Name == "label" + student.ChairIndex)
                    {
                        lbl.Text = student.Name;
                    }
                    else if(lbl.Text == student.Name)
                    {
                        lbl.Text = " ";
                    }
                }
            }
        }

        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(GroupBox))
                    GetAllControl(control, list);
            }
        }
    

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditLayout_Click(object sender, EventArgs e)
        {
            (new MoveStudentForm(students)).ShowDialog();
            updateUI();
        }
    }
}
