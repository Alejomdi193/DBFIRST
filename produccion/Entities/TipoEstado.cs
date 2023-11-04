using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class TipoEstado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
