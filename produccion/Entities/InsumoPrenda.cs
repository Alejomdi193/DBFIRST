using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class InsumoPrenda
{
    public int IdInsumoFk { get; set; }

    public int IdPrendaFk { get; set; }

    public int Cantidad { get; set; }

    public virtual Insumo IdInsumoFkNavigation { get; set; } = null!;

    public virtual Prendum IdPrendaFkNavigation { get; set; } = null!;
}
