namespace Ch03_AddRemoveList
{
    public class Student
    {
        public Student(string name, int cita)
        {
            this.name = name;
            this.cita = cita;
        }

        private string name;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

      
        public override string ToString()
        {
            return $"[{name}:{cita}]";
        }

        private int cita;

        public int GetCita()
        {
            return this.cita;
        }
        public void SetCita(int cita)
        {
            this.cita = cita;
        }

    }
}