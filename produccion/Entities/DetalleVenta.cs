using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class DetalleVentum
{
    public int Id { get; set; }

    public int IdVentaFk { get; set; }

    public int IdProductoFk { get; set; }

    public int IdTallaFk { get; set; }

    public int Cantidad { get; set; }

    public double ValorUnit { get; set; }

    public virtual Inventario IdProductoFkNavigation { get; set; } = null!;

    public virtual Talla IdTallaFkNavigation { get; set; } = null!;

    public virtual Ventum IdVentaFkNavigation { get; set; } = null!;
}
