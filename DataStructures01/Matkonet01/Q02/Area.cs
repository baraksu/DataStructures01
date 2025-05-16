using System.IO;

namespace Matkonet01.Q02
{
    public class Area
    {
        public Area(string description, float priority)
        {
            this.description = description;
            this.priority = priority;
            this.polygon = new Polygon();

        }
        private Polygon polygon;

        public Polygon GetPolygon()
        {
            return this.polygon;
        }
        public void SetPolygon(Polygon polygon)
        {
            this.polygon = polygon;
        }


        private float priority;

        public float GetPriority()
        {
            return this.priority;
        }
        public void SetPriority(float priority)
        {
            this.priority = priority;
        }

        private string description;

        public string GetDescription()
        {
            return this.description;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public override string ToString()
        {
            return $"[{this.priority}:{this.description}]";
        }

    }
}
