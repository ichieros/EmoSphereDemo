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
    public partial class GameForm : Form
    {
        Classroom classroom;
        public GameForm()
        {
            InitializeComponent();
            classroom = new Classroom();
            UpdateUI();
        }

        private void UpdateUI()
        {
            Student[] students = classroom.students;

            tbEmotionA.Value = (int)(students[0].EmotionalState * 100);
            tbEmotionB.Value = (int)(students[1].EmotionalState * 100);
            tbEmotionC.Value = (int)(students[2].EmotionalState * 100);
            tbEmotionD.Value = (int)(students[3].EmotionalState * 100);

            tbPersonalityA.Value = (int)(students[0].Personality * 100);
            tbPersonalityB.Value = (int)(students[1].Personality * 100);
            tbPersonalityC.Value = (int)(students[2].Personality * 100);
            tbPersonalityD.Value = (int)(students[3].Personality * 100);



            lblChairIndexA.Text = "Chair number: " + students[0].ChairIndex;
            lblChairIndexB.Text = "Chair number: " + students[1].ChairIndex;
            lblChairIndexC.Text = "Chair number: " + students[2].ChairIndex;
            lblChairIndexD.Text = "Chair number: " + students[3].ChairIndex;

            lblFrameCounter.Text = classroom.clock.ToString();

            if(classroom.lastAction != null)
            {

                if(classroom.lastAction.PerformingStudent == students[0])
                {
                    lblActionA.Text = classroom.lastAction.Description;
                }
                else
                {
                    lblActionA.Text = "";
                }
                if (classroom.lastAction.PerformingStudent == students[1])
                {
                    lblActionB.Text = classroom.lastAction.Description;
                }
                else
                {
                    lblActionB.Text = "";
                }
                if (classroom.lastAction.PerformingStudent == students[2])
                {
                    lblActionC.Text = classroom.lastAction.Description;
                }
                else
                {
                    lblActionC.Text = "";
                }
                if (classroom.lastAction.PerformingStudent == students[3])
                {
                    lblActionD.Text = classroom.lastAction.Description;
                }
                else
                {
                    lblActionD.Text = "";
                }
                if (classroom.lastAction.TargetStudent == students[0])
                {
                    lblActionA.Text = "target";
                }

                if (classroom.lastAction.TargetStudent == students[1])
                {
                    lblActionB.Text = "target";
                }

                if (classroom.lastAction.TargetStudent == students[2])
                {
                    lblActionC.Text = "target";
                }

                if (classroom.lastAction.TargetStudent == students[3])
                {
                    lblActionD.Text = "target";
                }


            }

        }

        private void btnNextFrame_Click(object sender, EventArgs e)
        {
            classroom.PassTime();
            UpdateUI();
        }

        private void btnToLayoutScreen_Click(object sender, EventArgs e)
        {
            (new LayOutForm(classroom.students)).ShowDialog();
            UpdateUI();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckRelationsA_Click(object sender, EventArgs e)
        {
            StartCheckRelationsForm(classroom.students[0]);
        }

        private void btnCheckRelationsB_Click(object sender, EventArgs e)
        {
            StartCheckRelationsForm(classroom.students[1]);
        }

        private void btnCheckRelationsC_Click(object sender, EventArgs e)
        {
            StartCheckRelationsForm(classroom.students[2]);
        }

        private void btnCheckRelationsD_Click(object sender, EventArgs e)
        {
            StartCheckRelationsForm(classroom.students[3]);
        }

        private void StartCheckRelationsForm(Student baseStudent)
        {
            (new CheckRelationsForm(baseStudent)).ShowDialog();
        }

        private void btnPerformAction_Click(object sender, EventArgs e)
        {
            (new ActionForm(classroom)).ShowDialog();
            UpdateUI();
        }
    }
}
