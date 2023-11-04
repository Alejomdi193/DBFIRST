using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdPaisFk { get; set; }

    public virtual Pai IdPaisFkNavigation { get; set; } = null!;

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}
