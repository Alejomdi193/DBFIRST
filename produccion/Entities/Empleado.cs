using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdCargoFk { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Cargo IdCargoFkNavigation { get; set; } = null!;

    public virtual Municipio IdMunicipioFkNavigation { get; set; } = null!;

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
