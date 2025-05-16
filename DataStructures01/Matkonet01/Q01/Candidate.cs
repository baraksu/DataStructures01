using Unit4.CollectionsLib;

namespace Matkonet01.Q01
{
    public class Candidate
    {


        private Node<Malshab> lst;

        public Node<Malshab> GetLst()
        {
            return this.lst;
        }
        public void SetLst(Node<Malshab> lst)
        {
            this.lst = lst;
        }
        public Node<Malshab> TopMotivated(int k)
        {
            Node<Malshab> r = new Node<Malshab>(null);
            Node<Malshab> current = r;
            for (int i = 0; i < k && lst!= null; i++)
            {
                var maxNode = GetMaxNode();
                RemoveNode(maxNode);
                maxNode.SetNext(null);
                current.SetNext(maxNode);
                current = current.GetNext();
            }
            return r.GetNext();
        }

        private void RemoveNode(Node<Malshab> maxNode)
        {

            if (lst == maxNode)
            {
                lst = lst.GetNext();
                return;
            }
            Node<Malshab> current = lst.GetNext();
            Node<Malshab> pre = lst;
            while(current != null)
            {
                if (current == maxNode)
                {
                    pre.SetNext(current.GetNext());
                    return;
                }
                pre = current;
                current = current.GetNext();
            }
        }

        private Node<Malshab> GetMaxNode()
        {
            if (lst == null)
                return null;
            Node<Malshab> maxNode = lst;
            Node<Malshab> current = lst.GetNext();

            while(current!= null)
            {
                if (current.GetValue().GetMotivation()> maxNode.GetValue().GetMotivation())
                {
                    maxNode = current;
                }
                current = current.GetNext();
            }
            return maxNode;

        }

    }
}