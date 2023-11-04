using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Orden
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdEmpleadoFk { get; set; }

    public int IdClienteFk { get; set; }

    public int IdEstadoFk { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

    public virtual Cliente IdClienteFkNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoFkNavigation { get; set; } = null!;

    public virtual Estado IdEstadoFkNavigation { get; set; } = null!;
}
