using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.DAL
{
    public interface IVraagRepository
    {
        //Thema
        Thema CreateThema(Thema thema);
        IEnumerable<Thema> ReadThemas();

        //Vraag
        Vraag CreateVraag(Vraag vraag);
        IEnumerable<Vraag> ReadVragen();
        IEnumerable<Vraag> ReadVragen(Thema thema);

        //Antwoord
        Antwoord CreateAntwoord(Antwoord antwoord);
        IEnumerable<Antwoord> ReadAntwoorden(Vraag vraag);

        //Resultaat
        Resultaat CreateResultaat(Resultaat resultaat);
        IEnumerable<Resultaat> ReadResultaten(Antwoord antwoord);


    }
}
