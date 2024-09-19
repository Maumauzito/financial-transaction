using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransacaoFinanceira.Infrastructure.Migrations
{
    public partial class populaDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "938485762", 180.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "347586970", 1200.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 3, "2147483649", 0.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9872), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 4, "675869708", 4900.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 5, "238596054", 478.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9874), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 6, "573659065", 787.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9875), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 7, "210385733", 10.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9876), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 8, "674038564", 400.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9877), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountNumber", "Balance", "CreatedAt", "UpdatedAt" },
                values: new object[] { 9, "563856300", 1200.0m, new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 1, "938485762", "2147483649", 150m, new Guid("aca0baca-1b4c-495c-b116-247c93339886"), new DateTime(2023, 9, 9, 14, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 2, "2147483649", "210385733", 149m, new Guid("9c04c4ef-d211-470b-9ce8-f73bb05c9b25"), new DateTime(2023, 9, 9, 14, 15, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 3, "347586970", "238596054", 1100m, new Guid("daec7c40-365d-4431-a458-fd0864d57470"), new DateTime(2023, 9, 9, 14, 15, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 4, "675869708", "210385733", 5300m, new Guid("712ec524-2732-4fd9-8523-df8d6fb35454"), new DateTime(2023, 9, 9, 14, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 5, "238596054", "674038564", 1489m, new Guid("fd0ed752-0f11-4ca0-a060-e5a4cb27f285"), new DateTime(2023, 9, 9, 14, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 6, "573659065", "563856300", 49m, new Guid("a7893e50-7f9f-4024-b622-c1fb3be7dc2f"), new DateTime(2023, 9, 9, 14, 18, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 7, "938485762", "2147483649", 44m, new Guid("9710bf35-c35d-4ad0-b730-7b490b11ddcf"), new DateTime(2023, 9, 9, 14, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AccountSource", "AccountTarget", "AmountTransaction", "CorrelationId", "CreatedAt" },
                values: new object[] { 8, "573659065", "675869708", 150m, new Guid("f4b87582-4be4-49e5-af15-1af036e4e390"), new DateTime(2023, 9, 9, 14, 19, 1, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
