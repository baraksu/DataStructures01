using Infra;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace ClassTest02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<char> lst = new Node<char>('a',
                new Node<char>('b',
                    new Node<char>('E',
                        new Node<char>('F',
                            new Node<char>('i',
                                new Node<char>('j'))))));

            Console.WriteLine("lst");
            NodeHelpter.PrintList(lst);
            Console.WriteLine("");
            Node<char> newList = ClassTest02Q01.GetMiddleChars(lst);
            Console.WriteLine("newLst");
            NodeHelpter.PrintList(newList);
            Console.ReadKey();

        }
    }
}
