namespace Matkonet02.Q2
{
    public class Item
    {
        public Item(int size)
        {
            this.size = size;
        }

        private int size;

        public int GetSize()
        {
            return this.size;
        }
        public void SetSize(int size)
        {
            this.size = size;
        }

        public override string ToString()
        {
            return $"[{size}]";
        }

    }
}