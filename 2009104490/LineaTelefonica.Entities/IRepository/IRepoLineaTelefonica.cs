using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    public interface IRepoLineaTelefonica
    {
        IEnumerable<LineaTelefonica> getLineaporAdministrador(AdministradorLinea AdministradorLinea);
        IEnumerable<LineaTelefonica> getLineaporEvaluacion(Evaluacion Evaluacion);
    }
}
