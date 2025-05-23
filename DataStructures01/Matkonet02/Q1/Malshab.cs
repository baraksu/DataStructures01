namespace Matkonet02.Q1
{
    public class Malshab
    {

        public Malshab(int id, double motivation)
        {
            this.id = id;
            this.motivation = motivation;
        }
        private int id;

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        private double motivation;

        public double GetMotivation()
        {
            return this.motivation;
        }
        public void SetMotivation(double motivation)
        {
            this.motivation = motivation;
        }

        public override string ToString()
        {
            return $"[{id}:{motivation}]";
        }
    }
}