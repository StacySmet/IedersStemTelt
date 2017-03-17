using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOption
{
    abstract class Node
    {
        public static ICollection<Vraag> questions { get; set; }
        public IList<Node> children { get; set; }
        public Node parrent { get; set; }
        public ICollection<Voorwaarde> conditions { get; set; }
        abstract public ICollection<Voorwaarde> getConditions();
        abstract public void grow();
        abstract public ICollection<int> getQuestionsGot();
        abstract public override String ToString();

    }

    class QuestionBranch : Node
    {
        public Vraag quest { get; private set; }
        public ICollection<int> QuestionsGot { get; set; }

        public QuestionBranch(Vraag quest, Node parrent)
        {
            this.quest = quest;
            this.parrent = parrent;
            children = new List<Node>();
            QuestionsGot = new List<int>();
            if (parrent != null)
            {
                QuestionsGot = parrent.getQuestionsGot();
            }
            QuestionsGot.Add(quest.VraagId);
            conditions = new List<Voorwaarde>();
            if (parrent != null)
            {
                conditions = parrent.getConditions();
            }
        }

        public override ICollection<Voorwaarde> getConditions()
        {
            if(parrent!=null)
            return parrent.getConditions();
            return new List<Voorwaarde>();
        }

        public override void grow()
        {
            foreach (Antwoord a in quest.Antwoorden)
            {
                foreach(Resultaat  r in a.Resultaten) // elke resultaat bij een vraag doorlopen
                {
                    
                        bool ok = true;
                        foreach (Voorwaarde c in r.Voorwaarden)
                        {

                            bool ok2 = false;
                            foreach (Voorwaarde c2 in conditions)
                            {
                                if (c.Equals(c2)) ok2 = true;
                            }
                            if (ok && !ok2)
                            {
                                ok = false;
                            }

                        }
                        if (ok)
                        {
                            Node b = new ResultBranch(r, this);
                            children.Add(b);
                        }
                    

                }

            }
foreach(Node b in children)
            {
                b.grow();
            }
            if (children.Count == 0)
            {
                Console.WriteLine(this.ToString());
            }
        }

        public override ICollection<int> getQuestionsGot()
        {
            return new List<int>(QuestionsGot);
        }

        public override string ToString()
        {
            if(parrent!=null)
            return parrent.ToString() + "Q" + this.quest.VraagId;
            return "Q" + this.quest.VraagId;
        }
    }

    class ResultBranch : Node
    {
        public Resultaat res { get; private set; }

        public ResultBranch(Resultaat r, Node parrent)
        {
            res = r;
            this.parrent = parrent;
            children = new List<Node>();
            conditions = new List<Voorwaarde>();
            conditions = parrent.getConditions();
            try
            {
                foreach (Voorwaarde c in conditions)
                {
                    if (r.ConditionSetter.EqualVar(c))
                    {
                        conditions.Remove(c);
                    }
                }
            }
            catch (Exception e) { };
            conditions.Add(r.ConditionSetter);
        }

        public override ICollection<Voorwaarde> getConditions()
        {
            return new List<Voorwaarde>(conditions);
        }

        public override void grow()
            
        {
            if (res.IsEindResultaat) { return; }
            foreach (Vraag q in questions)
            {
                if (!(getQuestionsGot().Contains(q.VraagId)))
                {
                    bool ok = true;
                    foreach (Voorwaarde c in q.Voorwaarden)
                    {
                        
                            bool ok2 = false;
                            foreach (Voorwaarde c2 in conditions)
                            {
                                if (c.Equals(c2)) ok2 = true;
                            }
                            if (ok && !ok2)
                            {
                                ok = false;
                            }
                        
                    }
                    if (ok)
                    {
                        Node b = new QuestionBranch(q, this);
                        children.Add(b);
                    }
                }
                
            }
            foreach (Node b in children)
            {
                b.grow();
            }
            if (children.Count == 0)
            {
                Console.WriteLine(this.ToString());
            }
        }

        public override ICollection<int> getQuestionsGot()
        {
            return parrent.getQuestionsGot();
        }

        public override string ToString()
        {
            return parrent.ToString() + "R" + this.res.ResultaatId;
        }
    }
}
