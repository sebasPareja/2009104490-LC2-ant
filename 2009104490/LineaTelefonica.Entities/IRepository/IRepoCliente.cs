using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    public interface IRepoCliente
    {
        IEnumerable<Cliente> getClienteporVenta(Venta venta);
        IEnumerable<Cliente> getClienteporEvaluacion(Evaluacion evaluacion);

    }
}
