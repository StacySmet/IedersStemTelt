using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IST.BL.Domain;
using IST.DAL;

namespace IST.BL
{
    public class EigenschapManager : IEigenschapManager
    {
        private readonly IEigenschapRepository repo;

        public EigenschapManager()
        {
            repo = new EigenschapRepository();
        }
        public Eigenschap AddEigenschap(int eigenschapId, string eigenschapNaam, ICollection<string> mogelijkheden, ICollection<Voorwaarde> voorwaarden)
        {
            Eigenschap e = new Eigenschap()
            {
                EigenschapId = eigenschapId,
                EigenschapNaam = eigenschapNaam,
                Mogelijkheden = mogelijkheden,
                Voorwaarden = voorwaarden
            };           

            return repo.CreateEigenschap(e);
        }

        public Voorwaarde AddResultaatVoorwaarden(int voorwardeId, Eigenschap eigenschap, string waarde, Resultaat resultaat)
        {
            Voorwaarde vr = new ResultaatVoorwaarde()
            {
                VoorwaardeId = voorwardeId,
                Eigenschap = eigenschap,
                Waarde = waarde,
                Resultaat = resultaat
            };

            return repo.CreateVoorwaarde(vr);
        }

        public Voorwaarde AddVraagVoorwaarde(int voorwardeId, Eigenschap eigenschap, string waarde, Vraag vraag)
        {
            Voorwaarde vv = new VraagVoorwaarde()
            {
                VoorwaardeId = voorwardeId,
                Eigenschap = eigenschap,
                Waarde = waarde,
                Vraag = vraag
            };

            return repo.CreateVoorwaarde(vv);
        }
    }
}
