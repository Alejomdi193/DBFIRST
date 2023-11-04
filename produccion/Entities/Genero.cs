using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Genero
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Prendum> Prenda { get; set; } = new List<Prendum>();
}
