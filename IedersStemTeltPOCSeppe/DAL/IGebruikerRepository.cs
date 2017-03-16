using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.DAL
{
    public interface IGebruikerRepository
    {
        //Personage
        Personage CreatePersonage(Personage personage);


        //Partij
        Partij CreatePartij(Partij partij);

        //Admin
    }
}
