using System;

namespace Infra
{   
    /*

    public class Node<T>
    {
        private T info;
        private Node<T> next;

        public Node(T x)
        {
            this.info = x;
            this.next = (Node<T>)null;
        }

        public Node(T x, Node<T> next)
        {
            this.info = x;
            this.next = next;
        }

        public T GetValue() => this.info;

        public void SetValue(T x) => this.info = x;

        public Node<T> GetNext() => this.next;

        public void SetNext(Node<T> next) => this.next = next;

        public bool HasNext() => this.next != null;

        public override string ToString() => this.info.ToString();
    }
 
    public class Queue<T>
    {
        private Node<T> first;
        private Node<T> lastPos;

        public Queue()
        {
            this.lastPos = (Node<T>)null;
            this.first = (Node<T>)null;
        }

        public bool IsEmpty() => this.first == null;

        public void Insert(T x)
        {
            if (this.first == null)
            {
                this.first = new Node<T>(x);
                this.lastPos = this.first;
            }
            else
            {
                this.lastPos.SetNext(new Node<T>(x));
                this.lastPos = this.lastPos.GetNext();
            }
        }

        public T Remove()
        {
            T obj = this.first.GetValue();
            Node<T> first = this.first;
            this.first = this.first.GetNext();
            if (this.first == null)
                this.lastPos = (Node<T>)null;
            first.SetNext((Node<T>)null);
            return obj;
        }

        public T Head() => this.first.GetValue();

        public override string ToString()
        {
            Node<T> node = this.first;
            string str = "[";
            for (; node != null; node = node.GetNext())
            {
                str += node.GetValue().ToString();
                if (node.GetNext() != null)
                    str += ",";
            }
            return str + "]";
        }
    }
    */
}