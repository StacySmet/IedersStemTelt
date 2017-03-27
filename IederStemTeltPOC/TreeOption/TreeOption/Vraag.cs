using System;
using System.Collections.Generic;

namespace TreeOption
{
    public class Vraag
    {
        public int VraagId { get; set; }

        //kernteksten voor evt in cirkels weer te geven?
        public string VraagKernTekst { get; set; }

        public string VraagTekst { get; set; }
        public string VraagImageUrl { get; set; }

        public ICollection<Antwoord> Antwoorden { get; set; }
        public ICollection<Voorwaarde> Voorwaarden { get; set; }
        public bool IsStartVraag { get; internal set; }

        internal bool checkCondition(Voorwaarde condition)
        {
           
            foreach (Voorwaarde c in Voorwaarden)
            {
                if (c.Equals(condition))
                {
                    return true;
                }
            }
            return false;
        }
    }
    }
