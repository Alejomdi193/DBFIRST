using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Empresa
{
    public int Id { get; set; }

    public string Nit { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string RepresentanteLegal { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; } = null!;
}
