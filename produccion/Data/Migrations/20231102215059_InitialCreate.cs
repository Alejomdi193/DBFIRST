using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace produccion.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sueldo_base = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "forma_pago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "insumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_unit = table.Column<double>(type: "double", nullable: false),
                    stock_min = table.Column<double>(type: "double", nullable: false),
                    stock_max = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "talla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "tipo_estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "tipo_persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "tipo_proteccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departamento_pais_IdPaisFk",
                        column: x => x.IdPaisFk,
                        principalTable: "pais",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estado_tipo_estado_IdTipoEstadoFk",
                        column: x => x.IdTipoEstadoFk,
                        principalTable: "tipo_estado",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamentoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipio_departamento_IdDepartamentoFk",
                        column: x => x.IdDepartamentoFk,
                        principalTable: "departamento",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "prenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnitCop = table.Column<double>(type: "double", nullable: false),
                    ValorUnitUsd = table.Column<double>(type: "double", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoProteccion = table.Column<int>(type: "int", nullable: false),
                    IdGeneroFk = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''", collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prenda_estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "estado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_prenda_genero_IdGeneroFk",
                        column: x => x.IdGeneroFk,
                        principalTable: "genero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_prenda_tipo_proteccion_IdTipoProteccion",
                        column: x => x.IdTipoProteccion,
                        principalTable: "tipo_proteccion",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCliente = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    fechaRegistro = table.Column<DateOnly>(type: "date", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cliente_municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "municipio",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_cliente_tipo_persona_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "tipo_persona",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCargoFk = table.Column<int>(type: "int", nullable: false),
                    fecha_ingreso = table.Column<DateOnly>(type: "date", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empleado_Cargos_IdCargoFk",
                        column: x => x.IdCargoFk,
                        principalTable: "cargos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_empleado_municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "municipio",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    razon_social = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    representante_legal = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateOnly>(type: "date", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "municipio",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NitProveedor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersona = table.Column<int>(type: "int", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proveedor_municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "municipio",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_proveedor_tipo_persona_IdTipoPersona",
                        column: x => x.IdTipoPersona,
                        principalTable: "tipo_persona",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "insumo_prendas",
                columns: table => new
                {
                    IdInsumoFk = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.IdPrendaFk, x.IdInsumoFk })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "FK_insumo_prendas_insumo_IdInsumoFk",
                        column: x => x.IdInsumoFk,
                        principalTable: "insumo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_insumo_prendas_prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "prenda",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodInv = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    ValorVtaCop = table.Column<double>(type: "double", nullable: false),
                    ValorVtaUsd = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventario_prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "prenda",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orden_cliente_IdClienteFk",
                        column: x => x.IdClienteFk,
                        principalTable: "cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orden_empleado_IdEmpleadoFk",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "empleado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orden_estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "estado",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: false),
                    IdFormaPagoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_venta_cliente_IdClienteFk",
                        column: x => x.IdClienteFk,
                        principalTable: "cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_venta_empleado_IdEmpleadoFk",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "empleado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_venta_forma_pago_IdFormaPagoFk",
                        column: x => x.IdFormaPagoFk,
                        principalTable: "forma_pago",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "insumo_proveedor",
                columns: table => new
                {
                    IdInsumoFk = table.Column<int>(type: "int", nullable: false),
                    IdProveedorFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.IdInsumoFk, x.IdProveedorFk })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "FK_insumo_proveedor_insumo_IdInsumoFk",
                        column: x => x.IdInsumoFk,
                        principalTable: "insumo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_insumo_proveedor_proveedor_IdProveedorFk",
                        column: x => x.IdProveedorFk,
                        principalTable: "proveedor",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "inventario_talla",
                columns: table => new
                {
                    IdInvFk = table.Column<int>(type: "int", nullable: false),
                    IdTallaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.IdInvFk, x.IdTallaFk })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "FK_inventario_talla_inventario_IdInvFk",
                        column: x => x.IdInvFk,
                        principalTable: "inventario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_inventario_talla_talla_IdTallaFk",
                        column: x => x.IdTallaFk,
                        principalTable: "talla",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "detalle_orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrdenFk = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    PrendaId = table.Column<int>(type: "int", nullable: true),
                    cantidad_producir = table.Column<int>(type: "int", nullable: false),
                    IdColorFk = table.Column<int>(type: "int", nullable: false),
                    cantidad_producida = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalle_orden_Color_IdColorFk",
                        column: x => x.IdColorFk,
                        principalTable: "color",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalle_orden_estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "estado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalle_orden_orden_IdOrdenFk",
                        column: x => x.IdOrdenFk,
                        principalTable: "orden",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalle_orden_prenda_PrendaId",
                        column: x => x.PrendaId,
                        principalTable: "prenda",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "detalle_venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVentaFk = table.Column<int>(type: "int", nullable: false),
                    IdProductoFk = table.Column<int>(type: "int", nullable: false),
                    IdTallaFk = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    valor_unit = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalle_venta_inventario_IdProductoFk",
                        column: x => x.IdProductoFk,
                        principalTable: "inventario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalle_venta_talla_IdTallaFk",
                        column: x => x.IdTallaFk,
                        principalTable: "talla",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_detalle_venta_venta_IdVentaFk",
                        column: x => x.IdVentaFk,
                        principalTable: "venta",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_IdMunicipioFk",
                table: "cliente",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_IdTipoPersonaFk",
                table: "cliente",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_IdColorFk",
                table: "detalle_orden",
                column: "IdColorFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_IdEstadoFk",
                table: "detalle_orden",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_IdOrdenFk",
                table: "detalle_orden",
                column: "IdOrdenFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_PrendaId",
                table: "detalle_orden",
                column: "PrendaId");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_venta_IdProductoFk",
                table: "detalle_venta",
                column: "IdProductoFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_venta_IdTallaFk",
                table: "detalle_venta",
                column: "IdTallaFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_venta_IdVentaFk",
                table: "detalle_venta",
                column: "IdVentaFk");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdCargoFk",
                table: "empleado",
                column: "IdCargoFk");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdMunicipioFk",
                table: "empleado",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_IdMunicipioFk",
                table: "empresa",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_estado_IdTipoEstadoFk",
                table: "estado",
                column: "IdTipoEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_insumo_prendas_IdInsumoFk",
                table: "insumo_prendas",
                column: "IdInsumoFk");

            migrationBuilder.CreateIndex(
                name: "IX_insumo_proveedor_IdProveedorFk",
                table: "insumo_proveedor",
                column: "IdProveedorFk");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_IdPrendaFk",
                table: "inventario",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_talla_IdTallaFk",
                table: "inventario_talla",
                column: "IdTallaFk");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_IdDepartamentoFk",
                table: "municipio",
                column: "IdDepartamentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_IdClienteFk",
                table: "orden",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_IdEmpleadoFk",
                table: "orden",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_IdEstadoFk",
                table: "orden",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_IdEstadoFk",
                table: "prenda",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_IdGeneroFk",
                table: "prenda",
                column: "IdGeneroFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_IdTipoProteccion",
                table: "prenda",
                column: "IdTipoProteccion");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdMunicipioFk",
                table: "proveedor",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdTipoPersona",
                table: "proveedor",
                column: "IdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_NitProveedor",
                table: "proveedor",
                column: "NitProveedor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdClienteFk",
                table: "venta",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdEmpleadoFk",
                table: "venta",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdFormaPagoFk",
                table: "venta",
                column: "IdFormaPagoFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalle_orden");

            migrationBuilder.DropTable(
                name: "detalle_venta");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "insumo_prendas");

            migrationBuilder.DropTable(
                name: "insumo_proveedor");

            migrationBuilder.DropTable(
                name: "inventario_talla");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "orden");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "insumo");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "talla");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "forma_pago");

            migrationBuilder.DropTable(
                name: "prenda");

            migrationBuilder.DropTable(
                name: "tipo_persona");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "tipo_proteccion");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "tipo_estado");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
