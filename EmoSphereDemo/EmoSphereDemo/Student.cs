using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoSphereDemo
{
    public class Student
    {
        private string name;
        private double emotionalState;
        private double personality;
        private int chairIndex;
    
        private Relation[] relations;


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public double EmotionalState
        {
            get
            {
                return emotionalState;
            }
            set
            {
                if(value >= 1)
                {
                    emotionalState = 1;

                }
                else if(value <= -1)
                {
                    emotionalState = -1;
                }
                else
                {
                    emotionalState = value;
                }
            }
        }

        public double Personality
        {
            get
            {
                return personality;
            }

            set
            {
                personality = value;
            }
        }

        public Relation[] Relations
        {
            get
            {
                return relations;
            }

            set
            {
                relations = value;
            }
        }

        public int ChairIndex
        {
            get
            {
                return chairIndex;
            }

            set
            {
                chairIndex = value;
            }
        }

        public Student(string name, double emotion, double personality, int chairIndex)
        {
            this.Name = name;
            this.EmotionalState = emotion;
            this.Personality = personality;
            this.ChairIndex = chairIndex;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
