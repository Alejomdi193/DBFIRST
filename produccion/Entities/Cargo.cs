using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Cargo
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public double SueldoBase { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
