using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using produccion.Entities;

namespace produccion.Data;

public partial class ProduccionContext : DbContext
{
    public ProduccionContext()
    {
    }

    public ProduccionContext(DbContextOptions<ProduccionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetalleOrden> DetalleOrdens { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Insumo> Insumos { get; set; }

    public virtual DbSet<InsumoPrenda> InsumoPrendas { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Prendum> Prenda { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    public virtual DbSet<TipoEstado> TipoEstados { get; set; }

    public virtual DbSet<TipoPersona> TipoPersonas { get; set; }

    public virtual DbSet<TipoProteccion> TipoProteccions { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=123456;database=producion", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cargos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
            entity.Property(e => e.SueldoBase).HasColumnName("sueldo_base");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cliente");

            entity.HasIndex(e => e.IdMunicipioFk, "IX_cliente_IdMunicipioFk");

            entity.HasIndex(e => e.IdTipoPersonaFk, "IX_cliente_IdTipoPersonaFk");

            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCliente).HasMaxLength(255);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdTipoPersonaFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdTipoPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("color");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("departamento");

            entity.HasIndex(e => e.IdPaisFk, "IX_departamento_IdPaisFk");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdPaisFkNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdPaisFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DetalleOrden>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("detalle_orden");

            entity.HasIndex(e => e.IdColorFk, "IX_detalle_orden_IdColorFk");

            entity.HasIndex(e => e.IdEstadoFk, "IX_detalle_orden_IdEstadoFk");

            entity.HasIndex(e => e.IdOrdenFk, "IX_detalle_orden_IdOrdenFk");

            entity.HasIndex(e => e.PrendaId, "IX_detalle_orden_PrendaId");

            entity.Property(e => e.CantidadProducida).HasColumnName("cantidad_producida");
            entity.Property(e => e.CantidadProducir).HasColumnName("cantidad_producir");

            entity.HasOne(d => d.IdColorFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdColorFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalle_orden_Color_IdColorFk");

            entity.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdOrdenFkNavigation).WithMany(p => p.DetalleOrdens)
                .HasForeignKey(d => d.IdOrdenFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Prenda).WithMany(p => p.DetalleOrdens).HasForeignKey(d => d.PrendaId);
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("detalle_venta");

            entity.HasIndex(e => e.IdProductoFk, "IX_detalle_venta_IdProductoFk");

            entity.HasIndex(e => e.IdTallaFk, "IX_detalle_venta_IdTallaFk");

            entity.HasIndex(e => e.IdVentaFk, "IX_detalle_venta_IdVentaFk");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.ValorUnit).HasColumnName("valor_unit");

            entity.HasOne(d => d.IdProductoFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProductoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdTallaFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdTallaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdVentaFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVentaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("empleado");

            entity.HasIndex(e => e.IdCargoFk, "IX_empleado_IdCargoFk");

            entity.HasIndex(e => e.IdMunicipioFk, "IX_empleado_IdMunicipioFk");

            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCargoFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCargoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empleado_Cargos_IdCargoFk");

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.IdMunicipioFk, "IX_empresa_IdMunicipioFk");

            entity.Property(e => e.Nit)
                .HasMaxLength(50)
                .HasColumnName("nit");
            entity.Property(e => e.RazonSocial)
                .HasColumnType("text")
                .HasColumnName("razon_social");
            entity.Property(e => e.RepresentanteLegal)
                .HasMaxLength(50)
                .HasColumnName("representante_legal");

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("estado");

            entity.HasIndex(e => e.IdTipoEstadoFk, "IX_estado_IdTipoEstadoFk");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.IdTipoEstadoFkNavigation).WithMany(p => p.Estados)
                .HasForeignKey(d => d.IdTipoEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("forma_pago");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("genero");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Insumo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("insumo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.StockMax).HasColumnName("stock_max");
            entity.Property(e => e.StockMin).HasColumnName("stock_min");
            entity.Property(e => e.ValorUnit).HasColumnName("valor_unit");

            entity.HasMany(d => d.IdProveedorFks).WithMany(p => p.IdInsumoFks)
                .UsingEntity<Dictionary<string, object>>(
                    "InsumoProveedor",
                    r => r.HasOne<Proveedor>().WithMany()
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<Insumo>().WithMany()
                        .HasForeignKey("IdInsumoFk")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("IdInsumoFk", "IdProveedorFk")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("insumo_proveedor");
                        j.HasIndex(new[] { "IdProveedorFk" }, "IX_insumo_proveedor_IdProveedorFk");
                    });
        });

        modelBuilder.Entity<InsumoPrenda>(entity =>
        {
            entity.HasKey(e => new { e.IdPrendaFk, e.IdInsumoFk })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("insumo_prendas");

            entity.HasIndex(e => e.IdInsumoFk, "IX_insumo_prendas_IdInsumoFk");

            entity.HasOne(d => d.IdInsumoFkNavigation).WithMany(p => p.InsumoPrenda)
                .HasForeignKey(d => d.IdInsumoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdPrendaFkNavigation).WithMany(p => p.InsumoPrenda)
                .HasForeignKey(d => d.IdPrendaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("inventario");

            entity.HasIndex(e => e.IdPrendaFk, "IX_inventario_IdPrendaFk");

            entity.Property(e => e.CodInv).HasMaxLength(255);

            entity.HasOne(d => d.IdPrendaFkNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.IdPrendaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.IdTallaFks).WithMany(p => p.IdInvFks)
                .UsingEntity<Dictionary<string, object>>(
                    "InventarioTalla",
                    r => r.HasOne<Talla>().WithMany()
                        .HasForeignKey("IdTallaFk")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<Inventario>().WithMany()
                        .HasForeignKey("IdInvFk")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("IdInvFk", "IdTallaFk")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("inventario_talla");
                        j.HasIndex(new[] { "IdTallaFk" }, "IX_inventario_talla_IdTallaFk");
                    });
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("municipio");

            entity.HasIndex(e => e.IdDepartamentoFk, "IX_municipio_IdDepartamentoFk");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDepartamentoFkNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamentoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("orden");

            entity.HasIndex(e => e.IdClienteFk, "IX_orden_IdClienteFk");

            entity.HasIndex(e => e.IdEmpleadoFk, "IX_orden_IdEmpleadoFk");

            entity.HasIndex(e => e.IdEstadoFk, "IX_orden_IdEstadoFk");

            entity.Property(e => e.Fecha).HasColumnName("fecha");

            entity.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Ordens)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pais");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Prendum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prenda");

            entity.HasIndex(e => e.IdEstadoFk, "IX_prenda_IdEstadoFk");

            entity.HasIndex(e => e.IdGeneroFk, "IX_prenda_IdGeneroFk");

            entity.HasIndex(e => e.IdTipoProteccion, "IX_prenda_IdTipoProteccion");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Prenda)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdGeneroFkNavigation).WithMany(p => p.Prenda)
                .HasForeignKey(d => d.IdGeneroFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdTipoProteccionNavigation).WithMany(p => p.Prenda)
                .HasForeignKey(d => d.IdTipoProteccion)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("proveedor");

            entity.HasIndex(e => e.IdMunicipioFk, "IX_proveedor_IdMunicipioFk");

            entity.HasIndex(e => e.IdTipoPersona, "IX_proveedor_IdTipoPersona");

            entity.HasIndex(e => e.NitProveedor, "IX_proveedor_NitProveedor").IsUnique();

            entity.Property(e => e.NitProveedor).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.IdMunicipioFkNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdMunicipioFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdTipoPersona)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Talla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("talla");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TipoEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_estado");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoPersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_persona");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoProteccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_proteccion");

            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venta");

            entity.HasIndex(e => e.IdClienteFk, "IX_venta_IdClienteFk");

            entity.HasIndex(e => e.IdEmpleadoFk, "IX_venta_IdEmpleadoFk");

            entity.HasIndex(e => e.IdFormaPagoFk, "IX_venta_IdFormaPagoFk");

            entity.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdFormaPagoFkNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdFormaPagoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
