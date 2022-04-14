using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyType",
                columns: table => new
                {
                    BodyTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyType", x => x.BodyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "CarColors",
                columns: table => new
                {
                    CarColorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarColorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarColors", x => x.CarColorID);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "GearTypes",
                columns: table => new
                {
                    GearTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearTypes", x => x.GearTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<byte>(type: "tinyint", nullable: false),
                    CarColorID = table.Column<byte>(type: "tinyint", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FuelTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    GearTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    BodyTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    LuggageVolume = table.Column<short>(type: "smallint", nullable: false),
                    ModelYear = table.Column<short>(type: "smallint", nullable: false),
                    BrandID1 = table.Column<int>(type: "int", nullable: true),
                    CarColorID1 = table.Column<int>(type: "int", nullable: true),
                    FuelTypeID1 = table.Column<int>(type: "int", nullable: true),
                    GearTypeID1 = table.Column<int>(type: "int", nullable: true),
                    BodyTypeID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Cars_BodyType_BodyTypeID1",
                        column: x => x.BodyTypeID1,
                        principalTable: "BodyType",
                        principalColumn: "BodyTypeID");
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandID1",
                        column: x => x.BrandID1,
                        principalTable: "Brands",
                        principalColumn: "BrandID");
                    table.ForeignKey(
                        name: "FK_Cars_CarColors_CarColorID1",
                        column: x => x.CarColorID1,
                        principalTable: "CarColors",
                        principalColumn: "CarColorID");
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeID1",
                        column: x => x.FuelTypeID1,
                        principalTable: "FuelTypes",
                        principalColumn: "FuelTypeID");
                    table.ForeignKey(
                        name: "FK_Cars_GearTypes_GearTypeID1",
                        column: x => x.GearTypeID1,
                        principalTable: "GearTypes",
                        principalColumn: "GearTypeID");
                });

            migrationBuilder.InsertData(
                table: "BodyType",
                columns: new[] { "BodyTypeID", "BodyTypeName" },
                values: new object[,]
                {
                    { 1, "Cabrio" },
                    { 2, "Coupe" },
                    { 3, "Sedan" },
                    { 4, "Hb" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[,]
                {
                    { 1, "Fiat" },
                    { 2, "Renault" },
                    { 3, "Mercedes" },
                    { 4, "BMW" }
                });

            migrationBuilder.InsertData(
                table: "CarColors",
                columns: new[] { "CarColorID", "CarColorName" },
                values: new object[,]
                {
                    { 1, "Kırmızı" },
                    { 2, "Beyaz" },
                    { 3, "Sarı" },
                    { 4, "Siyah" },
                    { 5, "Mavi" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 1, (byte)4, null, (byte)1, null, (byte)3, null, "ATS", (byte)3, null, (byte)4, null, (short)2350, (short)2015, 5 },
                    { 2, (byte)2, null, (byte)3, null, (byte)1, null, "SP2", (byte)3, null, (byte)4, null, (short)1650, (short)2022, 7 },
                    { 3, (byte)3, null, (byte)1, null, (byte)2, null, "Sedan de Ville", (byte)1, null, (byte)4, null, (short)1700, (short)2021, 2 },
                    { 4, (byte)1, null, (byte)3, null, (byte)1, null, "SRX", (byte)3, null, (byte)1, null, (short)150, (short)2020, 2 },
                    { 5, (byte)2, null, (byte)2, null, (byte)2, null, "7-Series", (byte)2, null, (byte)3, null, (short)2600, (short)2016, 2 },
                    { 6, (byte)1, null, (byte)2, null, (byte)5, null, "Soul", (byte)3, null, (byte)2, null, (short)2100, (short)2020, 5 },
                    { 7, (byte)3, null, (byte)3, null, (byte)2, null, "Sedan de Ville", (byte)2, null, (byte)1, null, (short)850, (short)2020, 2 },
                    { 8, (byte)4, null, (byte)4, null, (byte)1, null, "New Six", (byte)4, null, (byte)2, null, (short)3000, (short)2021, 2 },
                    { 9, (byte)2, null, (byte)3, null, (byte)2, null, "X1", (byte)3, null, (byte)2, null, (short)950, (short)2016, 5 },
                    { 10, (byte)1, null, (byte)1, null, (byte)1, null, "i3", (byte)3, null, (byte)3, null, (short)3350, (short)2022, 5 },
                    { 11, (byte)4, null, (byte)3, null, (byte)2, null, "Eldorado", (byte)2, null, (byte)1, null, (short)3250, (short)2015, 2 },
                    { 12, (byte)1, null, (byte)4, null, (byte)1, null, "Eldorado", (byte)4, null, (byte)2, null, (short)950, (short)2018, 5 },
                    { 13, (byte)4, null, (byte)3, null, (byte)5, null, "Rio", (byte)3, null, (byte)2, null, (short)800, (short)2022, 7 },
                    { 14, (byte)2, null, (byte)4, null, (byte)5, null, "Series 60 (Sixty Special)", (byte)3, null, (byte)2, null, (short)700, (short)2022, 7 },
                    { 15, (byte)3, null, (byte)3, null, (byte)2, null, "Picanto", (byte)3, null, (byte)3, null, (short)3300, (short)2022, 5 },
                    { 16, (byte)4, null, (byte)2, null, (byte)3, null, "Escalade", (byte)1, null, (byte)2, null, (short)350, (short)2018, 5 },
                    { 17, (byte)4, null, (byte)4, null, (byte)2, null, "Saveiro", (byte)4, null, (byte)2, null, (short)1100, (short)2022, 2 },
                    { 18, (byte)1, null, (byte)2, null, (byte)5, null, "7-Series", (byte)2, null, (byte)1, null, (short)2100, (short)2019, 2 },
                    { 19, (byte)2, null, (byte)1, null, (byte)5, null, "Venga", (byte)2, null, (byte)3, null, (short)2550, (short)2016, 2 },
                    { 20, (byte)3, null, (byte)3, null, (byte)3, null, "Escalade", (byte)1, null, (byte)3, null, (short)1800, (short)2021, 7 },
                    { 21, (byte)4, null, (byte)4, null, (byte)3, null, "Sorento", (byte)3, null, (byte)4, null, (short)850, (short)2021, 7 },
                    { 22, (byte)1, null, (byte)1, null, (byte)3, null, "Gol", (byte)1, null, (byte)2, null, (short)2000, (short)2018, 2 },
                    { 23, (byte)2, null, (byte)4, null, (byte)4, null, "Niro", (byte)2, null, (byte)3, null, (short)450, (short)2015, 5 },
                    { 24, (byte)4, null, (byte)2, null, (byte)1, null, "1-Series", (byte)2, null, (byte)1, null, (short)1650, (short)2018, 5 },
                    { 25, (byte)1, null, (byte)4, null, (byte)2, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)1, null, (short)300, (short)2019, 5 },
                    { 26, (byte)3, null, (byte)4, null, (byte)1, null, "Series 75", (byte)1, null, (byte)4, null, (short)1950, (short)2017, 5 },
                    { 27, (byte)1, null, (byte)3, null, (byte)5, null, "X6", (byte)2, null, (byte)1, null, (short)700, (short)2019, 2 },
                    { 28, (byte)2, null, (byte)3, null, (byte)2, null, "Picanto", (byte)2, null, (byte)3, null, (short)2050, (short)2018, 5 },
                    { 29, (byte)3, null, (byte)1, null, (byte)1, null, "Escalade", (byte)2, null, (byte)4, null, (short)2300, (short)2021, 5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 30, (byte)2, null, (byte)2, null, (byte)4, null, "Quoris / K9 / K900", (byte)3, null, (byte)1, null, (short)1000, (short)2019, 2 },
                    { 31, (byte)2, null, (byte)4, null, (byte)1, null, "Series 62", (byte)1, null, (byte)2, null, (short)1350, (short)2022, 5 },
                    { 32, (byte)3, null, (byte)2, null, (byte)5, null, "Pointer", (byte)2, null, (byte)2, null, (short)1250, (short)2020, 5 },
                    { 33, (byte)1, null, (byte)3, null, (byte)2, null, "3-Series, M3", (byte)4, null, (byte)4, null, (short)250, (short)2021, 5 },
                    { 34, (byte)4, null, (byte)3, null, (byte)1, null, "Cee'd", (byte)4, null, (byte)1, null, (short)1100, (short)2016, 5 },
                    { 35, (byte)4, null, (byte)1, null, (byte)3, null, "New Six CS", (byte)2, null, (byte)1, null, (short)2550, (short)2022, 2 },
                    { 36, (byte)1, null, (byte)4, null, (byte)3, null, "Eldorado", (byte)2, null, (byte)3, null, (short)3200, (short)2018, 5 },
                    { 37, (byte)2, null, (byte)4, null, (byte)4, null, "Fleetwood Limousine", (byte)4, null, (byte)4, null, (short)2350, (short)2020, 5 },
                    { 38, (byte)1, null, (byte)2, null, (byte)2, null, "Catera", (byte)1, null, (byte)4, null, (short)2900, (short)2020, 2 },
                    { 39, (byte)4, null, (byte)1, null, (byte)2, null, "BLS", (byte)4, null, (byte)4, null, (short)300, (short)2016, 7 },
                    { 40, (byte)1, null, (byte)4, null, (byte)3, null, "Series 62", (byte)4, null, (byte)3, null, (short)1150, (short)2022, 2 },
                    { 41, (byte)4, null, (byte)2, null, (byte)3, null, "Sephia", (byte)2, null, (byte)4, null, (short)1350, (short)2016, 5 },
                    { 42, (byte)1, null, (byte)2, null, (byte)4, null, "Carens", (byte)4, null, (byte)3, null, (short)1700, (short)2015, 5 },
                    { 43, (byte)4, null, (byte)1, null, (byte)1, null, "501", (byte)3, null, (byte)1, null, (short)850, (short)2017, 5 },
                    { 44, (byte)4, null, (byte)1, null, (byte)3, null, "X1", (byte)3, null, (byte)1, null, (short)2450, (short)2020, 5 },
                    { 45, (byte)3, null, (byte)3, null, (byte)4, null, "Gol", (byte)3, null, (byte)3, null, (short)2150, (short)2022, 5 },
                    { 46, (byte)1, null, (byte)3, null, (byte)5, null, "Voyage", (byte)1, null, (byte)4, null, (short)3400, (short)2021, 7 },
                    { 47, (byte)4, null, (byte)4, null, (byte)3, null, "Avella", (byte)1, null, (byte)3, null, (short)2800, (short)2016, 7 },
                    { 48, (byte)2, null, (byte)2, null, (byte)4, null, "Series 62", (byte)4, null, (byte)4, null, (short)1650, (short)2019, 7 },
                    { 49, (byte)3, null, (byte)4, null, (byte)5, null, "3-Series, M3", (byte)2, null, (byte)3, null, (short)1800, (short)2022, 2 },
                    { 50, (byte)4, null, (byte)3, null, (byte)3, null, "CT6", (byte)4, null, (byte)4, null, (short)200, (short)2017, 7 },
                    { 51, (byte)2, null, (byte)4, null, (byte)4, null, "Z3, M", (byte)1, null, (byte)4, null, (short)1350, (short)2016, 2 },
                    { 52, (byte)2, null, (byte)3, null, (byte)2, null, "Series 75", (byte)2, null, (byte)3, null, (short)3300, (short)2020, 7 },
                    { 53, (byte)1, null, (byte)4, null, (byte)1, null, "i8", (byte)4, null, (byte)1, null, (short)2000, (short)2017, 5 },
                    { 54, (byte)2, null, (byte)3, null, (byte)5, null, "Opirus / Amanti", (byte)1, null, (byte)1, null, (short)2800, (short)2018, 5 },
                    { 55, (byte)4, null, (byte)1, null, (byte)4, null, "Sedan de Ville", (byte)3, null, (byte)3, null, (short)2950, (short)2019, 2 },
                    { 56, (byte)2, null, (byte)1, null, (byte)5, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)2, null, (short)1350, (short)2020, 2 },
                    { 57, (byte)1, null, (byte)2, null, (byte)4, null, "Carens / Rondo", (byte)3, null, (byte)1, null, (short)2400, (short)2021, 2 },
                    { 58, (byte)1, null, (byte)1, null, (byte)4, null, "8-Series", (byte)3, null, (byte)1, null, (short)3000, (short)2015, 7 },
                    { 59, (byte)1, null, (byte)4, null, (byte)3, null, "Enterprise", (byte)3, null, (byte)3, null, (short)2400, (short)2019, 5 },
                    { 60, (byte)2, null, (byte)1, null, (byte)5, null, "Quoris / K9 / K900", (byte)4, null, (byte)3, null, (short)850, (short)2018, 5 },
                    { 61, (byte)2, null, (byte)2, null, (byte)2, null, "Coupe de Ville", (byte)4, null, (byte)1, null, (short)2600, (short)2020, 2 },
                    { 62, (byte)3, null, (byte)2, null, (byte)1, null, "Coupe de Ville", (byte)1, null, (byte)1, null, (short)2750, (short)2017, 2 },
                    { 63, (byte)3, null, (byte)3, null, (byte)1, null, "5-Series, M5", (byte)2, null, (byte)3, null, (short)3100, (short)2018, 5 },
                    { 64, (byte)3, null, (byte)2, null, (byte)3, null, "Series 61", (byte)2, null, (byte)3, null, (short)800, (short)2016, 2 },
                    { 65, (byte)4, null, (byte)4, null, (byte)5, null, "Cadenza / K7", (byte)3, null, (byte)4, null, (short)1150, (short)2017, 7 },
                    { 66, (byte)1, null, (byte)3, null, (byte)2, null, "Series 60 (Sixty Special)", (byte)1, null, (byte)4, null, (short)2200, (short)2018, 7 },
                    { 67, (byte)2, null, (byte)3, null, (byte)5, null, "6-Series, M6", (byte)2, null, (byte)3, null, (short)2400, (short)2019, 2 },
                    { 68, (byte)4, null, (byte)4, null, (byte)2, null, "X2", (byte)1, null, (byte)4, null, (short)1750, (short)2022, 7 },
                    { 69, (byte)2, null, (byte)3, null, (byte)1, null, "Carens", (byte)4, null, (byte)4, null, (short)1850, (short)2021, 7 },
                    { 70, (byte)3, null, (byte)4, null, (byte)1, null, "Series 60 (Sixty Special)", (byte)4, null, (byte)4, null, (short)950, (short)2018, 5 },
                    { 71, (byte)4, null, (byte)1, null, (byte)3, null, "Pride", (byte)2, null, (byte)1, null, (short)1450, (short)2016, 2 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 72, (byte)1, null, (byte)4, null, (byte)4, null, "Seville", (byte)3, null, (byte)1, null, (short)850, (short)2022, 5 },
                    { 73, (byte)3, null, (byte)3, null, (byte)5, null, "Coupe de Ville", (byte)4, null, (byte)3, null, (short)3150, (short)2022, 7 },
                    { 74, (byte)3, null, (byte)3, null, (byte)4, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)1, null, (short)350, (short)2022, 2 },
                    { 75, (byte)4, null, (byte)2, null, (byte)4, null, "Logus", (byte)3, null, (byte)3, null, (short)3050, (short)2018, 5 },
                    { 76, (byte)2, null, (byte)4, null, (byte)5, null, "Sephia", (byte)2, null, (byte)1, null, (short)1050, (short)2017, 2 },
                    { 77, (byte)4, null, (byte)2, null, (byte)3, null, "Eldorado", (byte)2, null, (byte)4, null, (short)2250, (short)2016, 5 },
                    { 78, (byte)1, null, (byte)2, null, (byte)2, null, "Bongo", (byte)1, null, (byte)4, null, (short)800, (short)2017, 7 },
                    { 79, (byte)4, null, (byte)3, null, (byte)1, null, "M1", (byte)1, null, (byte)1, null, (short)600, (short)2015, 5 },
                    { 80, (byte)2, null, (byte)1, null, (byte)1, null, "Carens", (byte)2, null, (byte)1, null, (short)2900, (short)2019, 2 },
                    { 81, (byte)4, null, (byte)2, null, (byte)1, null, "Sportage", (byte)1, null, (byte)3, null, (short)550, (short)2018, 2 },
                    { 82, (byte)3, null, (byte)2, null, (byte)2, null, "1-Series", (byte)2, null, (byte)1, null, (short)3500, (short)2016, 7 },
                    { 83, (byte)1, null, (byte)3, null, (byte)4, null, "6-Series GT", (byte)4, null, (byte)2, null, (short)400, (short)2018, 2 },
                    { 84, (byte)1, null, (byte)4, null, (byte)2, null, "Quoris / K9 / K900", (byte)1, null, (byte)2, null, (short)900, (short)2016, 7 },
                    { 85, (byte)3, null, (byte)2, null, (byte)5, null, "X5", (byte)4, null, (byte)2, null, (short)2900, (short)2019, 7 },
                    { 86, (byte)1, null, (byte)1, null, (byte)2, null, "Sedan de Ville", (byte)1, null, (byte)3, null, (short)1450, (short)2022, 7 },
                    { 87, (byte)1, null, (byte)1, null, (byte)5, null, "Enterprise", (byte)1, null, (byte)4, null, (short)1650, (short)2020, 2 },
                    { 88, (byte)1, null, (byte)4, null, (byte)2, null, "Rio", (byte)3, null, (byte)4, null, (short)2150, (short)2021, 7 },
                    { 89, (byte)1, null, (byte)3, null, (byte)3, null, "Soul", (byte)4, null, (byte)3, null, (short)850, (short)2022, 2 },
                    { 90, (byte)2, null, (byte)4, null, (byte)4, null, "CTS", (byte)3, null, (byte)2, null, (short)2800, (short)2019, 7 },
                    { 91, (byte)4, null, (byte)2, null, (byte)2, null, "Saveiro", (byte)3, null, (byte)4, null, (short)650, (short)2020, 5 },
                    { 92, (byte)4, null, (byte)3, null, (byte)2, null, "Series 62", (byte)3, null, (byte)3, null, (short)2100, (short)2015, 5 },
                    { 93, (byte)2, null, (byte)1, null, (byte)4, null, "XTS", (byte)1, null, (byte)3, null, (short)2000, (short)2018, 7 },
                    { 94, (byte)4, null, (byte)1, null, (byte)2, null, "Avella", (byte)4, null, (byte)2, null, (short)1750, (short)2019, 5 },
                    { 95, (byte)2, null, (byte)3, null, (byte)3, null, "SpaceFox / Suran / SportVan / Fox Plus", (byte)2, null, (byte)1, null, (short)1550, (short)2015, 5 },
                    { 96, (byte)1, null, (byte)2, null, (byte)5, null, "Sportage", (byte)1, null, (byte)4, null, (short)350, (short)2021, 5 },
                    { 97, (byte)3, null, (byte)1, null, (byte)2, null, "X5", (byte)1, null, (byte)4, null, (short)1400, (short)2015, 5 },
                    { 98, (byte)3, null, (byte)4, null, (byte)2, null, "502", (byte)1, null, (byte)1, null, (short)1700, (short)2015, 5 },
                    { 99, (byte)3, null, (byte)1, null, (byte)5, null, "New Class 1500, 1600, 1800, 2000", (byte)1, null, (byte)3, null, (short)1050, (short)2016, 7 },
                    { 100, (byte)3, null, (byte)1, null, (byte)5, null, "Eldorado", (byte)2, null, (byte)1, null, (short)1300, (short)2015, 2 },
                    { 101, (byte)4, null, (byte)1, null, (byte)2, null, "M1", (byte)2, null, (byte)2, null, (short)2450, (short)2021, 5 },
                    { 102, (byte)2, null, (byte)3, null, (byte)3, null, "Escalade", (byte)3, null, (byte)4, null, (short)1700, (short)2020, 2 },
                    { 103, (byte)1, null, (byte)3, null, (byte)2, null, "Series 75", (byte)2, null, (byte)4, null, (short)1800, (short)2018, 5 },
                    { 104, (byte)4, null, (byte)3, null, (byte)5, null, "Seville", (byte)2, null, (byte)3, null, (short)1050, (short)2017, 5 },
                    { 105, (byte)4, null, (byte)2, null, (byte)5, null, "Rio", (byte)3, null, (byte)1, null, (short)2700, (short)2019, 5 },
                    { 106, (byte)4, null, (byte)4, null, (byte)2, null, "Fleetwood Limousine", (byte)4, null, (byte)2, null, (short)2500, (short)2021, 2 },
                    { 107, (byte)1, null, (byte)4, null, (byte)5, null, "6-Series, M6", (byte)3, null, (byte)2, null, (short)1850, (short)2019, 2 },
                    { 108, (byte)3, null, (byte)1, null, (byte)2, null, "5-Series, M5", (byte)3, null, (byte)1, null, (short)350, (short)2022, 5 },
                    { 109, (byte)2, null, (byte)1, null, (byte)3, null, "Series 60", (byte)1, null, (byte)1, null, (short)1750, (short)2021, 7 },
                    { 110, (byte)4, null, (byte)4, null, (byte)2, null, "Coupe de Ville", (byte)1, null, (byte)4, null, (short)3350, (short)2020, 5 },
                    { 111, (byte)4, null, (byte)3, null, (byte)5, null, "Carens / Rondo", (byte)3, null, (byte)2, null, (short)2150, (short)2021, 5 },
                    { 112, (byte)1, null, (byte)4, null, (byte)1, null, "3-Series, M3", (byte)3, null, (byte)3, null, (short)2600, (short)2022, 7 },
                    { 113, (byte)4, null, (byte)1, null, (byte)2, null, "Magentis / Optima", (byte)2, null, (byte)2, null, (short)850, (short)2018, 7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 114, (byte)4, null, (byte)1, null, (byte)5, null, "Seville", (byte)3, null, (byte)1, null, (short)2650, (short)2015, 5 },
                    { 115, (byte)3, null, (byte)3, null, (byte)4, null, "Sedan de Ville", (byte)2, null, (byte)2, null, (short)2300, (short)2017, 7 },
                    { 116, (byte)1, null, (byte)2, null, (byte)1, null, "Seville", (byte)2, null, (byte)1, null, (short)2850, (short)2021, 5 },
                    { 117, (byte)2, null, (byte)1, null, (byte)3, null, "Carens", (byte)3, null, (byte)4, null, (short)1400, (short)2015, 7 },
                    { 118, (byte)1, null, (byte)3, null, (byte)5, null, "4-Series, M4", (byte)2, null, (byte)1, null, (short)2250, (short)2018, 5 },
                    { 119, (byte)2, null, (byte)4, null, (byte)4, null, "Z8", (byte)1, null, (byte)1, null, (short)3400, (short)2019, 5 },
                    { 120, (byte)4, null, (byte)4, null, (byte)4, null, "Bongo", (byte)1, null, (byte)1, null, (short)1850, (short)2016, 7 },
                    { 121, (byte)3, null, (byte)4, null, (byte)2, null, "Coupe de Ville", (byte)4, null, (byte)4, null, (short)1700, (short)2015, 5 },
                    { 122, (byte)2, null, (byte)4, null, (byte)3, null, "Cee'd", (byte)3, null, (byte)1, null, (short)2200, (short)2021, 5 },
                    { 123, (byte)2, null, (byte)1, null, (byte)1, null, "Allanté", (byte)2, null, (byte)3, null, (short)600, (short)2018, 7 },
                    { 124, (byte)3, null, (byte)1, null, (byte)2, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)2, null, (short)1850, (short)2017, 7 },
                    { 125, (byte)1, null, (byte)2, null, (byte)5, null, "Sedan de Ville", (byte)1, null, (byte)4, null, (short)2300, (short)2021, 2 },
                    { 126, (byte)2, null, (byte)2, null, (byte)3, null, "Santana", (byte)4, null, (byte)1, null, (short)3150, (short)2019, 7 },
                    { 127, (byte)1, null, (byte)2, null, (byte)1, null, "SRX", (byte)2, null, (byte)3, null, (short)2550, (short)2019, 2 },
                    { 128, (byte)1, null, (byte)2, null, (byte)4, null, "Clarus", (byte)1, null, (byte)2, null, (short)1700, (short)2021, 2 },
                    { 129, (byte)4, null, (byte)1, null, (byte)1, null, "Seville", (byte)3, null, (byte)2, null, (short)3350, (short)2021, 7 },
                    { 130, (byte)1, null, (byte)4, null, (byte)5, null, "XT4", (byte)2, null, (byte)2, null, (short)2750, (short)2016, 7 },
                    { 131, (byte)3, null, (byte)2, null, (byte)1, null, "New Six CS", (byte)1, null, (byte)3, null, (short)2000, (short)2017, 5 },
                    { 132, (byte)4, null, (byte)3, null, (byte)4, null, "Escalade", (byte)4, null, (byte)3, null, (short)2850, (short)2020, 5 },
                    { 133, (byte)3, null, (byte)2, null, (byte)4, null, "5-Series, M5", (byte)4, null, (byte)2, null, (short)2550, (short)2021, 7 },
                    { 134, (byte)3, null, (byte)2, null, (byte)3, null, "X4", (byte)1, null, (byte)2, null, (short)1100, (short)2019, 7 },
                    { 135, (byte)3, null, (byte)2, null, (byte)2, null, "X6", (byte)2, null, (byte)1, null, (short)3450, (short)2018, 2 },
                    { 136, (byte)1, null, (byte)3, null, (byte)5, null, "Coupe de Ville", (byte)2, null, (byte)1, null, (short)1100, (short)2015, 2 },
                    { 137, (byte)4, null, (byte)3, null, (byte)1, null, "Parati", (byte)4, null, (byte)4, null, (short)450, (short)2020, 5 },
                    { 138, (byte)3, null, (byte)4, null, (byte)2, null, "Coupe de Ville", (byte)3, null, (byte)3, null, (short)350, (short)2016, 5 },
                    { 139, (byte)2, null, (byte)2, null, (byte)1, null, "Rio", (byte)2, null, (byte)1, null, (short)1900, (short)2017, 5 },
                    { 140, (byte)1, null, (byte)1, null, (byte)3, null, "CT6", (byte)1, null, (byte)3, null, (short)350, (short)2020, 7 },
                    { 141, (byte)3, null, (byte)1, null, (byte)2, null, "7-Series", (byte)1, null, (byte)4, null, (short)1450, (short)2022, 2 },
                    { 142, (byte)1, null, (byte)4, null, (byte)2, null, "3-Series, M3", (byte)4, null, (byte)1, null, (short)700, (short)2018, 5 },
                    { 143, (byte)3, null, (byte)4, null, (byte)1, null, "Picanto", (byte)2, null, (byte)2, null, (short)1150, (short)2019, 7 },
                    { 144, (byte)2, null, (byte)4, null, (byte)5, null, "SRX", (byte)1, null, (byte)2, null, (short)1600, (short)2017, 2 },
                    { 145, (byte)2, null, (byte)2, null, (byte)4, null, "Retona", (byte)2, null, (byte)4, null, (short)2800, (short)2021, 7 },
                    { 146, (byte)2, null, (byte)1, null, (byte)3, null, "Series 61", (byte)2, null, (byte)1, null, (short)600, (short)2022, 5 },
                    { 147, (byte)3, null, (byte)4, null, (byte)3, null, "Venga", (byte)1, null, (byte)4, null, (short)300, (short)2015, 2 },
                    { 148, (byte)1, null, (byte)2, null, (byte)5, null, "Cadenza / K7", (byte)2, null, (byte)1, null, (short)3400, (short)2020, 7 },
                    { 149, (byte)3, null, (byte)4, null, (byte)2, null, "3-Series, M3", (byte)3, null, (byte)2, null, (short)1500, (short)2022, 7 },
                    { 150, (byte)1, null, (byte)1, null, (byte)5, null, "Enterprise", (byte)4, null, (byte)3, null, (short)2400, (short)2016, 7 },
                    { 151, (byte)2, null, (byte)3, null, (byte)2, null, "New Class 1500, 1600, 1800, 2000", (byte)1, null, (byte)4, null, (short)200, (short)2016, 5 },
                    { 152, (byte)3, null, (byte)4, null, (byte)3, null, "Z8", (byte)2, null, (byte)2, null, (short)2000, (short)2015, 5 },
                    { 153, (byte)4, null, (byte)3, null, (byte)5, null, "507", (byte)4, null, (byte)4, null, (short)2850, (short)2018, 7 },
                    { 154, (byte)4, null, (byte)3, null, (byte)4, null, "Eldorado", (byte)3, null, (byte)4, null, (short)2700, (short)2016, 7 },
                    { 155, (byte)1, null, (byte)4, null, (byte)1, null, "DTS", (byte)2, null, (byte)1, null, (short)3200, (short)2017, 7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 156, (byte)3, null, (byte)4, null, (byte)2, null, "Fusca", (byte)1, null, (byte)3, null, (short)1850, (short)2018, 5 },
                    { 157, (byte)4, null, (byte)4, null, (byte)5, null, "Potentia", (byte)4, null, (byte)4, null, (short)350, (short)2022, 7 },
                    { 158, (byte)3, null, (byte)3, null, (byte)5, null, "Sephia", (byte)3, null, (byte)1, null, (short)3300, (short)2018, 5 },
                    { 159, (byte)1, null, (byte)3, null, (byte)1, null, "Series 75", (byte)3, null, (byte)2, null, (short)2000, (short)2018, 2 },
                    { 160, (byte)2, null, (byte)2, null, (byte)1, null, "ATS", (byte)3, null, (byte)1, null, (short)1550, (short)2022, 2 },
                    { 161, (byte)1, null, (byte)4, null, (byte)5, null, "Retona", (byte)2, null, (byte)2, null, (short)1250, (short)2018, 2 },
                    { 162, (byte)1, null, (byte)1, null, (byte)5, null, "CTS", (byte)3, null, (byte)3, null, (short)1500, (short)2019, 5 },
                    { 163, (byte)4, null, (byte)3, null, (byte)5, null, "Sportage", (byte)2, null, (byte)4, null, (short)1600, (short)2018, 2 },
                    { 164, (byte)4, null, (byte)3, null, (byte)2, null, "7-Series", (byte)4, null, (byte)2, null, (short)2000, (short)2019, 2 },
                    { 165, (byte)4, null, (byte)4, null, (byte)5, null, "M1", (byte)2, null, (byte)2, null, (short)2900, (short)2022, 7 },
                    { 166, (byte)1, null, (byte)4, null, (byte)5, null, "Fleetwood Brougham", (byte)4, null, (byte)2, null, (short)1200, (short)2018, 2 },
                    { 167, (byte)2, null, (byte)3, null, (byte)3, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)2, null, (short)150, (short)2018, 2 },
                    { 168, (byte)3, null, (byte)3, null, (byte)4, null, "X5", (byte)1, null, (byte)2, null, (short)850, (short)2021, 7 },
                    { 169, (byte)1, null, (byte)2, null, (byte)3, null, "Eldorado", (byte)1, null, (byte)3, null, (short)2650, (short)2016, 5 },
                    { 170, (byte)2, null, (byte)4, null, (byte)1, null, "Sedan de Ville", (byte)1, null, (byte)4, null, (short)3150, (short)2020, 5 },
                    { 171, (byte)3, null, (byte)4, null, (byte)5, null, "Eldorado", (byte)2, null, (byte)3, null, (short)3250, (short)2016, 2 },
                    { 172, (byte)2, null, (byte)4, null, (byte)4, null, "Parati", (byte)1, null, (byte)2, null, (short)1000, (short)2015, 7 },
                    { 173, (byte)1, null, (byte)4, null, (byte)2, null, "1-Series", (byte)4, null, (byte)1, null, (short)450, (short)2017, 7 },
                    { 174, (byte)1, null, (byte)3, null, (byte)4, null, "5-Series, M5", (byte)2, null, (byte)1, null, (short)1100, (short)2015, 5 },
                    { 175, (byte)2, null, (byte)3, null, (byte)4, null, "X3", (byte)4, null, (byte)1, null, (short)2000, (short)2020, 5 },
                    { 176, (byte)1, null, (byte)2, null, (byte)1, null, "Sedan de Ville", (byte)3, null, (byte)2, null, (short)150, (short)2015, 7 },
                    { 177, (byte)3, null, (byte)1, null, (byte)2, null, "Escalade", (byte)1, null, (byte)3, null, (short)1300, (short)2016, 5 },
                    { 178, (byte)1, null, (byte)3, null, (byte)4, null, "XTS", (byte)4, null, (byte)2, null, (short)2000, (short)2021, 5 },
                    { 179, (byte)3, null, (byte)1, null, (byte)4, null, "Carens", (byte)4, null, (byte)1, null, (short)1700, (short)2022, 2 },
                    { 180, (byte)2, null, (byte)4, null, (byte)1, null, "1-Series", (byte)4, null, (byte)2, null, (short)3000, (short)2016, 7 },
                    { 181, (byte)4, null, (byte)1, null, (byte)3, null, "3-Series GT", (byte)3, null, (byte)4, null, (short)1900, (short)2017, 5 },
                    { 182, (byte)2, null, (byte)4, null, (byte)1, null, "Escalade", (byte)1, null, (byte)4, null, (short)150, (short)2018, 5 },
                    { 183, (byte)4, null, (byte)1, null, (byte)4, null, "Clarus", (byte)3, null, (byte)3, null, (short)1850, (short)2022, 5 },
                    { 184, (byte)2, null, (byte)1, null, (byte)4, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)4, null, (short)2700, (short)2019, 5 },
                    { 185, (byte)4, null, (byte)3, null, (byte)1, null, "Soul", (byte)4, null, (byte)3, null, (short)550, (short)2020, 7 },
                    { 186, (byte)1, null, (byte)1, null, (byte)4, null, "New Class 1500, 1600, 1800, 2000", (byte)4, null, (byte)1, null, (short)3100, (short)2019, 5 },
                    { 187, (byte)2, null, (byte)3, null, (byte)4, null, "Series 61", (byte)2, null, (byte)1, null, (short)2750, (short)2018, 5 },
                    { 188, (byte)4, null, (byte)2, null, (byte)1, null, "Avella", (byte)4, null, (byte)2, null, (short)1800, (short)2016, 5 },
                    { 189, (byte)3, null, (byte)2, null, (byte)3, null, "X5", (byte)1, null, (byte)2, null, (short)350, (short)2017, 5 },
                    { 190, (byte)4, null, (byte)3, null, (byte)3, null, "Series 62", (byte)2, null, (byte)1, null, (short)2100, (short)2018, 2 },
                    { 191, (byte)2, null, (byte)2, null, (byte)3, null, "XTS", (byte)3, null, (byte)2, null, (short)400, (short)2015, 7 },
                    { 192, (byte)1, null, (byte)1, null, (byte)3, null, "Sedan de Ville", (byte)2, null, (byte)4, null, (short)2700, (short)2020, 7 },
                    { 193, (byte)1, null, (byte)3, null, (byte)5, null, "Sephia", (byte)1, null, (byte)4, null, (short)3200, (short)2016, 2 },
                    { 194, (byte)2, null, (byte)2, null, (byte)1, null, "Series 60 (Sixty Special)", (byte)3, null, (byte)3, null, (short)3400, (short)2022, 5 },
                    { 195, (byte)4, null, (byte)1, null, (byte)4, null, "X7", (byte)4, null, (byte)3, null, (short)1700, (short)2022, 7 },
                    { 196, (byte)4, null, (byte)1, null, (byte)5, null, "Fleetwood", (byte)2, null, (byte)4, null, (short)600, (short)2018, 7 },
                    { 197, (byte)3, null, (byte)2, null, (byte)3, null, "Fox", (byte)3, null, (byte)3, null, (short)2300, (short)2021, 5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 198, (byte)1, null, (byte)2, null, (byte)2, null, "Carnival / Sedona", (byte)2, null, (byte)4, null, (short)3150, (short)2021, 2 },
                    { 199, (byte)4, null, (byte)1, null, (byte)5, null, "Series 61", (byte)1, null, (byte)4, null, (short)2900, (short)2021, 7 },
                    { 200, (byte)1, null, (byte)2, null, (byte)2, null, "3-Series, M3", (byte)4, null, (byte)1, null, (short)2200, (short)2020, 2 },
                    { 201, (byte)3, null, (byte)2, null, (byte)2, null, "6-Series, M6", (byte)4, null, (byte)3, null, (short)3200, (short)2016, 7 },
                    { 202, (byte)1, null, (byte)1, null, (byte)3, null, "Fleetwood Limousine", (byte)1, null, (byte)1, null, (short)2600, (short)2015, 2 },
                    { 203, (byte)4, null, (byte)3, null, (byte)3, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)3, null, (short)2300, (short)2017, 5 },
                    { 204, (byte)1, null, (byte)2, null, (byte)2, null, "X3", (byte)4, null, (byte)1, null, (short)3300, (short)2018, 5 },
                    { 205, (byte)3, null, (byte)3, null, (byte)3, null, "Venga", (byte)1, null, (byte)1, null, (short)2550, (short)2020, 2 },
                    { 206, (byte)4, null, (byte)2, null, (byte)5, null, "CTS", (byte)2, null, (byte)2, null, (short)2000, (short)2018, 7 },
                    { 207, (byte)4, null, (byte)1, null, (byte)1, null, "Magentis / Optima / K5", (byte)4, null, (byte)4, null, (short)750, (short)2020, 7 },
                    { 208, (byte)1, null, (byte)1, null, (byte)5, null, "5-Series GT", (byte)1, null, (byte)4, null, (short)2250, (short)2015, 5 },
                    { 209, (byte)4, null, (byte)1, null, (byte)2, null, "New Six CS", (byte)4, null, (byte)3, null, (short)2200, (short)2017, 2 },
                    { 210, (byte)4, null, (byte)4, null, (byte)1, null, "Sportage", (byte)3, null, (byte)1, null, (short)3300, (short)2022, 5 },
                    { 211, (byte)3, null, (byte)2, null, (byte)5, null, "Eldorado", (byte)1, null, (byte)2, null, (short)1200, (short)2020, 5 },
                    { 212, (byte)3, null, (byte)2, null, (byte)3, null, "Fleetwood 75", (byte)1, null, (byte)4, null, (short)2450, (short)2017, 7 },
                    { 213, (byte)4, null, (byte)1, null, (byte)5, null, "Eldorado", (byte)2, null, (byte)4, null, (short)2050, (short)2020, 2 },
                    { 214, (byte)3, null, (byte)1, null, (byte)4, null, "Joice", (byte)4, null, (byte)4, null, (short)1350, (short)2020, 2 },
                    { 215, (byte)1, null, (byte)2, null, (byte)3, null, "Carens / Rondo", (byte)4, null, (byte)3, null, (short)3100, (short)2019, 2 },
                    { 216, (byte)4, null, (byte)3, null, (byte)2, null, "7-Series", (byte)2, null, (byte)1, null, (short)3050, (short)2015, 2 },
                    { 217, (byte)3, null, (byte)1, null, (byte)3, null, "Cadenza / K7", (byte)2, null, (byte)3, null, (short)3500, (short)2017, 5 },
                    { 218, (byte)3, null, (byte)3, null, (byte)1, null, "Seville", (byte)2, null, (byte)2, null, (short)700, (short)2022, 7 },
                    { 219, (byte)2, null, (byte)3, null, (byte)3, null, "Seville", (byte)2, null, (byte)1, null, (short)2000, (short)2022, 7 },
                    { 220, (byte)2, null, (byte)2, null, (byte)4, null, "Apollo", (byte)2, null, (byte)4, null, (short)2550, (short)2020, 7 },
                    { 221, (byte)1, null, (byte)2, null, (byte)4, null, "3-Series, M3", (byte)3, null, (byte)2, null, (short)2700, (short)2019, 2 },
                    { 222, (byte)1, null, (byte)3, null, (byte)3, null, "Fox", (byte)2, null, (byte)1, null, (short)1100, (short)2021, 7 },
                    { 223, (byte)2, null, (byte)4, null, (byte)2, null, "Sephia", (byte)4, null, (byte)2, null, (short)1250, (short)2017, 2 },
                    { 224, (byte)1, null, (byte)4, null, (byte)1, null, "Seville", (byte)2, null, (byte)1, null, (short)2600, (short)2015, 2 },
                    { 225, (byte)4, null, (byte)3, null, (byte)1, null, "ATS", (byte)4, null, (byte)3, null, (short)200, (short)2018, 7 },
                    { 226, (byte)3, null, (byte)4, null, (byte)2, null, "5-Series, M5", (byte)3, null, (byte)4, null, (short)750, (short)2021, 5 },
                    { 227, (byte)2, null, (byte)1, null, (byte)1, null, "Seville", (byte)4, null, (byte)4, null, (short)250, (short)2015, 5 },
                    { 228, (byte)2, null, (byte)4, null, (byte)3, null, "5-Series, M5", (byte)2, null, (byte)3, null, (short)2450, (short)2021, 2 },
                    { 229, (byte)4, null, (byte)1, null, (byte)5, null, "Gol", (byte)1, null, (byte)2, null, (short)1800, (short)2021, 7 },
                    { 230, (byte)3, null, (byte)3, null, (byte)1, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)3, null, (short)2700, (short)2018, 7 },
                    { 231, (byte)3, null, (byte)3, null, (byte)2, null, "New Class 1500, 1600, 1800, 2000", (byte)2, null, (byte)1, null, (short)1450, (short)2021, 2 },
                    { 232, (byte)4, null, (byte)2, null, (byte)3, null, "DTS", (byte)1, null, (byte)2, null, (short)2350, (short)2022, 2 },
                    { 233, (byte)1, null, (byte)3, null, (byte)5, null, "507", (byte)2, null, (byte)1, null, (short)1550, (short)2019, 5 },
                    { 234, (byte)1, null, (byte)1, null, (byte)2, null, "Carnival / Sedona", (byte)3, null, (byte)3, null, (short)1300, (short)2016, 2 },
                    { 235, (byte)1, null, (byte)4, null, (byte)1, null, "5-Series, M5", (byte)1, null, (byte)1, null, (short)1800, (short)2017, 5 },
                    { 236, (byte)1, null, (byte)2, null, (byte)5, null, "Eldorado", (byte)3, null, (byte)3, null, (short)2100, (short)2019, 2 },
                    { 237, (byte)1, null, (byte)4, null, (byte)3, null, "Fleetwood Limousine", (byte)2, null, (byte)3, null, (short)3400, (short)2021, 7 },
                    { 238, (byte)1, null, (byte)3, null, (byte)3, null, "7-Series", (byte)2, null, (byte)2, null, (short)1700, (short)2020, 5 },
                    { 239, (byte)4, null, (byte)4, null, (byte)2, null, "Voyage", (byte)4, null, (byte)3, null, (short)2850, (short)2016, 7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 240, (byte)3, null, (byte)2, null, (byte)1, null, "Carens / Rondo", (byte)4, null, (byte)4, null, (short)1800, (short)2022, 5 },
                    { 241, (byte)1, null, (byte)4, null, (byte)3, null, "7-Series", (byte)4, null, (byte)1, null, (short)2400, (short)2021, 5 },
                    { 242, (byte)2, null, (byte)4, null, (byte)2, null, "Santana", (byte)3, null, (byte)3, null, (short)2700, (short)2020, 7 },
                    { 243, (byte)1, null, (byte)4, null, (byte)3, null, "Bongo Frontier", (byte)4, null, (byte)4, null, (short)200, (short)2015, 7 },
                    { 244, (byte)3, null, (byte)1, null, (byte)1, null, "Series 62", (byte)1, null, (byte)2, null, (short)2450, (short)2022, 7 },
                    { 245, (byte)4, null, (byte)4, null, (byte)4, null, "3-Series GT", (byte)1, null, (byte)4, null, (short)2000, (short)2020, 5 },
                    { 246, (byte)1, null, (byte)1, null, (byte)3, null, "X7", (byte)2, null, (byte)1, null, (short)2100, (short)2022, 5 },
                    { 247, (byte)2, null, (byte)4, null, (byte)3, null, "Fleetwood Brougham", (byte)2, null, (byte)1, null, (short)1750, (short)2019, 7 },
                    { 248, (byte)4, null, (byte)3, null, (byte)5, null, "Avella", (byte)4, null, (byte)1, null, (short)2650, (short)2022, 5 },
                    { 249, (byte)4, null, (byte)2, null, (byte)3, null, "Magentis / Optima / K5", (byte)1, null, (byte)3, null, (short)1250, (short)2022, 7 },
                    { 250, (byte)1, null, (byte)2, null, (byte)2, null, "CTS", (byte)4, null, (byte)3, null, (short)1650, (short)2020, 7 },
                    { 251, (byte)1, null, (byte)2, null, (byte)2, null, "7-Series", (byte)3, null, (byte)1, null, (short)300, (short)2021, 2 },
                    { 252, (byte)4, null, (byte)3, null, (byte)4, null, "3-Series", (byte)2, null, (byte)1, null, (short)2750, (short)2019, 5 },
                    { 253, (byte)2, null, (byte)1, null, (byte)4, null, "Series 60 (Sixty Special)", (byte)4, null, (byte)2, null, (short)2550, (short)2019, 2 },
                    { 254, (byte)4, null, (byte)1, null, (byte)2, null, "X5", (byte)2, null, (byte)3, null, (short)550, (short)2020, 2 },
                    { 255, (byte)3, null, (byte)1, null, (byte)3, null, "Calais", (byte)2, null, (byte)1, null, (short)2550, (short)2017, 7 },
                    { 256, (byte)3, null, (byte)4, null, (byte)1, null, "Picanto", (byte)4, null, (byte)2, null, (short)1700, (short)2017, 2 },
                    { 257, (byte)1, null, (byte)1, null, (byte)1, null, "X2", (byte)4, null, (byte)2, null, (short)3000, (short)2018, 7 },
                    { 258, (byte)2, null, (byte)3, null, (byte)4, null, "Series 60 (Sixty Special)", (byte)3, null, (byte)1, null, (short)1450, (short)2019, 5 },
                    { 259, (byte)4, null, (byte)1, null, (byte)4, null, "6-Series, M6", (byte)3, null, (byte)1, null, (short)1250, (short)2020, 5 },
                    { 260, (byte)2, null, (byte)3, null, (byte)5, null, "Sportage", (byte)3, null, (byte)2, null, (short)800, (short)2021, 7 },
                    { 261, (byte)1, null, (byte)3, null, (byte)2, null, "Series 60 (Sixty Special)", (byte)1, null, (byte)4, null, (short)600, (short)2020, 2 },
                    { 262, (byte)1, null, (byte)2, null, (byte)2, null, "New Class 1602, 1802, 2002", (byte)1, null, (byte)1, null, (short)2500, (short)2021, 2 },
                    { 263, (byte)3, null, (byte)3, null, (byte)5, null, "8-Series", (byte)3, null, (byte)2, null, (short)3250, (short)2017, 2 },
                    { 264, (byte)2, null, (byte)4, null, (byte)3, null, "BLS", (byte)2, null, (byte)1, null, (short)1750, (short)2017, 5 },
                    { 265, (byte)4, null, (byte)2, null, (byte)1, null, "Series 75", (byte)2, null, (byte)4, null, (short)2750, (short)2015, 7 },
                    { 266, (byte)2, null, (byte)3, null, (byte)3, null, "Opirus / Amanti", (byte)2, null, (byte)3, null, (short)1600, (short)2017, 7 },
                    { 267, (byte)3, null, (byte)1, null, (byte)2, null, "5-Series, M5", (byte)4, null, (byte)2, null, (short)1300, (short)2017, 7 },
                    { 268, (byte)3, null, (byte)3, null, (byte)5, null, "Eldorado", (byte)1, null, (byte)3, null, (short)700, (short)2019, 7 },
                    { 269, (byte)1, null, (byte)3, null, (byte)5, null, "Fleetwood", (byte)3, null, (byte)1, null, (short)400, (short)2018, 2 },
                    { 270, (byte)2, null, (byte)2, null, (byte)5, null, "Z3, M", (byte)4, null, (byte)1, null, (short)400, (short)2019, 2 },
                    { 271, (byte)1, null, (byte)2, null, (byte)5, null, "Eldorado", (byte)2, null, (byte)2, null, (short)500, (short)2018, 5 },
                    { 272, (byte)2, null, (byte)2, null, (byte)1, null, "STS", (byte)4, null, (byte)1, null, (short)3100, (short)2015, 2 },
                    { 273, (byte)1, null, (byte)2, null, (byte)1, null, "Picanto", (byte)3, null, (byte)4, null, (short)2600, (short)2017, 5 },
                    { 274, (byte)3, null, (byte)4, null, (byte)1, null, "Forte / K3", (byte)1, null, (byte)2, null, (short)1300, (short)2022, 5 },
                    { 275, (byte)4, null, (byte)1, null, (byte)4, null, "Series 75", (byte)3, null, (byte)3, null, (short)3500, (short)2019, 7 },
                    { 276, (byte)4, null, (byte)1, null, (byte)1, null, "Eldorado", (byte)3, null, (byte)2, null, (short)2950, (short)2022, 2 },
                    { 277, (byte)1, null, (byte)4, null, (byte)2, null, "Magentis / Optima / K5", (byte)1, null, (byte)2, null, (short)3400, (short)2020, 5 },
                    { 278, (byte)1, null, (byte)3, null, (byte)2, null, "Coupe de Ville", (byte)2, null, (byte)4, null, (short)1300, (short)2021, 5 },
                    { 279, (byte)3, null, (byte)4, null, (byte)5, null, "Sorento", (byte)2, null, (byte)3, null, (short)300, (short)2020, 5 },
                    { 280, (byte)2, null, (byte)3, null, (byte)5, null, "Series 61", (byte)1, null, (byte)3, null, (short)200, (short)2019, 7 },
                    { 281, (byte)4, null, (byte)3, null, (byte)5, null, "Concord", (byte)1, null, (byte)2, null, (short)2400, (short)2022, 5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 282, (byte)1, null, (byte)1, null, (byte)4, null, "Soul", (byte)3, null, (byte)2, null, (short)1900, (short)2021, 2 },
                    { 283, (byte)1, null, (byte)4, null, (byte)1, null, "1-Series", (byte)1, null, (byte)2, null, (short)2900, (short)2016, 7 },
                    { 284, (byte)1, null, (byte)2, null, (byte)2, null, "Series 60 (Sixty Special)", (byte)3, null, (byte)2, null, (short)2550, (short)2021, 2 },
                    { 285, (byte)2, null, (byte)1, null, (byte)1, null, "7-Series", (byte)3, null, (byte)4, null, (short)3000, (short)2019, 5 },
                    { 286, (byte)1, null, (byte)2, null, (byte)2, null, "Bongo", (byte)2, null, (byte)2, null, (short)3100, (short)2016, 5 },
                    { 287, (byte)3, null, (byte)3, null, (byte)2, null, "Cimarron", (byte)3, null, (byte)2, null, (short)2550, (short)2019, 7 },
                    { 288, (byte)2, null, (byte)4, null, (byte)5, null, "Saveiro", (byte)4, null, (byte)1, null, (short)350, (short)2020, 7 },
                    { 289, (byte)3, null, (byte)4, null, (byte)1, null, "Elan", (byte)1, null, (byte)4, null, (short)1100, (short)2017, 5 },
                    { 290, (byte)1, null, (byte)4, null, (byte)3, null, "Magentis / Optima / K5", (byte)3, null, (byte)2, null, (short)1850, (short)2018, 5 },
                    { 291, (byte)1, null, (byte)1, null, (byte)5, null, "Z8", (byte)3, null, (byte)1, null, (short)3100, (short)2017, 5 },
                    { 292, (byte)4, null, (byte)3, null, (byte)4, null, "X5", (byte)3, null, (byte)3, null, (short)2200, (short)2016, 5 },
                    { 293, (byte)3, null, (byte)3, null, (byte)5, null, "X5", (byte)4, null, (byte)2, null, (short)2500, (short)2015, 7 },
                    { 294, (byte)3, null, (byte)1, null, (byte)1, null, "Series 75", (byte)4, null, (byte)4, null, (short)2650, (short)2019, 5 },
                    { 295, (byte)4, null, (byte)2, null, (byte)2, null, "Series 65", (byte)1, null, (byte)1, null, (short)3200, (short)2018, 5 },
                    { 296, (byte)2, null, (byte)3, null, (byte)3, null, "Fleetwood Brougham", (byte)3, null, (byte)4, null, (short)1350, (short)2019, 7 },
                    { 297, (byte)3, null, (byte)4, null, (byte)4, null, "Series 60 (Sixty Special)", (byte)3, null, (byte)4, null, (short)450, (short)2020, 5 },
                    { 298, (byte)3, null, (byte)3, null, (byte)1, null, "Series 61", (byte)3, null, (byte)3, null, (short)1500, (short)2016, 7 },
                    { 299, (byte)1, null, (byte)3, null, (byte)3, null, "Sedan de Ville", (byte)1, null, (byte)2, null, (short)2350, (short)2021, 5 },
                    { 300, (byte)1, null, (byte)1, null, (byte)3, null, "XT5", (byte)3, null, (byte)2, null, (short)2950, (short)2017, 2 },
                    { 301, (byte)4, null, (byte)4, null, (byte)2, null, "Sorento", (byte)1, null, (byte)4, null, (short)2950, (short)2015, 2 },
                    { 302, (byte)2, null, (byte)1, null, (byte)2, null, "7-Series", (byte)2, null, (byte)1, null, (short)450, (short)2017, 5 },
                    { 303, (byte)2, null, (byte)3, null, (byte)5, null, "7-Series", (byte)1, null, (byte)1, null, (short)3200, (short)2019, 2 },
                    { 304, (byte)4, null, (byte)4, null, (byte)3, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)3, null, (short)650, (short)2022, 2 },
                    { 305, (byte)1, null, (byte)1, null, (byte)4, null, "Pride", (byte)4, null, (byte)4, null, (short)1450, (short)2021, 5 },
                    { 306, (byte)3, null, (byte)4, null, (byte)1, null, "Forte / K3", (byte)4, null, (byte)3, null, (short)1050, (short)2015, 5 },
                    { 307, (byte)2, null, (byte)4, null, (byte)3, null, "New Six", (byte)3, null, (byte)4, null, (short)1200, (short)2015, 2 },
                    { 308, (byte)3, null, (byte)1, null, (byte)4, null, "Eldorado", (byte)1, null, (byte)4, null, (short)3200, (short)2015, 7 },
                    { 309, (byte)4, null, (byte)1, null, (byte)1, null, "Picanto", (byte)1, null, (byte)1, null, (short)650, (short)2017, 2 },
                    { 310, (byte)3, null, (byte)3, null, (byte)2, null, "Carnival / Sedona", (byte)4, null, (byte)2, null, (short)1150, (short)2018, 2 },
                    { 311, (byte)3, null, (byte)2, null, (byte)3, null, "Apollo", (byte)1, null, (byte)4, null, (short)2600, (short)2016, 7 },
                    { 312, (byte)3, null, (byte)2, null, (byte)1, null, "4-Series, M4", (byte)1, null, (byte)3, null, (short)2200, (short)2015, 7 },
                    { 313, (byte)1, null, (byte)3, null, (byte)4, null, "Series 60 (Sixty Special)", (byte)4, null, (byte)3, null, (short)3250, (short)2017, 2 },
                    { 314, (byte)1, null, (byte)2, null, (byte)4, null, "Forte / K3", (byte)3, null, (byte)1, null, (short)1100, (short)2018, 2 },
                    { 315, (byte)3, null, (byte)3, null, (byte)2, null, "Picanto", (byte)3, null, (byte)1, null, (short)400, (short)2018, 7 },
                    { 316, (byte)4, null, (byte)1, null, (byte)4, null, "Mohave / Borrego", (byte)2, null, (byte)3, null, (short)1650, (short)2016, 5 },
                    { 317, (byte)4, null, (byte)4, null, (byte)1, null, "ELR", (byte)1, null, (byte)1, null, (short)500, (short)2022, 5 },
                    { 318, (byte)2, null, (byte)3, null, (byte)2, null, "Rio", (byte)1, null, (byte)1, null, (short)1150, (short)2020, 5 },
                    { 319, (byte)3, null, (byte)2, null, (byte)2, null, "X4", (byte)3, null, (byte)4, null, (short)2450, (short)2022, 5 },
                    { 320, (byte)2, null, (byte)1, null, (byte)5, null, "5-Series, M5", (byte)4, null, (byte)1, null, (short)1900, (short)2017, 7 },
                    { 321, (byte)2, null, (byte)4, null, (byte)2, null, "Series 60 (Sixty Special)", (byte)4, null, (byte)2, null, (short)1150, (short)2021, 7 },
                    { 322, (byte)1, null, (byte)1, null, (byte)3, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)3, null, (short)400, (short)2019, 2 },
                    { 323, (byte)1, null, (byte)3, null, (byte)2, null, "SRX", (byte)2, null, (byte)1, null, (short)1500, (short)2019, 7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 324, (byte)3, null, (byte)3, null, (byte)3, null, "Parati", (byte)2, null, (byte)3, null, (short)200, (short)2022, 2 },
                    { 325, (byte)4, null, (byte)4, null, (byte)5, null, "Apollo", (byte)4, null, (byte)2, null, (short)2550, (short)2016, 7 },
                    { 326, (byte)1, null, (byte)3, null, (byte)5, null, "BLS", (byte)1, null, (byte)4, null, (short)1000, (short)2016, 5 },
                    { 327, (byte)4, null, (byte)1, null, (byte)1, null, "Retona", (byte)2, null, (byte)1, null, (short)3200, (short)2018, 7 },
                    { 328, (byte)4, null, (byte)1, null, (byte)1, null, "Brougham", (byte)1, null, (byte)3, null, (short)800, (short)2020, 2 },
                    { 329, (byte)3, null, (byte)2, null, (byte)5, null, "Cerato / Spectra", (byte)3, null, (byte)3, null, (short)2300, (short)2018, 5 },
                    { 330, (byte)3, null, (byte)2, null, (byte)1, null, "Santana", (byte)1, null, (byte)1, null, (short)1600, (short)2017, 7 },
                    { 331, (byte)2, null, (byte)2, null, (byte)4, null, "Cee'd", (byte)1, null, (byte)1, null, (short)1000, (short)2015, 5 },
                    { 332, (byte)4, null, (byte)2, null, (byte)2, null, "Pride", (byte)2, null, (byte)3, null, (short)3450, (short)2016, 7 },
                    { 333, (byte)1, null, (byte)1, null, (byte)1, null, "3200 CS", (byte)4, null, (byte)3, null, (short)850, (short)2021, 5 },
                    { 334, (byte)4, null, (byte)1, null, (byte)1, null, "Concord", (byte)2, null, (byte)3, null, (short)2300, (short)2015, 5 },
                    { 335, (byte)4, null, (byte)2, null, (byte)4, null, "Series 60", (byte)2, null, (byte)3, null, (short)3500, (short)2021, 7 },
                    { 336, (byte)3, null, (byte)4, null, (byte)1, null, "Series 62", (byte)2, null, (byte)2, null, (short)600, (short)2021, 2 },
                    { 337, (byte)2, null, (byte)3, null, (byte)5, null, "X1", (byte)1, null, (byte)3, null, (short)650, (short)2019, 7 },
                    { 338, (byte)1, null, (byte)2, null, (byte)5, null, "Rio", (byte)4, null, (byte)4, null, (short)2750, (short)2018, 7 },
                    { 339, (byte)1, null, (byte)1, null, (byte)5, null, "Rio", (byte)2, null, (byte)2, null, (short)500, (short)2019, 2 },
                    { 340, (byte)1, null, (byte)4, null, (byte)1, null, "Series 61", (byte)1, null, (byte)1, null, (short)450, (short)2019, 5 },
                    { 341, (byte)4, null, (byte)3, null, (byte)1, null, "6200", (byte)3, null, (byte)4, null, (short)2100, (short)2016, 7 },
                    { 342, (byte)4, null, (byte)2, null, (byte)2, null, "XT4", (byte)3, null, (byte)1, null, (short)3050, (short)2016, 2 },
                    { 343, (byte)3, null, (byte)4, null, (byte)1, null, "Cadenza / K7", (byte)3, null, (byte)2, null, (short)3450, (short)2021, 7 },
                    { 344, (byte)4, null, (byte)4, null, (byte)3, null, "4-Series, M4", (byte)2, null, (byte)4, null, (short)650, (short)2016, 2 },
                    { 345, (byte)1, null, (byte)1, null, (byte)1, null, "Sedan de Ville", (byte)3, null, (byte)1, null, (short)3450, (short)2021, 5 },
                    { 346, (byte)1, null, (byte)3, null, (byte)4, null, "Gol", (byte)2, null, (byte)2, null, (short)2200, (short)2019, 5 },
                    { 347, (byte)3, null, (byte)1, null, (byte)5, null, "XT5", (byte)3, null, (byte)3, null, (short)1600, (short)2017, 5 },
                    { 348, (byte)1, null, (byte)4, null, (byte)1, null, "Pride", (byte)2, null, (byte)4, null, (short)2300, (short)2018, 2 },
                    { 349, (byte)2, null, (byte)2, null, (byte)3, null, "XT5", (byte)4, null, (byte)3, null, (short)2050, (short)2017, 5 },
                    { 350, (byte)3, null, (byte)4, null, (byte)1, null, "Magentis / Optima / K5", (byte)1, null, (byte)2, null, (short)1750, (short)2022, 5 },
                    { 351, (byte)2, null, (byte)1, null, (byte)4, null, "Coupe de Ville", (byte)1, null, (byte)4, null, (short)1700, (short)2022, 2 },
                    { 352, (byte)2, null, (byte)3, null, (byte)2, null, "Seville", (byte)2, null, (byte)4, null, (short)1600, (short)2016, 7 },
                    { 353, (byte)4, null, (byte)2, null, (byte)4, null, "Picanto", (byte)3, null, (byte)2, null, (short)450, (short)2017, 2 },
                    { 354, (byte)2, null, (byte)3, null, (byte)4, null, "X6", (byte)3, null, (byte)1, null, (short)3250, (short)2017, 5 },
                    { 355, (byte)3, null, (byte)3, null, (byte)1, null, "SpaceFox / Suran / SportVan / Fox Plus", (byte)3, null, (byte)3, null, (short)900, (short)2019, 5 },
                    { 356, (byte)2, null, (byte)3, null, (byte)4, null, "7-Series", (byte)1, null, (byte)2, null, (short)1200, (short)2021, 7 },
                    { 357, (byte)4, null, (byte)3, null, (byte)2, null, "M1", (byte)3, null, (byte)4, null, (short)1850, (short)2015, 5 },
                    { 358, (byte)1, null, (byte)3, null, (byte)4, null, "5-Series, M5", (byte)4, null, (byte)2, null, (short)2950, (short)2018, 2 },
                    { 359, (byte)2, null, (byte)4, null, (byte)3, null, "5-Series, M5", (byte)1, null, (byte)1, null, (short)900, (short)2021, 2 },
                    { 360, (byte)1, null, (byte)1, null, (byte)5, null, "Bongo", (byte)2, null, (byte)2, null, (short)1650, (short)2021, 2 },
                    { 361, (byte)1, null, (byte)2, null, (byte)4, null, "SRX", (byte)4, null, (byte)4, null, (short)2650, (short)2018, 2 },
                    { 362, (byte)2, null, (byte)2, null, (byte)4, null, "3-Series, M3", (byte)3, null, (byte)3, null, (short)3250, (short)2017, 5 },
                    { 363, (byte)3, null, (byte)2, null, (byte)4, null, "Forte", (byte)4, null, (byte)2, null, (short)1800, (short)2017, 5 },
                    { 364, (byte)4, null, (byte)1, null, (byte)1, null, "Fleetwood", (byte)4, null, (byte)4, null, (short)2000, (short)2018, 5 },
                    { 365, (byte)2, null, (byte)4, null, (byte)4, null, "3-Series, M3", (byte)1, null, (byte)3, null, (short)3450, (short)2015, 2 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 366, (byte)3, null, (byte)3, null, (byte)4, null, "Series 61", (byte)1, null, (byte)3, null, (short)950, (short)2015, 2 },
                    { 367, (byte)2, null, (byte)1, null, (byte)5, null, "Series 75", (byte)3, null, (byte)3, null, (short)3050, (short)2019, 7 },
                    { 368, (byte)3, null, (byte)3, null, (byte)3, null, "5-Series", (byte)4, null, (byte)2, null, (short)2000, (short)2017, 5 },
                    { 369, (byte)3, null, (byte)4, null, (byte)3, null, "Sorento", (byte)4, null, (byte)3, null, (short)850, (short)2019, 7 },
                    { 370, (byte)2, null, (byte)3, null, (byte)2, null, "Seville", (byte)4, null, (byte)4, null, (short)3300, (short)2018, 2 },
                    { 371, (byte)2, null, (byte)1, null, (byte)4, null, "Voyage", (byte)2, null, (byte)3, null, (short)1900, (short)2021, 7 },
                    { 372, (byte)2, null, (byte)1, null, (byte)4, null, "Pride", (byte)4, null, (byte)4, null, (short)1550, (short)2018, 2 },
                    { 373, (byte)3, null, (byte)2, null, (byte)5, null, "Bongo Frontier", (byte)1, null, (byte)4, null, (short)1650, (short)2018, 7 },
                    { 374, (byte)2, null, (byte)4, null, (byte)5, null, "Coupe de Ville", (byte)2, null, (byte)2, null, (short)1900, (short)2017, 2 },
                    { 375, (byte)3, null, (byte)4, null, (byte)1, null, "Shuma", (byte)1, null, (byte)1, null, (short)1000, (short)2017, 2 },
                    { 376, (byte)4, null, (byte)2, null, (byte)2, null, "CT6", (byte)1, null, (byte)2, null, (short)1750, (short)2022, 7 },
                    { 377, (byte)3, null, (byte)1, null, (byte)3, null, "5-Series, M5", (byte)3, null, (byte)1, null, (short)3100, (short)2020, 5 },
                    { 378, (byte)3, null, (byte)1, null, (byte)2, null, "Sephia", (byte)2, null, (byte)3, null, (short)200, (short)2019, 7 },
                    { 379, (byte)1, null, (byte)1, null, (byte)4, null, "Parati", (byte)1, null, (byte)3, null, (short)1600, (short)2020, 7 },
                    { 380, (byte)4, null, (byte)1, null, (byte)4, null, "Picanto", (byte)1, null, (byte)3, null, (short)2000, (short)2022, 2 },
                    { 381, (byte)2, null, (byte)1, null, (byte)1, null, "8-Series", (byte)2, null, (byte)4, null, (short)2050, (short)2022, 2 },
                    { 382, (byte)3, null, (byte)4, null, (byte)1, null, "Series 60 (Sixty Special)", (byte)1, null, (byte)1, null, (short)3450, (short)2018, 5 },
                    { 383, (byte)2, null, (byte)3, null, (byte)5, null, "Carens", (byte)4, null, (byte)2, null, (short)1950, (short)2017, 2 },
                    { 384, (byte)3, null, (byte)4, null, (byte)2, null, "Z4", (byte)4, null, (byte)4, null, (short)1400, (short)2015, 7 },
                    { 385, (byte)4, null, (byte)3, null, (byte)1, null, "Parati", (byte)3, null, (byte)1, null, (short)3500, (short)2022, 7 },
                    { 386, (byte)4, null, (byte)4, null, (byte)2, null, "Fleetwood 75", (byte)1, null, (byte)1, null, (short)1200, (short)2015, 5 },
                    { 387, (byte)3, null, (byte)2, null, (byte)5, null, "6-Series, M6", (byte)3, null, (byte)3, null, (short)700, (short)2018, 5 },
                    { 388, (byte)3, null, (byte)2, null, (byte)3, null, "Magentis / Optima / K5", (byte)2, null, (byte)1, null, (short)2400, (short)2022, 7 },
                    { 389, (byte)2, null, (byte)4, null, (byte)4, null, "Series 60", (byte)4, null, (byte)3, null, (short)1750, (short)2015, 5 },
                    { 390, (byte)2, null, (byte)3, null, (byte)4, null, "Seville", (byte)4, null, (byte)2, null, (short)1350, (short)2017, 7 },
                    { 391, (byte)2, null, (byte)3, null, (byte)2, null, "Sedan de Ville", (byte)1, null, (byte)2, null, (short)900, (short)2018, 7 },
                    { 392, (byte)3, null, (byte)1, null, (byte)2, null, "Fox", (byte)3, null, (byte)1, null, (short)200, (short)2022, 7 },
                    { 393, (byte)3, null, (byte)4, null, (byte)1, null, "Bongo Frontier", (byte)3, null, (byte)3, null, (short)1950, (short)2022, 7 },
                    { 394, (byte)1, null, (byte)1, null, (byte)1, null, "Retona", (byte)2, null, (byte)1, null, (short)2550, (short)2021, 2 },
                    { 395, (byte)1, null, (byte)1, null, (byte)2, null, "Coupe de Ville", (byte)3, null, (byte)4, null, (short)1150, (short)2020, 5 },
                    { 396, (byte)4, null, (byte)4, null, (byte)2, null, "X3", (byte)1, null, (byte)3, null, (short)1300, (short)2021, 7 },
                    { 397, (byte)3, null, (byte)3, null, (byte)2, null, "Sorento", (byte)3, null, (byte)2, null, (short)2900, (short)2021, 2 },
                    { 398, (byte)3, null, (byte)4, null, (byte)5, null, "Sedan de Ville", (byte)1, null, (byte)1, null, (short)1950, (short)2016, 5 },
                    { 399, (byte)4, null, (byte)4, null, (byte)1, null, "Quoris / K9 / K900", (byte)1, null, (byte)3, null, (short)1350, (short)2019, 7 },
                    { 400, (byte)4, null, (byte)3, null, (byte)4, null, "Fleetwood", (byte)3, null, (byte)3, null, (short)600, (short)2018, 2 },
                    { 401, (byte)1, null, (byte)1, null, (byte)3, null, "Series 75", (byte)1, null, (byte)3, null, (short)1800, (short)2016, 2 },
                    { 402, (byte)2, null, (byte)4, null, (byte)4, null, "Forte / K3", (byte)4, null, (byte)2, null, (short)400, (short)2019, 5 },
                    { 403, (byte)3, null, (byte)4, null, (byte)1, null, "XT4", (byte)2, null, (byte)4, null, (short)1400, (short)2016, 2 },
                    { 404, (byte)4, null, (byte)1, null, (byte)2, null, "DTS", (byte)2, null, (byte)4, null, (short)550, (short)2021, 7 },
                    { 405, (byte)3, null, (byte)1, null, (byte)5, null, "Eldorado", (byte)4, null, (byte)3, null, (short)1500, (short)2020, 5 },
                    { 406, (byte)4, null, (byte)4, null, (byte)3, null, "Series 60 (Sixty Special)", (byte)1, null, (byte)2, null, (short)2200, (short)2017, 2 },
                    { 407, (byte)4, null, (byte)2, null, (byte)5, null, "Cadenza / K7", (byte)1, null, (byte)2, null, (short)700, (short)2020, 2 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 408, (byte)4, null, (byte)2, null, (byte)3, null, "Picanto", (byte)3, null, (byte)1, null, (short)1350, (short)2022, 7 },
                    { 409, (byte)2, null, (byte)2, null, (byte)4, null, "CT6", (byte)1, null, (byte)1, null, (short)3400, (short)2015, 5 },
                    { 410, (byte)1, null, (byte)3, null, (byte)3, null, "Carnival / Sedona", (byte)3, null, (byte)1, null, (short)1200, (short)2017, 5 },
                    { 411, (byte)1, null, (byte)1, null, (byte)1, null, "DTS", (byte)3, null, (byte)2, null, (short)1450, (short)2018, 5 },
                    { 412, (byte)4, null, (byte)1, null, (byte)2, null, "Escalade", (byte)3, null, (byte)1, null, (short)200, (short)2021, 5 },
                    { 413, (byte)1, null, (byte)4, null, (byte)5, null, "Sephia", (byte)3, null, (byte)4, null, (short)2050, (short)2018, 5 },
                    { 414, (byte)4, null, (byte)1, null, (byte)5, null, "Apollo", (byte)2, null, (byte)4, null, (short)2000, (short)2016, 5 },
                    { 415, (byte)2, null, (byte)3, null, (byte)2, null, "BLS", (byte)1, null, (byte)2, null, (short)2400, (short)2020, 7 },
                    { 416, (byte)3, null, (byte)1, null, (byte)2, null, "Sephia", (byte)1, null, (byte)3, null, (short)2550, (short)2016, 2 },
                    { 417, (byte)3, null, (byte)3, null, (byte)3, null, "Gol", (byte)4, null, (byte)1, null, (short)1300, (short)2021, 2 },
                    { 418, (byte)4, null, (byte)1, null, (byte)2, null, "X1", (byte)4, null, (byte)3, null, (short)150, (short)2022, 5 },
                    { 419, (byte)1, null, (byte)2, null, (byte)4, null, "Opirus / Amanti", (byte)1, null, (byte)3, null, (short)3400, (short)2022, 5 },
                    { 420, (byte)3, null, (byte)4, null, (byte)4, null, "Seville", (byte)3, null, (byte)3, null, (short)700, (short)2016, 7 },
                    { 421, (byte)2, null, (byte)2, null, (byte)1, null, "Eldorado", (byte)2, null, (byte)3, null, (short)2750, (short)2016, 2 },
                    { 422, (byte)2, null, (byte)4, null, (byte)3, null, "Eldorado", (byte)2, null, (byte)4, null, (short)3150, (short)2018, 2 },
                    { 423, (byte)3, null, (byte)4, null, (byte)5, null, "Sedan de Ville", (byte)4, null, (byte)1, null, (short)2950, (short)2020, 5 },
                    { 424, (byte)3, null, (byte)1, null, (byte)3, null, "New Six CS", (byte)2, null, (byte)1, null, (short)2250, (short)2020, 5 },
                    { 425, (byte)2, null, (byte)1, null, (byte)4, null, "SP2", (byte)2, null, (byte)2, null, (short)2900, (short)2017, 7 },
                    { 426, (byte)4, null, (byte)4, null, (byte)1, null, "Series 60 (Sixty Special)", (byte)1, null, (byte)1, null, (short)3250, (short)2022, 2 },
                    { 427, (byte)2, null, (byte)1, null, (byte)5, null, "5-Series GT", (byte)4, null, (byte)1, null, (short)2050, (short)2018, 7 },
                    { 428, (byte)4, null, (byte)2, null, (byte)4, null, "XTS", (byte)3, null, (byte)2, null, (short)1300, (short)2017, 7 },
                    { 429, (byte)1, null, (byte)1, null, (byte)3, null, "Series 60 (Sixty Special)", (byte)2, null, (byte)3, null, (short)3150, (short)2019, 5 },
                    { 430, (byte)1, null, (byte)4, null, (byte)4, null, "Cee'd", (byte)1, null, (byte)3, null, (short)2100, (short)2017, 2 },
                    { 431, (byte)3, null, (byte)4, null, (byte)1, null, "Joice", (byte)1, null, (byte)4, null, (short)2700, (short)2017, 2 },
                    { 432, (byte)2, null, (byte)4, null, (byte)5, null, "Sedan de Ville", (byte)1, null, (byte)3, null, (short)1100, (short)2021, 5 },
                    { 433, (byte)2, null, (byte)3, null, (byte)3, null, "Escalade", (byte)3, null, (byte)3, null, (short)550, (short)2015, 5 },
                    { 434, (byte)1, null, (byte)4, null, (byte)5, null, "Series 62", (byte)4, null, (byte)4, null, (short)2450, (short)2017, 5 },
                    { 435, (byte)3, null, (byte)3, null, (byte)3, null, "X6", (byte)3, null, (byte)1, null, (short)2550, (short)2019, 5 },
                    { 436, (byte)1, null, (byte)2, null, (byte)3, null, "Sedan de Ville", (byte)1, null, (byte)2, null, (short)3250, (short)2017, 7 },
                    { 437, (byte)1, null, (byte)4, null, (byte)3, null, "Eldorado", (byte)2, null, (byte)1, null, (short)2100, (short)2021, 7 },
                    { 438, (byte)3, null, (byte)3, null, (byte)4, null, "X3", (byte)1, null, (byte)4, null, (short)2500, (short)2015, 5 },
                    { 439, (byte)4, null, (byte)2, null, (byte)4, null, "Pride", (byte)4, null, (byte)3, null, (short)2000, (short)2019, 5 },
                    { 440, (byte)3, null, (byte)3, null, (byte)5, null, "Enterprise", (byte)2, null, (byte)1, null, (short)2300, (short)2020, 5 },
                    { 441, (byte)2, null, (byte)4, null, (byte)1, null, "New Six CS", (byte)1, null, (byte)3, null, (short)1400, (short)2015, 7 },
                    { 442, (byte)2, null, (byte)2, null, (byte)5, null, "Eldorado", (byte)3, null, (byte)1, null, (short)700, (short)2017, 7 },
                    { 443, (byte)3, null, (byte)1, null, (byte)1, null, "Forte / K3", (byte)2, null, (byte)4, null, (short)850, (short)2017, 5 },
                    { 444, (byte)2, null, (byte)4, null, (byte)1, null, "Eldorado", (byte)1, null, (byte)4, null, (short)2800, (short)2021, 7 },
                    { 445, (byte)1, null, (byte)3, null, (byte)1, null, "Series 60 (Sixty Special)", (byte)3, null, (byte)2, null, (short)3300, (short)2017, 7 },
                    { 446, (byte)1, null, (byte)1, null, (byte)4, null, "Concord", (byte)2, null, (byte)4, null, (short)2450, (short)2015, 2 },
                    { 447, (byte)1, null, (byte)3, null, (byte)3, null, "3-Series, M3", (byte)2, null, (byte)4, null, (short)2800, (short)2017, 2 },
                    { 448, (byte)4, null, (byte)1, null, (byte)1, null, "CTS", (byte)4, null, (byte)2, null, (short)300, (short)2021, 5 },
                    { 449, (byte)4, null, (byte)4, null, (byte)1, null, "SpaceFox / Suran / SportVan / Fox Plus", (byte)3, null, (byte)1, null, (short)1650, (short)2020, 7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 450, (byte)1, null, (byte)1, null, (byte)3, null, "Series 62", (byte)3, null, (byte)4, null, (short)2950, (short)2022, 2 },
                    { 451, (byte)2, null, (byte)4, null, (byte)2, null, "New Six CS", (byte)2, null, (byte)3, null, (short)850, (short)2022, 5 },
                    { 452, (byte)4, null, (byte)3, null, (byte)5, null, "Cadenza / K7", (byte)2, null, (byte)2, null, (short)2900, (short)2021, 5 },
                    { 453, (byte)4, null, (byte)2, null, (byte)5, null, "Cadenza / K7", (byte)2, null, (byte)3, null, (short)1800, (short)2018, 5 },
                    { 454, (byte)3, null, (byte)3, null, (byte)5, null, "Eldorado", (byte)1, null, (byte)4, null, (short)2200, (short)2017, 2 },
                    { 455, (byte)3, null, (byte)3, null, (byte)1, null, "Opirus / Amanti", (byte)1, null, (byte)1, null, (short)450, (short)2019, 2 },
                    { 456, (byte)1, null, (byte)1, null, (byte)2, null, "Sephia", (byte)3, null, (byte)4, null, (short)1100, (short)2019, 7 },
                    { 457, (byte)1, null, (byte)2, null, (byte)2, null, "M1", (byte)2, null, (byte)4, null, (short)1600, (short)2020, 7 },
                    { 458, (byte)1, null, (byte)3, null, (byte)3, null, "Bongo", (byte)1, null, (byte)3, null, (short)600, (short)2022, 7 },
                    { 459, (byte)3, null, (byte)1, null, (byte)4, null, "Z4", (byte)3, null, (byte)3, null, (short)350, (short)2021, 2 },
                    { 460, (byte)1, null, (byte)4, null, (byte)4, null, "Seville", (byte)4, null, (byte)2, null, (short)2250, (short)2020, 7 },
                    { 461, (byte)4, null, (byte)1, null, (byte)2, null, "Series 61", (byte)4, null, (byte)1, null, (short)1550, (short)2022, 7 },
                    { 462, (byte)3, null, (byte)1, null, (byte)5, null, "X3", (byte)1, null, (byte)1, null, (short)1400, (short)2018, 5 },
                    { 463, (byte)3, null, (byte)2, null, (byte)4, null, "Series 62", (byte)2, null, (byte)3, null, (short)650, (short)2015, 5 },
                    { 464, (byte)2, null, (byte)2, null, (byte)1, null, "SRX", (byte)4, null, (byte)1, null, (short)1300, (short)2021, 5 },
                    { 465, (byte)1, null, (byte)2, null, (byte)2, null, "Quantum", (byte)4, null, (byte)3, null, (short)2000, (short)2015, 2 },
                    { 466, (byte)1, null, (byte)1, null, (byte)3, null, "Shuma", (byte)4, null, (byte)2, null, (short)1200, (short)2019, 5 },
                    { 467, (byte)3, null, (byte)3, null, (byte)2, null, "Series 75", (byte)3, null, (byte)2, null, (short)1750, (short)2021, 2 },
                    { 468, (byte)1, null, (byte)2, null, (byte)3, null, "Carnival / Sedona", (byte)4, null, (byte)2, null, (short)600, (short)2019, 5 },
                    { 469, (byte)3, null, (byte)2, null, (byte)3, null, "Cimarron", (byte)4, null, (byte)2, null, (short)2800, (short)2019, 7 },
                    { 470, (byte)2, null, (byte)3, null, (byte)3, null, "4-Series, M4", (byte)1, null, (byte)4, null, (short)3200, (short)2016, 2 },
                    { 471, (byte)3, null, (byte)3, null, (byte)3, null, "Seville", (byte)2, null, (byte)3, null, (short)1000, (short)2015, 2 },
                    { 472, (byte)3, null, (byte)2, null, (byte)3, null, "Cee'd", (byte)3, null, (byte)2, null, (short)1250, (short)2016, 7 },
                    { 473, (byte)2, null, (byte)1, null, (byte)5, null, "X6", (byte)2, null, (byte)1, null, (short)500, (short)2019, 2 },
                    { 474, (byte)3, null, (byte)3, null, (byte)1, null, "Gol", (byte)3, null, (byte)1, null, (short)2900, (short)2020, 2 },
                    { 475, (byte)3, null, (byte)2, null, (byte)2, null, "Quantum", (byte)3, null, (byte)2, null, (short)2050, (short)2020, 2 },
                    { 476, (byte)4, null, (byte)1, null, (byte)3, null, "X4", (byte)1, null, (byte)3, null, (short)3250, (short)2017, 5 },
                    { 477, (byte)2, null, (byte)1, null, (byte)3, null, "Gol", (byte)3, null, (byte)2, null, (short)2150, (short)2022, 5 },
                    { 478, (byte)2, null, (byte)4, null, (byte)1, null, "X3", (byte)1, null, (byte)4, null, (short)1050, (short)2022, 5 },
                    { 479, (byte)3, null, (byte)3, null, (byte)5, null, "ATS", (byte)2, null, (byte)1, null, (short)1000, (short)2017, 2 },
                    { 480, (byte)1, null, (byte)3, null, (byte)4, null, "XT4", (byte)3, null, (byte)1, null, (short)2200, (short)2017, 7 },
                    { 481, (byte)2, null, (byte)2, null, (byte)3, null, "Coupe de Ville", (byte)1, null, (byte)1, null, (short)700, (short)2016, 7 },
                    { 482, (byte)4, null, (byte)2, null, (byte)1, null, "Bongo", (byte)3, null, (byte)4, null, (short)3200, (short)2016, 7 },
                    { 483, (byte)3, null, (byte)4, null, (byte)4, null, "Series 75", (byte)3, null, (byte)1, null, (short)1950, (short)2019, 2 },
                    { 484, (byte)1, null, (byte)3, null, (byte)5, null, "Rio", (byte)3, null, (byte)2, null, (short)2700, (short)2017, 7 },
                    { 485, (byte)3, null, (byte)4, null, (byte)3, null, "Eldorado", (byte)1, null, (byte)1, null, (short)1850, (short)2019, 7 },
                    { 486, (byte)1, null, (byte)3, null, (byte)2, null, "Sephia", (byte)4, null, (byte)1, null, (short)3200, (short)2021, 5 },
                    { 487, (byte)1, null, (byte)3, null, (byte)5, null, "Gol", (byte)4, null, (byte)1, null, (short)3200, (short)2018, 2 },
                    { 488, (byte)4, null, (byte)1, null, (byte)3, null, "Cee'd", (byte)2, null, (byte)3, null, (short)450, (short)2022, 7 },
                    { 489, (byte)2, null, (byte)1, null, (byte)5, null, "X3", (byte)1, null, (byte)3, null, (short)3000, (short)2015, 2 },
                    { 490, (byte)3, null, (byte)3, null, (byte)5, null, "Pride", (byte)2, null, (byte)4, null, (short)1100, (short)2021, 5 },
                    { 491, (byte)3, null, (byte)3, null, (byte)4, null, "Eldorado", (byte)1, null, (byte)2, null, (short)1100, (short)2017, 5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BodyTypeID1", "BrandID", "BrandID1", "CarColorID", "CarColorID1", "CarModel", "FuelTypeID", "FuelTypeID1", "GearTypeID", "GearTypeID1", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 492, (byte)3, null, (byte)3, null, (byte)2, null, "Series 62", (byte)4, null, (byte)1, null, (short)450, (short)2018, 2 },
                    { 493, (byte)2, null, (byte)4, null, (byte)1, null, "X1", (byte)3, null, (byte)3, null, (short)2550, (short)2021, 2 },
                    { 494, (byte)4, null, (byte)2, null, (byte)3, null, "i3", (byte)1, null, (byte)1, null, (short)3250, (short)2019, 2 },
                    { 495, (byte)2, null, (byte)1, null, (byte)5, null, "Fox", (byte)4, null, (byte)1, null, (short)750, (short)2015, 2 },
                    { 496, (byte)4, null, (byte)2, null, (byte)1, null, "4-Series, M4", (byte)3, null, (byte)4, null, (short)1850, (short)2017, 5 },
                    { 497, (byte)4, null, (byte)1, null, (byte)4, null, "Sephia", (byte)4, null, (byte)3, null, (short)2950, (short)2021, 7 },
                    { 498, (byte)4, null, (byte)3, null, (byte)5, null, "Sedan de Ville", (byte)1, null, (byte)3, null, (short)2200, (short)2015, 5 }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "FuelTypeID", "FuelTypeName" },
                values: new object[,]
                {
                    { 1, "Elektrik" },
                    { 2, "Benzin" },
                    { 3, "Dizel" },
                    { 4, "Hibrit" }
                });

            migrationBuilder.InsertData(
                table: "GearTypes",
                columns: new[] { "GearTypeID", "GearTypeName" },
                values: new object[,]
                {
                    { 1, "Otomatik" },
                    { 2, "Manuel" },
                    { 3, "Tiptritonik" },
                    { 4, "Hibrit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BodyTypeID1",
                table: "Cars",
                column: "BodyTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandID1",
                table: "Cars",
                column: "BrandID1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarColorID1",
                table: "Cars",
                column: "CarColorID1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeID1",
                table: "Cars",
                column: "FuelTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GearTypeID1",
                table: "Cars",
                column: "GearTypeID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "BodyType");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarColors");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "GearTypes");
        }
    }
}
