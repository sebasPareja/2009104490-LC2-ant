﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.IRepository
{
    interface IUnityofWork : IDisposable
    {
        IRepoAdministradorEquipo AdministradorEquipo { get; }
        IRepoAdministradorLinea AdministradorLinea { get; }
        IRepoCentroAtencion CentroAtencion { get; }
        IRepoCliente Cliente { get; }
        IRepoContrato Contrato { get; }
        IRepoDepartamento Departamento { get; }
        IRepoDireccion Direccion { get; }
        IRepoEquipoCelular EquipoCelular { get; }
        IRepoEvaluacion Evaluacion { get; }
        IRepoLineaTelefonica LineaTelefonica { get; }
        IRepoPlan Plan { get; }
        IRepoProvincia Provincia { get; }
        IRepoTrabajador Trabajador { get; }
        IRepoUbigeo Ubigeo { get; }
        IRepoVenta Venta { get; }

        int SaveChanges();
    }
}
