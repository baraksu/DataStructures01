using System;
using Unit4.CollectionsLib;

namespace Matkonet02.Q2
{
    public class Box
    {
        Node<Item> lst;
        Node<Item> last;

        public Box(int capacity)
        {
            this.capacity = capacity;
        }

        private int capacity;

        public int GetCapacity()
        {
            return this.capacity;
        }
        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }
        public void AddItem(Item item)
        {
            if (lst == null)
            {
                lst = new Node<Item>(item);
                last = lst;
            }
            else
            {
                last.SetNext(new Node<Item>(item));
                last = last.GetNext();
            }

        }
        
        public override string ToString()
        {
            string str = "Box:10 {";

            Node<Item> current = lst;
            while(current!= null)
            {
                str += $"[{current.GetValue().GetSize()}]";
                current = current.GetNext();
            }
            str += "}";
            return str;
        }

    }
}