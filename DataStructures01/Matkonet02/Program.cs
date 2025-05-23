using System;
using Matkonet02.Q1;
using Matkonet02.Q2;
using Unit4.CollectionsLib;


namespace Matkonet02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gibus g = new Gibus(1, null);
            Gibus g2 = new Gibus(2,
                new Node<Malshab>(new Malshab(20, 0.9),
                new Node<Malshab>(new Malshab(21, 0.8),
                new Node<Malshab>(new Malshab(22, 0.7),
                new Node<Malshab>(new Malshab(23, 0.6))))));

            Node<Gibus> lst = new Node<Gibus>(g,
                new Node<Gibus>(g2));

            Console.WriteLine("G2 lst");
            Infra.NodeHelpter.PrintList(g2.GetLst());

            AddMalshab(lst, 2, new Malshab(99, 0.99));
            AddMalshab(lst, 2, new Malshab(88, 0.88));
            AddMalshab(lst, 2, new Malshab(50, 0.5));

            // PRINT G2 LST 

            Console.WriteLine();
            Infra.NodeHelpter.PrintList(g2.GetLst());
            Console.WriteLine();

            //Queue<Box> qBoxes = new Queue<Box>();
            //qBoxes.Insert(new Box(10));
            //qBoxes.Insert(new Box(10));
            //qBoxes.Insert(new Box(10));
            //qBoxes.Insert(new Box(10));

            //Queue<Item> qItems = new Queue<Item>();
            //qItems.Insert(new Item(8));
            //qItems.Insert(new Item(7));
            //qItems.Insert(new Item(7));
            //qItems.Insert(new Item(4));
            //qItems.Insert(new Item(4));
            //qItems.Insert(new Item(2));
            //qItems.Insert(new Item(1));

            //FillBoxes(qBoxes, qItems);

            //PrintQBoxes(qBoxes);

            Console.ReadKey();
        }

        private static void PrintQBoxes(Queue<Box> qBoxes)
        {
            while (!qBoxes.IsEmpty())
            {
                var box = qBoxes.Remove();
                Console.WriteLine(box);
            }
        }


        public static void FillBoxes(Queue<Box> boxes, Queue<Item> items)
        {
            // get box
            // fill the box with items
            Queue<Box> tmpBoxes = new Queue<Box>();

            while (!boxes.IsEmpty())
            {
                Box box = boxes.Remove();

                AddItemsToBox(box, items);

                tmpBoxes.Insert(box);
            }
            while (!tmpBoxes.IsEmpty())
            {
                boxes.Insert(tmpBoxes.Remove());
            }
        }

        private static void AddItemsToBox(Box box, Queue<Item> items)
        {
            int capacity = box.GetCapacity();
            Queue<Item> tmpItems = new Queue<Item>();
            while (!items.IsEmpty())
            {
                Item item = items.Remove();

                if (capacity >= item.GetSize())
                {
                    box.AddItem(item);
                    capacity -= item.GetSize();
                }
                else
                {
                    tmpItems.Insert(item);
                }
            }
            while (!tmpItems.IsEmpty())
            {
                items.Insert(tmpItems.Remove());
            }
        }

        public static void AddMalshab(Node<Gibus> gLst,
            int gid,
            Malshab m)
        {
            // Get Gibus
            // Add Malshab

            Gibus g = GetGibus(gLst, gid);
            AddMalshabToGibus(g, m);
        }

        private static void AddMalshabToGibus(Gibus g, Malshab m)
        {
            // הרשימה ריקה
            // המלשב הראשון
            // המשלשב בהמשך

            Node<Malshab> malshabNode = new Node<Malshab>(m);

            if (g.GetLst() == null)
            {
                g.SetLst(malshabNode);
            }
            else if (g.GetLst().GetValue().GetMotivation() < m.GetMotivation())
            {
                malshabNode.SetNext(g.GetLst());
                g.SetLst(malshabNode);
            }
            else
            {
                Node<Malshab> pre = g.GetLst();
                Node<Malshab> current = pre.GetNext();

                while (current != null &&
                    current.GetValue().GetMotivation() > m.GetMotivation())
                {
                    pre = current;
                    current = current.GetNext();
                }
                pre.SetNext(malshabNode);
                malshabNode.SetNext(current);
            }

        }

        // מקבל רשימה לא ריקה ומחזיר גיבוש שקיים ברשימה
        private static Gibus GetGibus(Node<Gibus> gLst, int gid)
        {
            Node<Gibus> current = gLst;
            while (current != null)
            {
                if (current.GetValue().GetGId() == gid)
                {
                    return current.GetValue();
                }
                current = current.GetNext();
            }
            return null;
        }
    }
}
