using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiTest.Migrations
{
    public partial class ClassesDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Chamados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAbertura",
                table: "Chamados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEncerramento",
                table: "Chamados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Chamados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "numeroChamado",
                table: "Chamados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_ClienteId",
                table: "Chamados",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chamados_Clientes_ClienteId",
                table: "Chamados",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Clientes_ClienteId",
                table: "Usuarios",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chamados_Clientes_ClienteId",
                table: "Chamados");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Clientes_ClienteId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ClienteId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Chamados_ClienteId",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "DataAbertura",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "DataEncerramento",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "numeroChamado",
                table: "Chamados");
        }
    }
}
