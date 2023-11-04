using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Pai
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
