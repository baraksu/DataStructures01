namespace Queue01
{
    public class Job
    {
        public Job(int code, int seconds)
        {
            this.code = code;
            this.seconds = seconds;
        }
        private int code;

        public int GetCode()
        {
            return this.code;
        }
        public void SetCode(int code)
        {
            this.code = code;
        }

        private int seconds;

        public int GetSeconds()
        {
            return this.seconds;
        }
        public void SetSeconds(int seconds)
        {
            this.seconds = seconds;
        }

    }
}