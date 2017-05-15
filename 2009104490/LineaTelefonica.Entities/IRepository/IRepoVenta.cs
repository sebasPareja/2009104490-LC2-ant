using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    public interface IRepoVenta
    {
        IEnumerable<Cliente> getVentaporCliente(Cliente Cliente);
        IEnumerable<Cliente> getVentaporContrato(Contrato Contrato);
        IEnumerable<Cliente> getVentaporCentroAtencion(CentroAtencion CentroAtencion);
        IEnumerable<Cliente> getVentaporLineaTelefonica(LineaTelefonica LineaTelefonica);
    }
}
