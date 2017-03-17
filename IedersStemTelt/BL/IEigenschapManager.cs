using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL
{
    public interface IEigenschapManager
    {
        //Eigenschap GetEigenschap(int eigenschapId);
        //ICollection<Eigenschap> GetEigenschappen();
        Eigenschap AddEigenschap(int eigenschapId, string eigenschapNaam, ICollection<string> mogelijkheden, ICollection<Voorwaarde> voorwaarden);
        Voorwaarde AddVraagVoorwaarde(int voorwardeId, Eigenschap eigenschap, string waarde, Vraag vraag);
        Voorwaarde AddResultaatVoorwaarden(int voorwardeId, Eigenschap eigenschap, string waarde, Resultaat resultaat);
        //void ChangeEigenschap(Eigenschap eigenschap);
        //void RemoveEigenschap(int eigenschapId);
    }
}
