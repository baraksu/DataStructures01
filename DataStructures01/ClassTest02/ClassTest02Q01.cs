using Unit4.CollectionsLib;

namespace ClassTest02
{
    public class ClassTest02Q01
    {
        public static Node<char> GetMiddleChars(Node<char> lst)
        {
            Node<char> toMiddle = lst;
            Node<char> toEnd = lst.GetNext();

            while (toEnd.GetNext() != null)
            {
                toEnd = toEnd.GetNext().GetNext();
                toMiddle = toMiddle.GetNext();
            }
            return new Node<char>(toMiddle.GetValue(),
                new Node<char>(toMiddle.GetNext().GetValue()));
        }
    }
}