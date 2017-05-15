using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    public interface IRepoDepartamento
    {
        IEnumerable<Departamento> getDepartamento(Provincia provincia );
        IEnumerable<Departamento> getDepartamento(Distrito distrito);
        IEnumerable<Departamento> getDepartamento(Ubigeo ubigeo );
        IEnumerable<Departamento> getDepartamento(CentroAtencion centroatencion);
    }
}
