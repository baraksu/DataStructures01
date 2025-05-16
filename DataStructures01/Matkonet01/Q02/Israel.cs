using Infra;
using Unit4.CollectionsLib;

namespace Matkonet01.Q02
{
    public class Israel 
    {
        private Queue<Area> q;

        public Queue<Area> GetQ()
        {
            return this.q;
        }
        public void SetQ(Queue<Area> q)
        {
            this.q = q;
        }

        public void UpdateYeshivaPriority(int x, int y)
        {
            // take Yeshiva out if needed
            // Add Yeshiva
            Area yeshiva = GetYeshivaIfHit(x, y);
            if (yeshiva != null)
            {
                yeshiva.SetPriority(0.75f);
                AddYeshivaToQueue(yeshiva);
            }

        }

        private void AddYeshivaToQueue(Area yeshiva)
        {
            Queue<Area> tmp = new Queue<Area>();

            while (!this.q.IsEmpty() && q.Head().GetPriority()>= yeshiva.GetPriority())
            {
                tmp.Insert(q.Remove());
            }

            tmp.Insert(yeshiva);
            QueueHelper.Copy(this.q, tmp);
            QueueHelper.Copy(tmp, this.q);
        }

        public Area GetYeshivaIfHit (int x, int y)
        {
            Queue<Area> tmp = new Queue<Area>();
            Area yeshiva = null;
            while (!q.IsEmpty())
            {
                if (q.Head().GetDescription()== "yeshiva" &&
                    q.Head().GetPolygon().IsInside(x,y)
                    )
                {
                    yeshiva = q.Head();
                    q.Remove();
                }
                else
                {
                    tmp.Insert(q.Remove());
                }
                
            }
            QueueHelper.Copy(tmp, this.q);
            return yeshiva;
        }


    }
}