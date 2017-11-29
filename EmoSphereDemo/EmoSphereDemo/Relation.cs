namespace EmoSphereDemo
{
    public class Relation
    {
        private Student relationShip;
        private double relationValue;


        public Student RelationShip
        {
            get
            {
                return relationShip;
            }

            set
            {
                relationShip = value;
            }
        }
        public double RelationValue
        {
            get
            {
                return relationValue;
            }

            set
            {
                relationValue = value;
            }
        }


        public Relation(Student relationShip, double relationValue)
        {
            this.relationShip = relationShip;
            this.relationValue = relationValue;
        }
    }
}