using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string IdCliente { get; set; } = null!;

    public int IdTipoPersonaFk { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public int IdMunicipioFk { get; set; }

    public virtual Municipio IdMunicipioFkNavigation { get; set; } = null!;

    public virtual TipoPersona IdTipoPersonaFkNavigation { get; set; } = null!;

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
