using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class TipoPersona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
