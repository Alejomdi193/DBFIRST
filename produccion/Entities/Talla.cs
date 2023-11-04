using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Talla
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual ICollection<Inventario> IdInvFks { get; set; } = new List<Inventario>();
}
