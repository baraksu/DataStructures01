using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Unit4.CollectionsLib;

namespace Ch03_AddRemoveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<Student> lsA =
                new Node<Student>(new Student("Avishay", 11),
                new Node<Student>(new Student("Barak", 51),
                new Node<Student>(new Student("Ori", 71),
                new Node<Student>(new Student("Tachshon", 80)))));
            Node<Student> lsB = new Node<Student>(new Student("Bair", 21));

            //PrintLists(lsA, lsB);

            //// write method which move Student by name.
            //string name = "Ori";
            //Student st = GetStudent(lsA, name);
            //lsA = RemoveStudent(lsA,st);
            //PrintLists(lsA, lsB);
            ////if (st != null)
            ////{
            //lsB = InsertSorted(lsB, st);
            PrintLists(lsA, lsB);


            int cita = 71;
            Student st1 = GetStudentByCita(lsA, cita);
            lsA = RemoveStudent(lsA, st1);
            lsB = InsertsortedByCita(lsB, st1);
            PrintLists(lsA, lsB);
            //}
            // move Ori
            // move Barak
            // move Avishai
            // move Nachson


            Console.ReadKey();
        }

        private static Node<Student> InsertsortedByCita(Node<Student> lsB, Student st1)
        {
            if (lsB == null)
            {
                return new Node<Student>(st1);
            }

            if (st1.GetCita() < lsB.GetValue().GetCita())
            {
                return new Node<Student>(st1, lsB);
            }
            Node<Student> pre = lsB;
            Node<Student> current = lsB.GetNext();
            while (current != null && st1.GetCita() < current.GetValue().GetCita())
            {
                pre = current;
                current = current.GetNext();
            }
            Node<Student> node = new Node<Student>(st1 , current);
            pre.SetNext(node);
            return lsB;
        }

        private static Student GetStudentByCita(Node<Student> lsA, int cita)
        {
            // here
            // פה
            Node<Student> current = lsA;;
            Student name1;
            // מתקדם עד לאיבר ברשימה למחיקה
            while (current != null && current.GetValue().GetCita() != cita)
            {
                current = current.GetNext();
            }
            if (current != null)
            {
                return current.GetValue();
            }
            return null;
        }

        private static Node<Student> InsertSorted(Node<Student> lsB, Student st)
        {
            if (lsB == null)
            {
                return new Node<Student>(st);
            }

            if (string.Compare(st.GetName(), lsB.GetValue().GetName()) == -1)
            {
                return new Node<Student>(st, lsB);
            }
            Node<Student> pre = lsB;
            Node<Student> current = lsB.GetNext();
            while(current!= null && string.Compare( st.GetName(), lsB.GetValue().GetName()) == 1)
            {
                pre = current;
                current = current.GetNext();
            }
            Node<Student> node = new Node<Student>(st, current);
            pre.SetNext(node);

            return lsB;
            
        }
       
       

        // טענת כניסה רשימה של סטודנטים וסטודנט שקיים ברשימה
        // מסיר את הסטודנט מהרשימה
        private static Node<Student> RemoveStudent(Node<Student> lsA, Student st)
        {
            // check the first
            if (lsA.GetValue() == st)
            {
                return lsA.GetNext();
            }
            Node<Student> pre = lsA;
            Node<Student> current = lsA.GetNext();

            while(current!= null && current.GetValue() != st)
            {
                pre = current;
                current = current.GetNext();
            }
            if (current != null)
            {
                // מצאתי את הסטודנט 
                pre.SetNext(current.GetNext());
            }
           
            return lsA;
        }


        public static Student GetStudent(Node<Student> lst, string name)
        {
            // הסטודנט הראשון
            // הסטודנט בהמשך
            
            Node<Student> current = lst;
            Student name1;
            // מתקדם עד לאיבר ברשימה למחיקה
            while (current != null && current.GetValue().GetName() != name)
            {
                current = current.GetNext();
            }
            if (current != null)
            {
                return current.GetValue();
            }
            return null;
        }

        public static Node<Student> InsertNum(Node<Student> lst1, Student name2)
        {
            //  Node<Student> result = lst1;
            ////  Node<Student> newNode = new Node<Student>(new Student(x, 1));
            //  Node<Student> current = lst1;
            //  Node<Student> prev = null;
            ////  Student name1 = GetStudent(Node < Student > lst1, string name2)
            //  while (current != null && current.GetValue().GetName() < name1)
            //  {
            //      prev = current;
            //      current = current.GetNext();
            //  }
            //  if (prev == null)
            //  {// הכנסת איבר ראשון
            //      newNode.SetNext(lst1);
            //      result = newNode;
            //  }
            //  else // הוספת איבר
            //  {
            //      prev.SetNext(newNode);
            //      newNode.SetNext(current);
            //  }
            return null;
        }
        private static void PrintLists(Node<Student> lsA, Node<Student> lsB)
        {
            Console.WriteLine("\n -- lsA --");
            NodeHelpter.PrintList(lsA);
            Console.WriteLine("\n -- lsB --");
            NodeHelpter.PrintList(lsB);
        }
    }

    internal class Cita
    {
    }
}
