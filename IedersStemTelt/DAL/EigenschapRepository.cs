using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.DAL
{
    public class EigenschapRepository : IEigenschapRepository
    {
        private List<Eigenschap> eigenschappen;
        //private List<string> mogelijkheden;
        private List<Voorwaarde> voorwaarden;

        public Eigenschap CreateEigenschap(Eigenschap eigenschap)
        {
            eigenschap.EigenschapId = eigenschappen.Count + 1;
            eigenschappen.Add(eigenschap);
            return eigenschap;
        }

        public Voorwaarde CreateVoorwaarde(Voorwaarde voorwaarde)
        {
            voorwaarde.VoorwaardeId = voorwaarden.Count + 1;
            voorwaarden.Add(voorwaarde);
            return voorwaarde;
        }
    }
}
