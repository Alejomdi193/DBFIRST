using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class TipoProteccion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Prendum> Prenda { get; set; } = new List<Prendum>();
}
