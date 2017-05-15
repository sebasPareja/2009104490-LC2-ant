using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    interface IRepoAdministradorLinea
    {
        IEnumerable<AdministradorLinea> getAdministradorporLinea(LineaTelefonica lineaTelefonica);
    }
}
