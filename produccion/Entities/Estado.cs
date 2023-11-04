using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Estado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdTipoEstadoFk { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    public virtual TipoEstado IdTipoEstadoFkNavigation { get; set; } = null!;

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

    public virtual ICollection<Prendum> Prenda { get; set; } = new List<Prendum>();
}
