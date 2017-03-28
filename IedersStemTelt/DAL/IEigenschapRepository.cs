using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.DAL
{
    public interface IEigenschapRepository
    {
        //Eigenschap
        Eigenschap CreateEigenschap(Eigenschap eigenschap);

        //Voorwaarde
        Voorwaarde CreateVoorwaarde(Voorwaarde voorwaarde);
    }
}
