using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "simulador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Media_Valor_Mensal = table.Column<string>(nullable: false),
                    Media_Anual_Consumo_kWh = table.Column<double>(nullable: false),
                    Potencia = table.Column<double>(nullable: false),
                    Valor_Medio_Equipamento = table.Column<double>(nullable: false),
                    Valor_Mao_De_Obra = table.Column<double>(nullable: false),
                    Total_Investimento = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_simulador", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "simulador");
        }
    }
}
