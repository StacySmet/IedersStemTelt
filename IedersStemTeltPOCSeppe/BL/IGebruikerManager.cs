using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.BL
{
    public interface IGebruikerManager
    {
        Personage AddPersonage(int personageId, string personageImageUrl, int score, ICollection<PersonageVoorwaarde> voorwaarden);
        Partij AddPartij(int partijId, string partijNaam, string partijLogoUrl, ICollection<PartijStandpunt> partijStandpunten, Gemeente gemeente);
    }
}
