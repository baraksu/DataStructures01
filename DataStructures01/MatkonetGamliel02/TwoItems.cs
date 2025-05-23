
    namespace MatkonetGamliel02
    {
        public class TwoItems
        {
            public TwoItems(int min, int max)
            {
                this.min = min;
                this.max = max;
            }


            private int min;

            public int GetMin()
            {
                return this.min;
            }
            public void SetMin(int min)
            {
                this.min = min;
            }


            private int max;

            public int GetMax()
            {
                return this.max;
            }
            public void SetMax(int max)
            {
                this.max = max;
            }

        }
    }
