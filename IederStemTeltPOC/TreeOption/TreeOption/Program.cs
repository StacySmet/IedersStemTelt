using System;
using System.Collections.Generic;
using System.Threading;

namespace TreeOption
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Voorwaarde> cond = new List<Voorwaarde>();
            List<Vraag> vragen = new List<Vraag>();
            List<Antwoord> antwoorden = new List<Antwoord>();
            List<Resultaat> resultaten = new List<Resultaat>();
            List<Voorwaarde> voorwaarden = new List<Voorwaarde>();
            //List<Branch> tree = new List<Branch>();
            //for(int i = 0; i < 6; i++)
            //{
            //    cond.Add(new Condition((i % 3).ToString(), i.ToString()));
            //}
            //int vraagId = 0;
            //int antwId = 0;
            //int resultId = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Question q = new Question();
            //    q.VraagId = vraagId++;
            //    q.Antwoorden = new List<Antwoord>();
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Antwoord a = new Antwoord();
            //        a.AntwoordId = antwId++;
            //        a.Vraag = q;
            //        a.results = new List<Result>();
            //        Thread.Sleep(50);
            //        int k2 = new Random().Next(1, 5);
            //        for (int k = 0; k < k2; k++)
            //        {
            //            Result r = new Result();
            //            r.ResultaatId = resultId++;
            //            r.Voorwaarden = new List<Condition>();
            //            Thread.Sleep(50);
            //            int l2 = new Random().Next( 3);
            //            for (int l = 0; l < l2; l++)
            //            {
            //                Thread.Sleep(50);
            //                int condran = new Random().Next(cond.Count);
            //                r.Voorwaarden.Add(cond[condran]);
            //            }
            //            Thread.Sleep(50);
            //            r.ConditionSetter = cond[new Random().Next(cond.Count)];
            //            a.results.Add(r);
            //        }
            //        q.Antwoorden.Add(a);
            //    }
            //    q.Voorwaarden = new List<Condition>();
            //    if (q.VraagId != 0)
            //    {
            //        Thread.Sleep(50);
            //        int l3 = new Random().Next(1, 3);
            //        for (int l = 0; l < l3; l++)
            //        {
            //            Thread.Sleep(50);
            //            int condran = new Random().Next(cond.Count);
            //            q.Voorwaarden.Add(cond[condran]);
            //        }
            //    }
            //    quests.Add(q);
            //}




            //Persona: Vraag met 2 antwoorden
            Vraag t1v1 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<Voorwaarde>(),
                VraagTekst = "Heb je kinderen of niet?",
                VraagKernTekst = "Kinderen?",
                VraagImageUrl = "someVraagImgUrl",
                IsStartVraag = true
            };
            vragen.Add(t1v1);

            Antwoord t1v1a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "Kinderen",
                AntwoordTekst = "ik leg de keuzetest af als iemand met kinderen",
                Vraag = t1v1,
                Resultaten = new List<Resultaat>()
            };
            t1v1.Antwoorden.Add(t1v1a1);
            antwoorden.Add(t1v1a1);

            Resultaat t1v1a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t1v1a1,
                Kans = 100,
                ResultaatTekst = "kinderen",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("gezinssamenstelling", "kinderen")
            };
            t1v1a1.Resultaten.Add(t1v1a1r1);
            resultaten.Add(t1v1a1r1);

            Antwoord t1v1a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "Geen Kinderen",
                AntwoordTekst = "ik leg de keuzetest af als iemand zonder kinderen",
                Vraag = t1v1,
                Resultaten = new List<Resultaat>()
            };
            t1v1.Antwoorden.Add(t1v1a2);
            antwoorden.Add(t1v1a2);

            Resultaat t1v1a2r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t1v1a2,
                Kans = 100,
                ResultaatTekst = "geen kinderen",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("gezinssamenstelling", "geen kinderen")
            };
            t1v1a2.Resultaten.Add(t1v1a2r1);
            resultaten.Add(t1v1a2r1);

            //Persona: Vraag met 2 antwoorden
            Vraag t1v2 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<Voorwaarde>(),
                VraagTekst = "Hebben je ouders of grootouders een andere nationaliteit dan de belgische?",
                VraagKernTekst = "afkomst?",
                VraagImageUrl = "someVraagImgUrl",
                IsStartVraag = true
            };
            vragen.Add(t1v2);

            Antwoord t1v2a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "belgisch",
                AntwoordTekst = "ik leg de keuzetest af als iemand met volledig belgische achtergrond",
                Vraag = t1v2,
                Resultaten = new List<Resultaat>()
            };
            t1v2.Antwoorden.Add(t1v2a1);
            antwoorden.Add(t1v2a1);

            Resultaat t1v2a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t1v2a1,
                Kans = 100,
                ResultaatTekst = "belgisch",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("afkomst", "belgisch")
            };
            t1v2a1.Resultaten.Add(t1v2a1r1);
            resultaten.Add(t1v2a1r1);

            Antwoord t1v2a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "andere",
                AntwoordTekst = "ik leg de keuzetest af als iemand met migratieachtergrond",
                Vraag = t1v2,
                Resultaten = new List<Resultaat>()
            };
            t1v2.Antwoorden.Add(t1v2a2);
            antwoorden.Add(t1v2a2);

            Resultaat t1v2a2r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t1v2a2,
                Kans = 100,
                ResultaatTekst = "migratie",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("afkomst", "migratie")
            };
            t1v2a2.Resultaten.Add(t1v2a2r1);
            resultaten.Add(t1v2a2r1);


            //Werk: Vraag met 2 KeuzeAntwoorden
            Vraag t2v1 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<Voorwaarde>(),
                VraagTekst = "Je krijgt een werkloosheidsuikering en je jonge kinderen zijn thuis. Ga je op zoek naar kinderopvang voor je kinderen en zoek je een baan of wacht je tot ze wat groter zijn ? ",
                VraagKernTekst = "kinderopvang?",
                VraagImageUrl = "someVraagImgUrl",
                IsStartVraag = false
            };
            vragen.Add(t2v1);

            Voorwaarde t2v1vw1 = new Voorwaarde("gezinssamenstelling", "kinderen");
            t2v1.Voorwaarden.Add(t2v1vw1);

            Antwoord t2v1a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "kinderopvang",
                AntwoordTekst = "IK ZOEK EEN CRECHE EN WERK",
                Vraag = t2v1,
                Resultaten = new List<Resultaat>()
            };
            t2v1.Antwoorden.Add(t2v1a1);
            antwoorden.Add(t2v1a1);

            Resultaat t2v1a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v1a1,
                Kans = 100,
                ResultaatTekst = "Je hebt het contract aangenomen en je hebt een job.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "zoekend")
            };
            t2v1a1.Resultaten.Add(t2v1a1r1);
            resultaten.Add(t2v1a1r1);

            Antwoord t2v1a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "geen kinderopvang",
                AntwoordTekst = "IK WACHT TOT DE KINDEREN GROTER ZIJN VOOR IK WERK ZOEK",
                Vraag = t2v1,
                Resultaten = new List<Resultaat>()
            };
            t2v1.Antwoorden.Add(t2v1a2);
            antwoorden.Add(t2v1a2);

            Resultaat t2v1a2r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v1a2,
                Kans = 100,
                ResultaatTekst = "Je kiest ervoor thuis te blijven en je kinderen zelf op te vangen",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v1a2.Resultaten.Add(t2v1a2r1);
            resultaten.Add(t2v1a2r1);


            //Werk: Vraag met 2 KeuzeAntwoorden
            Vraag t2v2 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<Voorwaarde>(),
                VraagTekst = "Je hebt een stage gedaan via de VDAB in een restaurant in de keuken. Je krijgt een tijdelijk contract aangeboden aan het minimumloon.",
                VraagKernTekst = "werken aan minimumloon?",
                VraagImageUrl = "someVraagImgUrl",
                IsStartVraag = false
            };
            vragen.Add(t2v2);

            Voorwaarde t2v2vw1 = new Voorwaarde("gezinssamenstelling", "kinderen");
            t2v2.Voorwaarden.Add(t2v2vw1);

            Voorwaarde t2v2vw2 = new Voorwaarde("afkomst", "belgisch");
            t2v2.Voorwaarden.Add(t2v2vw2);

            Voorwaarde t2v2vw3 = new Voorwaarde("werk", "zoekend");
            t2v2.Voorwaarden.Add(t2v2vw3);

            Antwoord t2v2a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "aannemen",
                AntwoordTekst = "IK NEEM HET CONTRACT AAN",
                Vraag = t2v2,
                Resultaten = new List<Resultaat>()
            };
            t2v2.Antwoorden.Add(t2v2a1);
            antwoorden.Add(t2v2a1);

            Resultaat t2v2a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a1,
                Kans = 70,
                ResultaatTekst = "Je hebt het contract aangenomen en je hebt een job. Het zijn lange dagen, maar je bent tevreden dat je ervaring opbouwt.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "aangenomen")
            };
            t2v2a1.Resultaten.Add(t2v2a1r1);
            resultaten.Add(t2v2a1r1);

            Resultaat t2v2a1r2 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a1,
                Kans = 20,
                ResultaatTekst = "Je hebt het contract aangenomen, wanneer de subsidies stoppen wordt je onmiddellijk ontslagen.Je hebt geen job.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v2a1.Resultaten.Add(t2v2a1r2);
            resultaten.Add(t2v2a1r2);

            Resultaat t2v2a1r3 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a1,
                Kans = 10,
                ResultaatTekst = "Je hebt het contract aangenomen. Je koopt een wagen met je spaargeld, maar wordt opgelicht.Je geraakt niet op je werk en hebt hoge schulden.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v2a1.Resultaten.Add(t2v2a1r3);
            resultaten.Add(t2v2a1r3);

            Antwoord t2v2a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "niet aannemen",
                AntwoordTekst = "IK WACHT OP EEN INTERESSANTER AANBOD",
                Vraag = t2v2,
                Resultaten = new List<Resultaat>()
            };
            t2v2.Antwoorden.Add(t2v2a2);
            antwoorden.Add(t2v2a2);


            Resultaat t2v2a2r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a2,
                Kans = 100,
                ResultaatTekst = "jen neemt het contract niet aan en wacht op een beter aanbod. je hebt geen werk",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v2a2.Resultaten.Add(t2v2a2r1);
            resultaten.Add(t2v2a2r1);




            //Werk: Vraag met 2 KeuzeAntwoorden
            Vraag t2v3 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<Voorwaarde>(),
                VraagTekst = "Je hebt een stage gedaan via de VDAB in een restaurant in de keuken. Je krijgt een tijdelijk contract aangeboden aan het minimumloon. Je moet wel je hoofddoek afzetten tijdens het werk.",
                VraagKernTekst = "werken aan minimumloon?",
                VraagImageUrl = "someVraagImgUrl",
                IsStartVraag = false
            };
            vragen.Add(t2v3);

            Voorwaarde t2v3vw1 = new Voorwaarde("gezinssamenstelling", "geen kinderen");
            t2v3.Voorwaarden.Add(t2v3vw1);

            Voorwaarde t2v3vw2 = new Voorwaarde("afkomst", "migratie");
            t2v3.Voorwaarden.Add(t2v3vw2);


            Antwoord t2v3a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "aannemen",
                AntwoordTekst = "IK NEEM HET CONTRACT AAN",
                Vraag = t2v3,
                Resultaten = new List<Resultaat>()
            };
            t2v3.Antwoorden.Add(t2v3a1);
            antwoorden.Add(t2v3a1);

            Resultaat t2v3a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a1,
                Kans = 70,
                ResultaatTekst = "Je hebt het contract aangenomen en je hebt een job. Het zijn lange dagen, maar je bent tevreden dat je ervaring opbouwt.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "aangenomen")
            };
            t2v3a1.Resultaten.Add(t2v3a1r1);
            resultaten.Add(t2v3a1r1);

            Resultaat t2v3a1r2 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a1,
                Kans = 20,
                ResultaatTekst = "Je hebt het contract aangenomen, wanneer de subsidies stoppen word je onmiddellijk ontslagen.Ze zeggen dat het niets met je huidskleur te maken heeft, maar je hebt het gevoel dat dat toch wel meespeelt.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v3a1.Resultaten.Add(t2v3a1r2);
            resultaten.Add(t2v3a1r2);

            Resultaat t2v3a1r3 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a1,
                Kans = 10,
                ResultaatTekst = "Je hebt het contract aangenomen. Je koopt een wagen met je spaargeld, maar wordt opgelicht.Je geraakt niet op je werk en hebt hoge schulden.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = false,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v3a1.Resultaten.Add(t2v3a1r3);
            resultaten.Add(t2v3a1r3);

            Antwoord t2v3a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "niet aannemen",
                AntwoordTekst = "IK WACHT OP EEN INTERESSANTER AANBOD",
                Vraag = t2v3,
                Resultaten = new List<Resultaat>()
            };
            t2v3.Antwoorden.Add(t2v3a2);
            antwoorden.Add(t2v3a2);

            Resultaat t2v3a2r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a2,
                Kans = 100,
                ResultaatTekst = "je neemt het contract niet aan en wacht op een beter aanbod. je hebt geen werk",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<Voorwaarde>(),
                IsEindResultaat = true,
                ConditionSetter = new Voorwaarde("werk", "werkloos")
            };
            t2v3a2.Resultaten.Add(t2v3a2r1);
            resultaten.Add(t2v3a2r1);


            Node.questions = vragen;
            foreach (Vraag q in vragen)
            {
                Console.WriteLine(q.VraagTekst);
                foreach (Antwoord a in q.Antwoorden)
                {
                    Console.WriteLine("\t"+a.AntwoordTekst);
                    foreach (Resultaat r in a.Resultaten)
                    {
                        //Console.WriteLine("\t\t" + r.ResultaatId+"\t"+ r.ConditionSetter.var+":"+r.ConditionSetter.val);
                        foreach (Voorwaarde c in r.Voorwaarden) 
                        {
                            Console.WriteLine("\t\t\t" + c.var + ": " + c.val);
                        }
                    }
                }
                foreach (Voorwaarde c in q.Voorwaarden)
                {
                    Console.WriteLine("\t" + c.var + ": " + c.val);
                }
            } 
           /* QuestionBranch b = new QuestionBranch(vragen[0], null);
            b.grow();*/
            Console.Write("DONE\n");

            List<int> order = new List<int>(); // volgorde van vragen/resultaten
            BoomService.init(vragen); // genereer bomen
            Vraag current = BoomService.getStart(); // random start

            while (current != null) // zolang er nog een vraag is
            {
                order.Add(current.VraagId); // vraag toevoegen aan volgorde
                Console.WriteLine(current.VraagTekst);
                foreach (Antwoord a in current.Antwoorden)
                {
                    Console.WriteLine("Antwoord " + a.AntwoordId + " " + a.AntwoordTekst);
                }

                //keuze inlezen 
                // TODO: keuze controle
                string keuze = Console.ReadLine();
                Antwoord antwoord=null; // recursief antwoord vinden
                foreach (Antwoord a in current.Antwoorden)
                {
                    if (a.AntwoordId.ToString().Equals(keuze))
                    {
                        antwoord = a;
                    }
                }

                Resultaat result = null;
                int resultaat = new Random().Next(100);
                

                for(int i=0; i<antwoord.Resultaten.Count&&resultaat>0; i++) // resultaat kans bepalen
                {
                    resultaat -= antwoord.Resultaten[i].Kans;
                    result = antwoord.Resultaten[i];
                }
                order.Add(result.ResultaatId);
                Console.WriteLine(result.ResultaatTekst);
                /* try
                  {
                      foreach (Node bra in current.children)
                      {
                          ResultBranch rb = (ResultBranch)bra;
                          if (rb.res.ResultaatId == result.ResultaatId)
                          {
                              int randomvraag = new Random().Next(rb.children.Count);
                              current = (QuestionBranch)rb.children[randomvraag];
                          }
                      }

                  }catch(Exception e) {                    current = null;
   }*/
                current = BoomService.getNextQuestion(new List<int>(order)); // zet current als volgende vraag als die er is/ anders null.
            }


            
            Console.ReadLine();
        }
    }

}
