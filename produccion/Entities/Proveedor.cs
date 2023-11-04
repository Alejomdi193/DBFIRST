using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Proveedor
{
    public int Id { get; set; }

    public string NitProveedor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int IdTipoPersona { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; } = null!;

    public virtual TipoPersona IdTipoPersonaNavigation { get; set; } = null!;

    public virtual ICollection<Insumo> IdInsumoFks { get; set; } = new List<Insumo>();
}
