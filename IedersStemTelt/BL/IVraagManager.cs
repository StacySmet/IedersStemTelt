using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL
{
    public interface IVraagManager
    {
        //Thema 
        Thema AddThema(int themaId, string themaNaam, string themaTekst, string themaImageUrl, ICollection<Vraag> vragen, ICollection<PartijStandpunt> standpunten);
        IEnumerable<Thema> GetThemas();

        //Vraag
        Vraag AddVraag(int vraagId, string vraagKernTekst, string vraagTekst, string vraagImageUrl, ICollection<Antwoord> antwoorden, ICollection<VraagVoorwaarde> voorwaarden, Thema thema);
        IEnumerable<Vraag> GetVragen();
        IEnumerable<Vraag> GetVragen(Thema thema);

        //Resultaat
        Resultaat AddResultaat(int resultaatId, string resultaatTekst, string resultaatImageUrl, short kans, Antwoord antwoord, ICollection<ResultaatVoorwaarde> voorwaarden);
        IEnumerable<Resultaat> GetResultaten(Antwoord antwoord);
    }
}
