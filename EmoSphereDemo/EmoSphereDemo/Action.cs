using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoSphereDemo
{
    public class Action
    {
        static List<string> negativeDescriptions = new List<string> { "Student gooit een propje","Student lacht iemand uit","Student scheld iemand uit"};

        private string description;
        private double emotionalChange;
        private double targetEmotionalChange;
        private double relationEmotionalChange;

        private Student performingStudent;
        private Student targetStudent;

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public double EmotionalChange
        {
            get
            {
                return emotionalChange;
            }

            set
            {
                emotionalChange = value;
            }
        }

        public double TargetEmotionalChange
        {
            get
            {
                return targetEmotionalChange;
            }

            set
            {
                targetEmotionalChange = value;
            }
        }

        public double RelationEmotionalChange
        {
            get
            {
                return relationEmotionalChange;
            }

            set
            {
                relationEmotionalChange = value;
            }
        }

        public Student PerformingStudent
        {
            get
            {
                return performingStudent;
            }

            protected set
            {
                performingStudent = value;
            }
        }

        public Student TargetStudent
        {
            get
            {
                return targetStudent;
            }

            protected set
            {
                targetStudent = value;
            }
        }

        public Action(double emotionalChange, double targetEmotionalChange, double relationEmotionalChange)
        {

                Random rndm = new Random();

                Description = negativeDescriptions[rndm.Next(negativeDescriptions.Count)];
            

            EmotionalChange = emotionalChange;
            TargetEmotionalChange = targetEmotionalChange;
            RelationEmotionalChange = relationEmotionalChange;
        }

        public void PerformAction(Student baseStudent, Student[] students, Student targetStudent = null)
        {
            performingStudent = baseStudent;
            this.targetStudent = targetStudent;
            baseStudent.EmotionalState += EmotionalChange;

            if(targetStudent != null)
            {
                targetStudent.EmotionalState += TargetEmotionalChange;
            }

            foreach(Relation relation in baseStudent.Relations)
            {
                if(RelationEmotionalChange > 0 && relation.RelationValue > 0)
                {
                    relation.RelationShip.EmotionalState += RelationEmotionalChange *2;
                }
                else if(RelationEmotionalChange < 0 && relation.RelationValue < 0)
                {
                    relation.RelationShip.EmotionalState -= RelationEmotionalChange *2;
                }
                else if (RelationEmotionalChange < 0 && relation.RelationValue > 0)
                {
                    relation.RelationShip.EmotionalState += RelationEmotionalChange;
                }
                else if (RelationEmotionalChange > 0 && relation.RelationValue < 0)
                {
                    relation.RelationShip.EmotionalState -= RelationEmotionalChange;
                }
            }
        }
    }
}
