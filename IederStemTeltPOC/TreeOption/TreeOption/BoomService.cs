using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOption
{
    static class BoomService
    {
        private static List<QuestionBranch> Trees;
        
        public static void init(ICollection<Vraag> vragen) // genereert alle moeglijke paden volgens de opgegeven vragen.
        {
            Trees = new List<QuestionBranch>();
            Node.questions = vragen;
            foreach(Vraag v in vragen)
            {
                if (v.IsStartVraag) // elk startpunt bepalen
                {
                    Trees.Add(new QuestionBranch(v, null));
                }
                
            }
            foreach(Node n in Trees) // elke boom opbouwen
            {
                n.grow();
            }
        }

        public static Vraag getNextQuestion(List<int> order)  // geeft een volgende vraag, order is de volgorde van vragen/resultaten die al gekregen zijn
        {
            Node n = Trees.Where(start => start.quest.VraagId == order[0]).First(); // bepalen start
            order.RemoveAt(0);
            foreach (int i in order)
            {
                n = getNextChild(n, i); // boom doorlopen volgen order
            }

            if (n.GetType() == typeof(ResultBranch)) // bepalen of het verkregen object een Resultaat bevat
            {
                ResultBranch rb = (ResultBranch)n; //cast
                if (rb.res.IsEindResultaat) // bepalen of je wint/vertliest/nog een vraag krijgt
                {
                    Console.WriteLine("You Lose!");
                    return null; }
                if (rb.children.Count > 0)
                {
                    int i = new Random().Next(rb.children.Count);
                    QuestionBranch qb = (QuestionBranch)rb.children[i];
                    return qb.quest;
                }
                Console.WriteLine("You Won!");
            }
            return null;
        }

        private static Node getNextChild(Node n, int next) // haalt het juiste kind uit de node
        {
            return n.children.Where(child => {
                if (child.GetType() == typeof(QuestionBranch)){
                    QuestionBranch qb = (QuestionBranch) child;
                    return qb.quest.VraagId == next;
                }
                else if (child.GetType() == typeof(ResultBranch))
                {
                    ResultBranch rb = (ResultBranch)child;
                    return rb.res.ResultaatId == next;
                }
                return false;
            }).First();
        }

        public static Vraag getStart() // kiest random start
        {
            int i = new Random().Next(Trees.Count);
            return Trees[i].quest;
        }
    }
}
