using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    public interface IRepoEvaluacion
    {
        IEnumerable<Evaluacion> getEvaluacionporLineaTelefonica(LineaTelefonica LineaTelefonica);
        IEnumerable<Evaluacion> getEvaluacionporTrabajador(Trabajador trabajador);
        IEnumerable<Evaluacion> getEvaluacionporventa(Venta venta);

    }
}
