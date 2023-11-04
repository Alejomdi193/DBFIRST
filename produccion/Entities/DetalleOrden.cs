using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class DetalleOrden
{
    public int Id { get; set; }

    public int IdOrdenFk { get; set; }

    public int IdPrendaFk { get; set; }

    public int? PrendaId { get; set; }

    public int CantidadProducir { get; set; }

    public int IdColorFk { get; set; }

    public int CantidadProducida { get; set; }

    public int IdEstadoFk { get; set; }

    public virtual Color IdColorFkNavigation { get; set; } = null!;

    public virtual Estado IdEstadoFkNavigation { get; set; } = null!;

    public virtual Orden IdOrdenFkNavigation { get; set; } = null!;

    public virtual Prendum? Prenda { get; set; }
}
