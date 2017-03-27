using IST.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IST.BL.Domain;

namespace IST.BL
{
    public class VraagManager : IVraagManager
    {
        private readonly IVraagRepository repo;

        public VraagManager()
        {
            repo = new VraagRepositoryHC();
        }

        public Resultaat AddResultaat(int resultaatId, string resultaatTekst, string resultaatImageUrl, short kans, Antwoord antwoord, ICollection<ResultaatVoorwaarde> voorwaarden)
        {
            Resultaat r = new Resultaat()
            {
                ResultaatId = resultaatId,
                ResultaatTekst = resultaatTekst,
                ResultaatImageUrl = resultaatImageUrl,
                Kans = kans,
                Antwoord = antwoord,
                Voorwaarden = voorwaarden
            };

            return repo.CreateResultaat(r);
        }

        public Thema AddThema(int themaId, string themaNaam, string themaTekst, string themaImageUrl, ICollection<Vraag> vragen, ICollection<PartijStandpunt> standpunten)
        {
            Thema t = new Thema()
            {
                ThemaId = themaId,
                ThemaNaam = themaNaam,
                ThemaTekst = themaNaam,
                ThemaImageUrl = themaImageUrl,
                Vragen = vragen,
                Standpunten = standpunten
            };

            return repo.CreateThema(t);
        }

        public Vraag AddVraag(int vraagId, string vraagKernTekst, string vraagTekst, string vraagImageUrl, ICollection<Antwoord> antwoorden, ICollection<VraagVoorwaarde> voorwaarden, Thema thema)
        {
            Vraag v = new Vraag()
            {
                VraagId = vraagId,
                VraagKernTekst = vraagKernTekst,
                VraagTekst = vraagTekst,
                VraagImageUrl = vraagImageUrl,
                Antwoorden = antwoorden,
                Voorwaarden = voorwaarden,
                Thema = thema
            };

            return repo.CreateVraag(v);
        }

        public IEnumerable<Resultaat> GetResultaten(Antwoord antwoord)
        {
            IEnumerable<Resultaat> resultaten = repo.ReadResultaten(antwoord);
            return resultaten;
        }

        public IEnumerable<Thema> GetThemas()
        {
            IEnumerable<Thema> themas = repo.ReadThemas();
            return themas;
        }

        public IEnumerable<Vraag> GetVragen()
        {
            IEnumerable<Vraag> vragen = repo.ReadVragen();
            return vragen;
        }

        public IEnumerable<Vraag> GetVragen(Thema thema)
        {
            IEnumerable<Vraag> vragen = repo.ReadVragen().Where(v => v.Thema == thema);
            return vragen;
        }
    }
}
