namespace Queue01
{
    public class Student
    {
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
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

        private int age;

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name}:{age}";
        }
    }
}