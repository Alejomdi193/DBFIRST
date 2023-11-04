using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Municipio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdDepartamentoFk { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual Departamento IdDepartamentoFkNavigation { get; set; } = null!;

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
