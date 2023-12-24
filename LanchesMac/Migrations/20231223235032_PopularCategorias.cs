using LanchesMac.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var categoryListData = new List<(string, string)> {
                ("Normal", "Lanche feito com ingredientes normais"),
                ("Natural", "Lanche feito com ingredientes naturais"),
            };

            foreach(var category in categoryListData)
            {
                migrationBuilder.Sql(string.Format("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES('{0}', '{1}')", category.Item1, category.Item2));
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
