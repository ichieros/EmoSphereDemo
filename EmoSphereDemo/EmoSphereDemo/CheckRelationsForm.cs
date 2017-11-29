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
    public partial class CheckRelationsForm : Form
    {
        Student baseStudent;

        public CheckRelationsForm(Student baseStudent)
        { 
            this.baseStudent = baseStudent;

            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblRelation1.Text = baseStudent.Relations[0].RelationShip.Name;
            tbRelation1.Value = (int)(baseStudent.Relations[0].RelationValue * 100);

            lblRelation2.Text = baseStudent.Relations[1].RelationShip.Name;
            tbRelation2.Value = (int)(baseStudent.Relations[1].RelationValue * 100);

            lblRelation3.Text = baseStudent.Relations[2].RelationShip.Name;
            tbRelation3.Value = (int)(baseStudent.Relations[2].RelationValue * 100);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
