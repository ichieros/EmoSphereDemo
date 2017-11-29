using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoSphereDemo
{
    public class Classroom
    {
        public Student[] students;
        public Action lastAction;
        public int clock;

        public Classroom()
        {
            students = new Student[4];

            students[0] = new Student("Alice", 0.1, 0.4, 9);
            students[1] = new Student("Betty", -0.9, -0.6, 10);
            students[2] = new Student("Carly", 0.2, -0.2, 15);
            students[3] = new Student("Dana", -0.3, 0.7, 16);

            students[0].Relations = new Relation[] { new Relation(students[1], 0.7), new Relation(students[2], -0.5), new Relation(students[3],  0)};
            students[1].Relations = new Relation[] { new Relation(students[2], -0.8), new Relation(students[3], -0.6), new Relation(students[0], -0.2) };
            students[2].Relations = new Relation[] { new Relation(students[3], 0.6), new Relation(students[0], 0.7), new Relation(students[1],  -0.1) };
            students[3].Relations = new Relation[] { new Relation(students[0], 0.2), new Relation(students[1], -0.1), new Relation(students[2],  -0.2) };

        }

        public void PassTime()
        {
            if(clock == 59)
            {
                //TODO: Game over
            }
            else
            {                
                clock++;
                //TODO: change time based stats
                Random rndm = new Random();
                Student baseStudent = students[rndm.Next(4)];
                Student targetStudent;

                do
                {
                    targetStudent = students[rndm.Next(4)];
                }
                while (targetStudent == baseStudent);


                Action action = new Action(rndm.NextDouble(), rndm.NextDouble(), rndm.NextDouble());
                action.PerformAction(baseStudent, students, targetStudent);
                lastAction = action;
            }
        }

        public void performTEacherAction(Student target, bool positive)
        {
            if (positive)
            {
                target.EmotionalState += 0.1;
            }
            else
            {
                target.EmotionalState -= 0.1;
            }
        }
    }
}
