using System.Xml;
using Unit4.CollectionsLib;

namespace Matkonet02.Q1
{
    public class Gibus
    {
        public Gibus(int gid, Node<Malshab> lst)
        {
            this.gid  = gid ;
            this.lst = lst;
        }

        private Node<Malshab> lst;

        public Node<Malshab> GetLst()
        {
            return this.lst;
        }
        public void SetLst(Node<Malshab> lst)
        {
            this.lst = lst;
        }



        private int gid;

        public int GetGId()
        {
            return this.gid;
        }
        public void SetGId(int gId)
        {
            this.gid = gId;
        }

    }
}