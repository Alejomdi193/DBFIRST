using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Color
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();
}
