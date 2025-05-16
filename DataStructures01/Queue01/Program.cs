using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;
using Infra;
using System.Threading;
using System.Xml.Linq;


namespace Queue01
{

    public class Chapter05
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic.Queue<string> s = new System.Collections.Generic.Queue<string>();
            // s.Enqueue("s");


            //Unit4.CollectionsLib.Queue<string> q = new Queue<string>();
            //q.Insert("tt");

            //Queue<int> queue = new Queue<int>();
            //queue.Insert(1);
            //queue.Insert(2);
            //queue.Insert(3);
            //queue.Insert(2);
            //Q03_RemoveDuplicate(queue);

            Queue<Student> queue2 = new Queue<Student>();
            queue2.Insert(new Student("A", 20));
            queue2.Insert(new Student("B", 21));
            queue2.Insert(new Student("C", 22));
            queue2.Insert(new Student("D", 23));
            queue2.Insert(new Student("G", 26));
            Console.WriteLine(queue2.ToString());
            Console.WriteLine("Remove student");
            UpdateAge(queue2, "D", 18);
            Console.WriteLine(queue2.ToString());
            //RemoveStudent1(queue2,"D"); 
            //Console.WriteLine(queue2);
            //while (!queue2.IsEmpty())
            //{
            //    Console.WriteLine(queue2.Remove().GetName());
            //}
            //Console.ReadKey();
            //Ins9ert(queue2, new Student("E", 25));


            //ChangeNameAndOrder(queue2, "C", "F");

            //RemoveStudent(queue2, "D");
            //ChangeName(queue2, "C", "F");


            //ChangeNameAndOrder(queue2, "C", "F");
            // Queue with student over 22

            //Queue<Job> q = new Queue<Job>();
            //q.Insert(new Job(1, 10));
            //q.Insert(new Job(2, 20));
            //q.Insert(new Job(3, 30));
            //q.Insert(new Job(4, 40));
            //q.Insert(new Job(5, 50));

            //DoJobsFor(q, 25);

            //Queue<int> q = new Queue<int>();
            //q.Insert(2);
            //q.Insert(3);
            //q.Insert(3);
            //q.Insert(4);
            //Console.WriteLine(q.ToString());
            //RemoveItem(q, 3);
            //Console.WriteLine("Remove ");
            //Console.WriteLine(q.ToString());
            ////Console.WriteLine($"IsExist:{ IsExistInSeq(q,3)}");
            Console.ReadKey();


        }

        public static void UpdateAge(Queue<Student> q, string name, int age)
        {
            // להוציא מתור
            // לעדכן את הגיל
            // להכניס למקום
            Student student = RemoveStudent(q, name);
            student.SetAge(age);
            InsertStudentByAge(q, student);


        }

        private static void InsertStudentByAge(Queue<Student> q, Student std)
        {
            Queue<Student> tmp = new Queue<Student>();
            while (!q.IsEmpty() && q.Head().GetAge() < std.GetAge())
            {
                tmp.Insert(q.Remove());
            }
            tmp.Insert(std);
            Copy(q, tmp);
            Copy(tmp, q);
        }

        private static void UpdateBTo25(Queue<Student> queue2)
        {
            
        }

        public static void RemoveItem(Queue<int> q, int num)
        {
        
            Queue<int> tmp = new Queue<int>();
            while (!q.IsEmpty())
            {
                if (q.Head() == num)
                {
                    q.Remove();
                }
                else
                {
                    tmp.Insert(q.Remove());
                }
            }
            Copy(tmp, q);

        }

        public static void DoJobsFor(Queue<Job> q, int seconds)
        {
            // תור זמני
            // לולאה על התור
            // אם הזמן של הסטודנט קטן מהזמן שנשאר
            // נוציא את העבודה



        }
        public static void Copy<T> (Queue<T> q1, Queue<T> q2)
        {
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Remove());
            }
        }
        public static void Insert(Queue<Student> q, Student student)
        {
            // תור זמני
            // העבר לתור את כל הקודמים או עד שהתור ריק
            // הכנס לתור את הסטודנט
            // מכניס את שאר התור
            // מעתיק מהתור הזמני

            Queue<Student> temp = new Queue<Student>();
            while (!q.IsEmpty() && string.Compare(q.Head().GetName(), student.GetName()) <= 0)
            {
                temp.Insert(q.Remove());
            }
            temp.Insert(student);

            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
            }

            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
        }

        

        private static void ChangeName(Queue<Student> q, string pre, string post)
        {
            // תור זמני
            // לולאה על האיבר
            //מחזירים מהתור
            Queue<Student> temp = new Queue<Student>();
            while (!q.IsEmpty())
            {
                Student current = q.Remove();
                if (current.GetName() == pre)
                {
                    current.SetName(post);
                }
                temp.Insert(current);
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
        }


        public static Student RemoveStudent(Queue<Student> q, string name)
        {
            // תור זמני
            // לולאה על התור
            // להכניס כל חוץ מי התלמיד
            // להחזיר ל
            Student student = null;

            Queue<Student> tmp = new Queue<Student>();

            while (!q.IsEmpty())
            {
                if (q.Head().GetName() == name)
                {
                    student =  q.Remove();
                }else
                {
                    tmp.Insert(q.Remove());
                }

                
            }
            Copy(tmp, q);

            return student;

        }
       

        public static void Q03_RemoveDuplicate(Queue<int> queue)
        {
            // יקח תור זמני
            // ישמור מספר בצד
            // אעבור על התור והסיר מהתור את המספר ששמרתי
            // אני למספר הבא

            Queue<int> temp = new Queue<int>();
            while (!queue.IsEmpty())
            {
                int current = queue.Remove();
                Remove(queue, current);
                temp.Insert(current);
            }
            while (!temp.IsEmpty())
            {
                queue.Insert(temp.Remove());
            }
        }
        public static void Remove(Queue<int> q, int num)
        {
            // ניצור תור עזר
            // נעבור על כל האיברים 
            // לפי התנאי נכניס איברים לתור
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                int current = q.Remove();
                if (current != num)
                {
                    temp.Insert(current);
                }
            }
        }
        public static bool Q02_Equal_It<T>(Queue<T> q1, Queue<T> q2)
        {
            if (q1 == null && q2 == null)
                return true;
            if (q1 == null || q2 == null)
                return false;

            if (q1.IsEmpty() && q2.IsEmpty())
                return true;

            if (q1.IsEmpty() || q2.IsEmpty())
                return false;

            Queue<T> tmp1 = Infra.QueueHelper.Clone(q1);
            Queue<T> tmp2 = Infra.QueueHelper.Clone(q2);


            while (!tmp1.IsEmpty() && !tmp2.IsEmpty())
            {
                T a1 = tmp1.Remove();
                T b2 = tmp2.Remove();
                if (!a1.Equals(b2))
                    return false;
            }

            if (tmp1.IsEmpty() && tmp2.IsEmpty())
                return true;
            return false;


        }

        public static bool Q02_Equal_BeforeRecursive<T>(Queue<T> q1, Queue<T> q2)
        {
            if (q1 == null && q2 == null)
                return true;
            if (q1 == null || q2 == null)
                return false;

            Queue<T> tmp1 = Infra.QueueHelper.Clone(q1);
            Queue<T> tmp2 = Infra.QueueHelper.Clone(q2);

            bool result = Q02_Equal_Rec(tmp1, tmp2);

            return result;
        }

        public static bool Q02_Equal_Rec<T>(Queue<T> q1, Queue<T> q2)
        {
            if (q1.IsEmpty() && q2.IsEmpty())
                return true;

            if (q1.IsEmpty() || q2.IsEmpty())
                return false;

            T a1 = q1.Remove();
            T b2 = q2.Remove();
            if (!a1.Equals(b2))
                return false;
            return Q02_Equal_Rec(q1, q2);
        }

        public static bool Q01_ExistSequence<T>(Queue<T> q, T item)
        {
            int count = 0;
            Queue<T> temp = new Queue<T>();

            while (!q.IsEmpty() && count < 2)
            {
                if (q.Head().Equals(item))
                {
                    count += 1;
                }
                else
                {
                    count = 0;
                }
                temp.Insert(q.Remove());
            }

            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
            }

            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }

            return count >= 2;
        }

        public static bool IsExistInSeq<T>(Queue<T> q, T item)
        {

            if (q.IsEmpty())
                return false;

            Queue<T> tmp = new Queue<T>();

            bool isEqual = false;

            T item2 = q.Remove();

            tmp.Insert(item2);


            while (!q.IsEmpty() && !isEqual)
            {
                T item3 = q.Remove();
                tmp.Insert(item3);

                if (item.Equals(item3) && item2.Equals(item3))
                {
                    isEqual = true;
                }
                item2 = item3;
                
            }
            while (!q.IsEmpty())
            {
                tmp.Insert(q.Remove());
            }
            while (!tmp.IsEmpty())
            {
                q.Insert(tmp.Remove());
            }
            return isEqual;

        }



























    }
}
