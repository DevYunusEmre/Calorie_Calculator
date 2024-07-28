using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NES_Core_CalorieCalculator.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InititalCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutrientCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NutrientId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutrientCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionDiaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    NutrientId = table.Column<int>(type: "int", nullable: false),
                    UserInfoId = table.Column<int>(type: "int", nullable: false),
                    Calorie = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionDiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Bmi = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Calorie = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutrientCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutrients_NutrientCategories_NutrientCategoryId",
                        column: x => x.NutrientCategoryId,
                        principalTable: "NutrientCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealNutritionDiaries",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false),
                    NutritionDiaryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealNutritionDiaries", x => new { x.MealId, x.NutritionDiaryId });
                    table.ForeignKey(
                        name: "FK_MealNutritionDiaries_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealNutritionDiaries_NutritionDiaries_NutritionDiaryId",
                        column: x => x.NutritionDiaryId,
                        principalTable: "NutritionDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInfoNutrientDiaries",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "int", nullable: false),
                    NutrientDiaryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoNutrientDiaries", x => new { x.UserInfoId, x.NutrientDiaryId });
                    table.ForeignKey(
                        name: "FK_UserInfoNutrientDiaries_NutritionDiaries_NutrientDiaryId",
                        column: x => x.NutrientDiaryId,
                        principalTable: "NutritionDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInfoNutrientDiaries_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutrientNutritionDiaries",
                columns: table => new
                {
                    NutrientId = table.Column<int>(type: "int", nullable: false),
                    NutritionDiaryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: false),
                    DropDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutrientNutritionDiaries", x => new { x.NutrientId, x.NutritionDiaryId });
                    table.ForeignKey(
                        name: "FK_NutrientNutritionDiaries_Nutrients_NutrientId",
                        column: x => x.NutrientId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutrientNutritionDiaries_NutritionDiaries_NutritionDiaryId",
                        column: x => x.NutritionDiaryId,
                        principalTable: "NutritionDiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreateDate", "DropDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 10, 15, 57, 14, 283, DateTimeKind.Local).AddTicks(9451), null, "Breakfast", "Created" },
                    { 2, new DateTime(2024, 7, 10, 15, 57, 14, 283, DateTimeKind.Local).AddTicks(9463), null, "Lunch", "Created" },
                    { 3, new DateTime(2024, 7, 10, 15, 57, 14, 283, DateTimeKind.Local).AddTicks(9463), null, "Dinner", "Created" },
                    { 4, new DateTime(2024, 7, 10, 15, 57, 14, 283, DateTimeKind.Local).AddTicks(9464), null, "Other", "Created" }
                });

            migrationBuilder.InsertData(
                table: "NutrientCategories",
                columns: new[] { "Id", "CreateDate", "DropDate", "Name", "NutrientId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6015), null, "Vegetable", 0, "Created" },
                    { 2, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6020), null, "Fruit", 0, "Created" },
                    { 3, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6021), null, "Soft Drink", 0, "Created" },
                    { 4, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6021), null, "Alcohol", 0, "Created" },
                    { 5, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6022), null, "Snack", 0, "Created" },
                    { 6, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6023), null, "Dessert", 0, "Created" },
                    { 7, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6023), null, "Salad", 0, "Created" },
                    { 8, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6024), null, "Dairy", 0, "Created" },
                    { 9, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6025), null, "Fish and Seafood", 0, "Created" },
                    { 10, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6025), null, "Fast Food", 0, "Created" },
                    { 11, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6026), null, "Meat or Poultry", 0, "Created" },
                    { 12, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6027), null, "Grain, Bean and Nuts", 0, "Created" },
                    { 13, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(6027), null, "Others", 0, "Created" }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "BirthDate", "Bmi", "CreateDate", "DropDate", "Email", "Gender", "Height", "Name", "Password", "Status", "Surname", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 7, 10, 15, 57, 14, 285, DateTimeKind.Local).AddTicks(1881), null, "yunuzbaba@gmail.com", "Male", 177m, "Yunus Emre", "abc123", "Created", "Bulut", 90m },
                    { 2, new DateTime(1999, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 7, 10, 15, 57, 14, 285, DateTimeKind.Local).AddTicks(1957), null, "kral@gmail.com", "Male", 175m, "Semih", "wxy123", "Created", "Önol", 80m },
                    { 3, new DateTime(1997, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 7, 10, 15, 57, 14, 285, DateTimeKind.Local).AddTicks(1964), null, "dataPatlatan@gmail.com", "Female", 170m, "Güneş", "cokGizli123", "Created", "Bahar", 50m }
                });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "Calorie", "CreateDate", "DropDate", "Name", "NutrientCategoryId", "Picture", "Status" },
                values: new object[,]
                {
                    { 1, 60m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4647), null, "Artichoke", 1, "\\FoodPhotos\\1.jpg", "Created" },
                    { 2, 50m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4654), null, "Arugula", 1, "\\FoodPhotos\\2.jpg", "Created" },
                    { 3, 2m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4655), null, "Asparagus", 1, "\\FoodPhotos\\3.jpg", "Created" },
                    { 4, 115m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4656), null, "Aubergine", 1, "\\FoodPhotos\\4.jpg", "Created" },
                    { 5, 35m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4657), null, "Beetroot", 1, "\\FoodPhotos\\5.jpg", "Created" },
                    { 6, 15m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4658), null, "Bell Pepper", 1, "\\FoodPhotos\\6.jpg", "Created" },
                    { 7, 2m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4659), null, "Black Olives", 1, "\\FoodPhotos\\7.jpg", "Created" },
                    { 8, 35m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4660), null, "Broccoli", 1, "\\FoodPhotos\\8.jpg", "Created" },
                    { 9, 40m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4661), null, "Brussels Sprouts", 1, "\\FoodPhotos\\9.jpg", "Created" },
                    { 10, 227m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4662), null, "Cabbage", 1, "\\FoodPhotos\\10.jpg", "Created" },
                    { 11, 12m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4663), null, "Capsicum", 1, "\\FoodPhotos\\11.jpg", "Created" },
                    { 12, 25m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4664), null, "Carrot", 1, "\\FoodPhotos\\12.jpg", "Created" },
                    { 13, 3m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4665), null, "Cauliflower", 1, "\\FoodPhotos\\13.jpg", "Created" },
                    { 14, 42m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4665), null, "Celery", 1, "\\FoodPhotos\\14.jpg", "Created" },
                    { 15, 20m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4666), null, "Cherry Tomato", 1, "\\FoodPhotos\\15.jpg", "Created" },
                    { 16, 134m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4667), null, "Chinese Cabbage", 1, "\\FoodPhotos\\16.jpg", "Created" },
                    { 17, 32m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4668), null, "Collard Greens", 1, "\\FoodPhotos\\17.jpg", "Created" },
                    { 18, 96m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4669), null, "Corn", 1, "\\FoodPhotos\\18.jpg", "Created" },
                    { 19, 20m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4670), null, "Courgette", 1, "\\FoodPhotos\\19.jpg", "Created" },
                    { 20, 15m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4671), null, "Cucumber", 1, "\\FoodPhotos\\20.jpg", "Created" },
                    { 21, 336m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4672), null, "Salami", 11, "\\FoodPhotos\\21.jpg", "Created" },
                    { 22, 17m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4673), null, "Endive", 1, "\\FoodPhotos\\22.jpg", "Created" },
                    { 23, 32m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4673), null, "Fennel", 1, "\\FoodPhotos\\23.jpg", "Created" },
                    { 24, 4m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4674), null, "Garlic", 1, "\\FoodPhotos\\24.jpg", "Created" },
                    { 25, 9m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4675), null, "Gherkin", 1, "\\FoodPhotos\\25.jpg", "Created" },
                    { 26, 108m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4676), null, "Gourd", 1, "\\FoodPhotos\\26.jpg", "Created" },
                    { 27, 32m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4677), null, "Green Beans", 1, "\\FoodPhotos\\27.jpg", "Created" },
                    { 28, 2m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4679), null, "Green Olives", 1, "\\FoodPhotos\\28.jpg", "Created" },
                    { 29, 5m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4680), null, "Green Onion", 1, "\\FoodPhotos\\29.jpg", "Created" },
                    { 30, 7m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4681), null, "Horseradish", 1, "\\FoodPhotos\\30.jpg", "Created" },
                    { 31, 43m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4681), null, "Kale", 1, "\\FoodPhotos\\31.jpg", "Created" },
                    { 32, 54m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4682), null, "Leek", 1, "\\FoodPhotos\\32.jpg", "Created" },
                    { 33, 109m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4683), null, "Lettuce", 1, "\\FoodPhotos\\33.jpg", "Created" },
                    { 34, 1m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4684), null, "Mushrooms", 1, "\\FoodPhotos\\34.jpg", "Created" },
                    { 35, 28m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4685), null, "Mustard Greens", 1, "\\FoodPhotos\\35.jpg", "Created" },
                    { 36, 33m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4686), null, "Okra", 1, "\\FoodPhotos\\36.jpg", "Created" },
                    { 37, 300m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4687), null, "Sausage", 11, "\\FoodPhotos\\37.jpg", "Created" },
                    { 38, 34m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4688), null, "Onion", 1, "\\FoodPhotos\\38.jpg", "Created" },
                    { 39, 128m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4689), null, "Parsnips", 1, "\\FoodPhotos\\39.jpg", "Created" },
                    { 40, 81m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4691), null, "Peas", 1, "\\FoodPhotos\\40.jpg", "Created" },
                    { 41, 29m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4691), null, "Bacon", 11, "\\FoodPhotos\\41.jpg", "Created" },
                    { 42, 164m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4692), null, "Potato", 1, "\\FoodPhotos\\42.jpg", "Created" },
                    { 43, 51m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4693), null, "Pumpkin", 1, "\\FoodPhotos\\43.jpg", "Created" },
                    { 44, 15m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4694), null, "Radishes", 1, "\\FoodPhotos\\44.jpg", "Created" },
                    { 45, 260m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4695), null, "Red Cabbage", 1, "\\FoodPhotos\\45.jpg", "Created" },
                    { 46, 147m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4696), null, "Rutabaga", 1, "\\FoodPhotos\\46.jpg", "Created" },
                    { 47, 18m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4697), null, "Shallots", 1, "\\FoodPhotos\\47.jpg", "Created" },
                    { 48, 130m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4698), null, "Squash", 1, "\\FoodPhotos\\48.jpg", "Created" },
                    { 49, 112m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4699), null, "Sweet Potato", 1, "\\FoodPhotos\\49.jpg", "Created" },
                    { 50, 20m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4700), null, "Tomato", 1, "\\FoodPhotos\\50.jpg", "Created" },
                    { 51, 34m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4701), null, "Turnip", 1, "\\FoodPhotos\\51.jpg", "Created" },
                    { 52, 95m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4702), null, "Apple", 2, "\\FoodPhotos\\52.jpg", "Created" },
                    { 53, 17m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4703), null, "Apricot", 2, "\\FoodPhotos\\53.jpg", "Created" },
                    { 54, 240m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4704), null, "Avocado", 2, "\\FoodPhotos\\54.jpg", "Created" },
                    { 55, 111m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4705), null, "Banana", 2, "\\FoodPhotos\\55.jpg", "Created" },
                    { 56, 43m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4705), null, "Blackberries", 2, "\\FoodPhotos\\56.jpg", "Created" },
                    { 57, 70m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4706), null, "Blood Oranges", 2, "\\FoodPhotos\\57.jpg", "Created" },
                    { 58, 84m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4707), null, "Blueberries", 2, "\\FoodPhotos\\58.jpg", "Created" },
                    { 59, 34m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4708), null, "Cantaloupe", 2, "\\FoodPhotos\\59.jpg", "Created" },
                    { 60, 4m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4709), null, "Cherries", 2, "\\FoodPhotos\\60.jpg", "Created" },
                    { 61, 46m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4710), null, "Cranberries", 2, "\\FoodPhotos\\61.jpg", "Created" },
                    { 62, 20m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4711), null, "Dates", 2, "\\FoodPhotos\\62.jpg", "Created" },
                    { 63, 37m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4712), null, "Figs", 2, "\\FoodPhotos\\63.jpg", "Created" },
                    { 64, 125m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4712), null, "Fruit salad", 7, "\\FoodPhotos\\64.jpg", "Created" },
                    { 65, 67m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4713), null, "Grapes", 2, "\\FoodPhotos\\65.jpg", "Created" },
                    { 66, 112m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4714), null, "Kiwi", 2, "\\FoodPhotos\\66.jpg", "Created" },
                    { 67, 17m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4716), null, "Lemon", 2, "\\FoodPhotos\\67.jpg", "Created" },
                    { 68, 20m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4717), null, "Lime", 2, "\\FoodPhotos\\68.jpg", "Created" },
                    { 69, 7m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4718), null, "Lychees", 2, "\\FoodPhotos\\69.jpg", "Created" },
                    { 70, 47m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4719), null, "Mandarin Oranges", 2, "\\FoodPhotos\\70.jpg", "Created" },
                    { 71, 202m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4720), null, "Mango", 2, "\\FoodPhotos\\71.jpg", "Created" },
                    { 72, 66m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4720), null, "Nectarine", 2, "\\FoodPhotos\\72.jpg", "Created" },
                    { 73, 62m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4721), null, "Orange", 2, "\\FoodPhotos\\73.jpg", "Created" },
                    { 74, 215m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4722), null, "Papaya", 2, "\\FoodPhotos\\74.jpg", "Created" },
                    { 75, 17m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4723), null, "Passion Fruit", 2, "\\FoodPhotos\\75.jpg", "Created" },
                    { 76, 59m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4724), null, "Peach", 2, "\\FoodPhotos\\76.jpg", "Created" },
                    { 77, 101m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4725), null, "Pear", 2, "\\FoodPhotos\\77.jpg", "Created" },
                    { 78, 50m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4726), null, "Pineapple", 2, "\\FoodPhotos\\78.jpg", "Created" },
                    { 79, 30m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4726), null, "Plum", 2, "\\FoodPhotos\\79.jpg", "Created" },
                    { 80, 234m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4727), null, "Pomegranate", 2, "\\FoodPhotos\\80.jpg", "Created" },
                    { 81, 300m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4728), null, "Raisins", 5, "\\FoodPhotos\\81.jpg", "Created" },
                    { 82, 64m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4729), null, "Raspberries", 2, "\\FoodPhotos\\82.jpg", "Created" },
                    { 83, 49m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4732), null, "Strawberries", 2, "\\FoodPhotos\\83.jpg", "Created" },
                    { 84, 47m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4733), null, "Tangerine", 2, "\\FoodPhotos\\84.jpg", "Created" },
                    { 85, 86m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4734), null, "Watermelon", 2, "\\FoodPhotos\\85.jpg", "Created" },
                    { 86, 680m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4735), null, "Bacon and Eggs", 8, "\\FoodPhotos\\86.jpg", "Created" },
                    { 87, 150m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4737), null, "Baked Beans", 12, "\\FoodPhotos\\87.jpg", "Created" },
                    { 88, 360m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4738), null, "BBQ Ribs", 11, "\\FoodPhotos\\88.jpg", "Created" },
                    { 89, 186m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4739), null, "Beef Stew", 11, "\\FoodPhotos\\89.jpg", "Created" },
                    { 90, 170m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4740), null, "Black Rice", 12, "\\FoodPhotos\\90.jpg", "Created" },
                    { 91, 110m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4740), null, "Brown Rice", 12, "\\FoodPhotos\\91.jpg", "Created" },
                    { 92, 326m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4741), null, "Burrito", 10, "\\FoodPhotos\\92.jpg", "Created" },
                    { 93, 33m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4742), null, "California Roll", 9, "\\FoodPhotos\\93.jpg", "Created" },
                    { 94, 309m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4743), null, "Chicken Caesar Salad", 7, "\\FoodPhotos\\94.jpg", "Created" },
                    { 95, 290m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4744), null, "Chicken Marsala", 11, "\\FoodPhotos\\95.jpg", "Created" },
                    { 96, 350m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4745), null, "Chicken Tikka Masala", 11, "\\FoodPhotos\\96.jpg", "Created" },
                    { 97, 308m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4746), null, "Chimichanga", 11, "\\FoodPhotos\\97.jpg", "Created" },
                    { 98, 160m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4747), null, "Cobb Salad", 7, "\\FoodPhotos\\98.jpg", "Created" },
                    { 99, 180m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4748), null, "Corn Dog", 10, "\\FoodPhotos\\99.jpg", "Created" },
                    { 100, 300m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4748), null, "Cottage Pie", 6, "\\FoodPhotos\\100.jpg", "Created" },
                    { 101, 323m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4749), null, "Enchiladas", 11, "\\FoodPhotos\\101.jpg", "Created" },
                    { 102, 290m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4750), null, "Fajita", 11, "\\FoodPhotos\\102.jpg", "Created" },
                    { 103, 585m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4751), null, "Fish and Chips", 9, "\\FoodPhotos\\103.jpg", "Created" },
                    { 104, 662m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4752), null, "Fried Rice", 12, "\\FoodPhotos\\104.jpg", "Created" },
                    { 105, 75m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4753), null, "Fried Shrimp", 9, "\\FoodPhotos\\105.jpg", "Created" },
                    { 106, 392m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4755), null, "Grilled Cheese Sandwich", 10, "\\FoodPhotos\\106.jpg", "Created" },
                    { 107, 352m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4755), null, "Ham and Cheese Sandwich", 10, "\\FoodPhotos\\107.jpg", "Created" },
                    { 108, 774m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4756), null, "Kebab", 11, "\\FoodPhotos\\108.jpg", "Created" },
                    { 109, 284m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4757), null, "Lasagne", 10, "\\FoodPhotos\\109.jpg", "Created" },
                    { 110, 699m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4758), null, "Mac and Cheese", 10, "\\FoodPhotos\\110.jpg", "Created" },
                    { 111, 420m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4759), null, "Orange Chicken", 11, "\\FoodPhotos\\111.jpg", "Created" },
                    { 112, 375m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4760), null, "Pad Thai", 10, "\\FoodPhotos\\112.jpg", "Created" },
                    { 113, 190m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4761), null, "Pea Soup", 13, "\\FoodPhotos\\113.jpg", "Created" },
                    { 114, 200m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4762), null, "Peanut Butter Sandwich", 10, "\\FoodPhotos\\114.jpg", "Created" },
                    { 115, 300m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4762), null, "Philly Cheese Steak", 11, "\\FoodPhotos\\115.jpg", "Created" },
                    { 116, 272m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4763), null, "Pizza", 10, "\\FoodPhotos\\116.jpg", "Created" },
                    { 117, 300m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4764), null, "Potato Salad", 7, "\\FoodPhotos\\117.jpg", "Created" },
                    { 118, 500m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4765), null, "Ramen", 10, "\\FoodPhotos\\118.jpg", "Created" },
                    { 119, 370m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4766), null, "Ravioli", 10, "\\FoodPhotos\\119.jpg", "Created" },
                    { 120, 641m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4767), null, "Reuben Sandwich", 10, "\\FoodPhotos\\120.jpg", "Created" },
                    { 121, 110m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4768), null, "Roast Beef", 11, "\\FoodPhotos\\121.jpg", "Created" },
                    { 122, 374m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4768), null, "Spaghetti Bolognese", 10, "\\FoodPhotos\\122.jpg", "Created" },
                    { 123, 213m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4769), null, "Taco", 10, "\\FoodPhotos\\123.jpg", "Created" },
                    { 124, 309m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4770), null, "BBQ Chicken Pizza", 10, "\\FoodPhotos\\124.jpg", "Created" },
                    { 125, 314m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4771), null, "BBQ Pizza", 10, "\\FoodPhotos\\125.jpg", "Created" },
                    { 126, 714m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4773), null, "Beef Pizza", 10, "\\FoodPhotos\\126.jpg", "Created" },
                    { 127, 460m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4774), null, "Bianca Pizza", 10, "\\FoodPhotos\\127.jpg", "Created" },
                    { 128, 600m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4775), null, "Buffalo Chicken Pizza", 10, "\\FoodPhotos\\128.jpg", "Created" },
                    { 129, 168m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4776), null, "Cheese Pizza", 10, "\\FoodPhotos\\129.jpg", "Created" },
                    { 130, 309m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4776), null, "Chicken Pizza", 10, "\\FoodPhotos\\130.jpg", "Created" },
                    { 131, 313m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4777), null, "Deep Dish Pizza", 10, "\\FoodPhotos\\131.jpg", "Created" },
                    { 132, 138m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4778), null, "Goat Cheese Pizza", 10, "\\FoodPhotos\\132.jpg", "Created" },
                    { 133, 280m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4779), null, "Grilled Pizza", 10, "\\FoodPhotos\\133.jpg", "Created" },
                    { 134, 154m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4780), null, "Hawaiian Pizza", 10, "\\FoodPhotos\\134.jpg", "Created" },
                    { 135, 173m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4781), null, "Margherita Pizza", 10, "\\FoodPhotos\\135.jpg", "Created" },
                    { 136, 154m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4782), null, "Mozzarella Pizza", 10, "\\FoodPhotos\\136.jpg", "Created" },
                    { 137, 611m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4782), null, "Mushroom Pizza", 10, "\\FoodPhotos\\137.jpg", "Created" },
                    { 138, 248m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4783), null, "Napoli Pizza", 10, "\\FoodPhotos\\138.jpg", "Created" },
                    { 139, 174m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4784), null, "New York Style Pizza", 10, "\\FoodPhotos\\139.jpg", "Created" },
                    { 140, 181m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4785), null, "Pepperoni Pizza", 10, "\\FoodPhotos\\140.jpg", "Created" },
                    { 141, 380m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4786), null, "Pizza Hut Stuffed Crust Pizza", 10, "\\FoodPhotos\\141.jpg", "Created" },
                    { 142, 305m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4787), null, "Pizza Hut Supreme Pizza", 10, "\\FoodPhotos\\142.jpg", "Created" },
                    { 143, 330m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4788), null, "Quattro Formaggi Pizza", 10, "\\FoodPhotos\\143.jpg", "Created" },
                    { 144, 165m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4788), null, "Red Pepper Pizza", 10, "\\FoodPhotos\\144.jpg", "Created" },
                    { 145, 181m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4789), null, "Salami Pizza", 10, "\\FoodPhotos\\145.jpg", "Created" },
                    { 146, 177m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4791), null, "Sausage Pizza", 10, "\\FoodPhotos\\146.jpg", "Created" },
                    { 147, 186m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4792), null, "Seafood Pizza", 10, "\\FoodPhotos\\147.jpg", "Created" },
                    { 148, 190m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4793), null, "Shrimp Pizza", 10, "\\FoodPhotos\\148.jpg", "Created" },
                    { 149, 321m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4794), null, "Sicilian Pizza", 10, "\\FoodPhotos\\149.jpg", "Created" },
                    { 150, 150m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4794), null, "Spinach Feta Pizza", 10, "\\FoodPhotos\\150.jpg", "Created" },
                    { 151, 145m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4795), null, "Spinach Pizza", 10, "\\FoodPhotos\\151.jpg", "Created" },
                    { 152, 380m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4796), null, "Stuffed Crust Pizza", 10, "\\FoodPhotos\\152.jpg", "Created" },
                    { 153, 157m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4797), null, "Thin Crust Pizza", 10, "\\FoodPhotos\\153.jpg", "Created" },
                    { 154, 318m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4798), null, "Tuna Pizza", 10, "\\FoodPhotos\\154.jpg", "Created" },
                    { 155, 263m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4799), null, "Veggie Pizza", 10, "\\FoodPhotos\\155.jpg", "Created" },
                    { 156, 740m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4800), null, "Burger King Angry Whopper", 10, "\\FoodPhotos\\156.jpg", "Created" },
                    { 157, 894m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4800), null, "Burger King Double Whopper", 10, "\\FoodPhotos\\157.jpg", "Created" },
                    { 158, 994m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4801), null, "Burger King Double Whopper with Cheese", 10, "\\FoodPhotos\\158.jpg", "Created" },
                    { 159, 659m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4802), null, "Burger King Original Chicken Sandwich", 10, "\\FoodPhotos\\159.jpg", "Created" },
                    { 160, 591m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4803), null, "Burger King Premium Alaskan Fish Sandwich", 10, "\\FoodPhotos\\160.jpg", "Created" },
                    { 161, 1471m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4804), null, "Burger King Triple Whopper", 10, "\\FoodPhotos\\161.jpg", "Created" },
                    { 162, 6272m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4805), null, "Burger King Whopper", 10, "\\FoodPhotos\\162.jpg", "Created" },
                    { 163, 346m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4805), null, "Burger King Whopper Jr.", 10, "\\FoodPhotos\\163.jpg", "Created" },
                    { 164, 759m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4806), null, "Burger King Whopper with Cheese", 10, "\\FoodPhotos\\164.jpg", "Created" },
                    { 165, 410m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4808), null, "Cheeseburger", 10, "\\FoodPhotos\\165.jpg", "Created" },
                    { 166, 170m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4809), null, "Chicken Breast", 11, "\\FoodPhotos\\166.jpg", "Created" },
                    { 167, 59m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4810), null, "Chicken Nuggets", 10, "\\FoodPhotos\\167.jpg", "Created" },
                    { 168, 410m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4812), null, "Chicken Sandwich", 10, "\\FoodPhotos\\168.jpg", "Created" },
                    { 169, 367m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4813), null, "Chicken Teriyaki Sandwich", 10, "\\FoodPhotos\\169.jpg", "Created" },
                    { 170, 94m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4814), null, "Chicken Wings", 10, "\\FoodPhotos\\170.jpg", "Created" },
                    { 171, 398m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4815), null, "Curly Fries", 10, "\\FoodPhotos\\171.jpg", "Created" },
                    { 172, 414m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4816), null, "Double Cheeseburger", 10, "\\FoodPhotos\\172.jpg", "Created" },
                    { 173, 222m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4817), null, "French Fries", 10, "\\FoodPhotos\\173.jpg", "Created" },
                    { 174, 268m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4818), null, "Grilled Chicken Salad", 7, "\\FoodPhotos\\174.jpg", "Created" },
                    { 175, 279m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4819), null, "Hamburger", 10, "\\FoodPhotos\\175.jpg", "Created" },
                    { 176, 312m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4819), null, "Hot Dog", 10, "\\FoodPhotos\\176.jpg", "Created" },
                    { 177, 481m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4820), null, "Meatball Sandwich", 10, "\\FoodPhotos\\177.jpg", "Created" },
                    { 178, 25m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4821), null, "Onion Rings", 10, "\\FoodPhotos\\178.jpg", "Created" },
                    { 179, 195m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4822), null, "Smoked Salmon", 9, "\\FoodPhotos\\179.jpg", "Created" },
                    { 180, 312m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4823), null, "Subway Club Sandwich", 10, "\\FoodPhotos\\180.jpg", "Created" },
                    { 181, 171m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4824), null, "Tortilla Wrap", 10, "\\FoodPhotos\\181.jpg", "Created" },
                    { 182, 94m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4824), null, "Tuna", 9, "\\FoodPhotos\\182.jpg", "Created" },
                    { 183, 135m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4825), null, "Turkey", 11, "\\FoodPhotos\\183.jpg", "Created" },
                    { 184, 389m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4826), null, "Veggie Burger", 10, "\\FoodPhotos\\184.jpg", "Created" },
                    { 185, 517m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4828), null, "Zinger", 10, "\\FoodPhotos\\185.jpg", "Created" },
                    { 186, 68m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4829), null, "Egg", 11, "\\FoodPhotos\\186.jpg", "Created" },
                    { 187, 160m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4830), null, "Steak", 11, "\\FoodPhotos\\187.jpg", "Created" },
                    { 188, 375m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4830), null, "Cornflakes", 13, "\\FoodPhotos\\188.jpg", "Created" },
                    { 189, 135m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4831), null, "Ice Cream Vanilla", 6, "\\FoodPhotos\\189.jpg", "Created" },
                    { 190, 168m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4832), null, "Ice Cream Chocolate", 6, "\\FoodPhotos\\190.jpg", "Created" },
                    { 191, 135m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4833), null, "Frozen Yogurt", 5, "\\FoodPhotos\\191.jpg", "Created" },
                    { 192, 60m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4834), null, "Yogurt", 8, "\\FoodPhotos\\192.jpg", "Created" },
                    { 193, 235m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4835), null, "Eclair", 6, "\\FoodPhotos\\193.jpg", "Created" },
                    { 194, 350m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4836), null, "Milkshake", 3, "\\FoodPhotos\\194.jpg", "Created" },
                    { 195, 400m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4836), null, "Milkshake Chocolate", 3, "\\FoodPhotos\\195.jpg", "Created" },
                    { 196, 550m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4837), null, "Pepperoni", 11, "\\FoodPhotos\\196.jpg", "Created" },
                    { 197, 55m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4838), null, "Macarons", 6, "\\FoodPhotos\\197.jpg", "Created" },
                    { 198, 75m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4839), null, "Bread", 13, "\\FoodPhotos\\198.jpg", "Created" },
                    { 199, 230m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4840), null, "Doughnut", 6, "\\FoodPhotos\\199.jpg", "Created" },
                    { 200, 380m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4841), null, "Doughnut Chocolate", 6, "\\FoodPhotos\\200.jpg", "Created" },
                    { 201, 2m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4841), null, "Tea", 3, "\\FoodPhotos\\201.jpg", "Created" },
                    { 202, 11m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4842), null, "Sugar (Cube)", 13, "\\FoodPhotos\\202.jpg", "Created" },
                    { 203, 387m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4843), null, "Sugar ", 13, "\\FoodPhotos\\203.jpg", "Created" },
                    { 204, 373m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4845), null, "Sugar Brown", 13, "\\FoodPhotos\\204.jpg", "Created" },
                    { 205, 329m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4846), null, "Cheesecake", 6, "\\FoodPhotos\\205.jpg", "Created" },
                    { 206, 400m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4847), null, "Muffin", 6, "\\FoodPhotos\\206.jpg", "Created" },
                    { 207, 155m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4848), null, "Milk", 8, "\\FoodPhotos\\207.jpg", "Created" },
                    { 208, 87m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4848), null, "Milk(Non-Fat)", 8, "\\FoodPhotos\\208.jpg", "Created" },
                    { 209, 230m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4849), null, "Brownie", 6, "\\FoodPhotos\\209.jpg", "Created" },
                    { 210, 264m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4850), null, "Feta Cheese", 8, "\\FoodPhotos\\210.jpg", "Created" },
                    { 211, 402m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4851), null, "Cheddar Cheese", 8, "\\FoodPhotos\\211.jpg", "Created" },
                    { 212, 280m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4852), null, "Mozzarella Cheese", 8, "\\FoodPhotos\\212.jpg", "Created" },
                    { 213, 430m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4853), null, "Parmesan Cheese", 8, "\\FoodPhotos\\213.jpg", "Created" },
                    { 214, 342m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4853), null, "Cream Cheese", 8, "\\FoodPhotos\\214.jpg", "Created" },
                    { 215, 364m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4854), null, "Goat Cheese", 8, "\\FoodPhotos\\215.jpg", "Created" },
                    { 216, 98m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4855), null, "Coke", 3, "\\FoodPhotos\\216.jpg", "Created" },
                    { 217, 1m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4856), null, "Coke Zero", 3, "\\FoodPhotos\\217.jpg", "Created" },
                    { 218, 2m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4857), null, "Americano", 3, "\\FoodPhotos\\218.jpg", "Created" },
                    { 219, 2m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4858), null, "Espresso", 3, "\\FoodPhotos\\219.jpg", "Created" },
                    { 220, 70m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4859), null, "Cappuccino", 3, "\\FoodPhotos\\220.jpg", "Created" },
                    { 221, 120m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4859), null, "Latte", 3, "\\FoodPhotos\\221.jpg", "Created" },
                    { 222, 210m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4860), null, "Mocha", 3, "\\FoodPhotos\\222.jpg", "Created" },
                    { 223, 70m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4861), null, "Iced Latte", 3, "\\FoodPhotos\\223.jpg", "Created" },
                    { 224, 180m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4863), null, "Iced Mocha", 3, "\\FoodPhotos\\224.jpg", "Created" },
                    { 225, 260m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4864), null, "Frappuccino", 3, "\\FoodPhotos\\225.jpg", "Created" },
                    { 226, 630m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4865), null, "Chocolate(Bitter)", 5, "\\FoodPhotos\\226.jpg", "Created" },
                    { 227, 542m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4865), null, "Chocolate(Milk)", 5, "\\FoodPhotos\\227.jpg", "Created" },
                    { 228, 557m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4866), null, "Chocolate(White)", 5, "\\FoodPhotos\\228.jpg", "Created" },
                    { 229, 260m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4867), null, "Ground Meat", 11, "\\FoodPhotos\\229.jpg", "Created" },
                    { 230, 65m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4868), null, "Meatball", 11, "\\FoodPhotos\\230.jpg", "Created" },
                    { 231, 1m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4869), null, "Mineral Water", 3, "\\FoodPhotos\\231.jpg", "Created" },
                    { 232, 119m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4870), null, "Olive Oil", 13, "\\FoodPhotos\\232.jpg", "Created" },
                    { 233, 124m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4871), null, "Canola Oil", 13, "\\FoodPhotos\\233.jpg", "Created" },
                    { 234, 120m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4871), null, "Sunflower Oil", 13, "\\FoodPhotos\\234.jpg", "Created" },
                    { 235, 120m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4872), null, "Sesame Oil", 13, "\\FoodPhotos\\235.jpg", "Created" },
                    { 236, 122m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4873), null, "Corn Oil", 13, "\\FoodPhotos\\236.jpg", "Created" },
                    { 237, 364m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4874), null, "Flour", 13, "\\FoodPhotos\\237.jpg", "Created" },
                    { 238, 95m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4875), null, "Sunnyside-up", 11, "\\FoodPhotos\\238.jpg", "Created" },
                    { 239, 15m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4876), null, "Red Wine", 4, "\\FoodPhotos\\239.jpg", "Created" },
                    { 240, 125m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4876), null, "White Wine", 4, "\\FoodPhotos\\240.jpg", "Created" },
                    { 241, 155m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4877), null, "Beer", 4, "\\FoodPhotos\\241.jpg", "Created" },
                    { 242, 95m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4878), null, "Champagne", 4, "\\FoodPhotos\\242.jpg", "Created" },
                    { 243, 96m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4879), null, "Vodka", 4, "\\FoodPhotos\\243.jpg", "Created" },
                    { 244, 97m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4881), null, "Rum", 4, "\\FoodPhotos\\244.jpg", "Created" },
                    { 245, 98m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4882), null, "Whiskey", 4, "\\FoodPhotos\\245.jpg", "Created" },
                    { 246, 98m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4883), null, "Tequila", 4, "\\FoodPhotos\\246.jpg", "Created" },
                    { 247, 96m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4884), null, "Gin", 4, "\\FoodPhotos\\247.jpg", "Created" },
                    { 248, 119m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4884), null, "Trout", 9, "\\FoodPhotos\\248.jpg", "Created" },
                    { 249, 111m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4885), null, "Halibut", 9, "\\FoodPhotos\\249.jpg", "Created" },
                    { 250, 208m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4886), null, "Sardines", 9, "\\FoodPhotos\\250.jpg", "Created" },
                    { 251, 305m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4887), null, "Mackerel", 9, "\\FoodPhotos\\251.jpg", "Created" },
                    { 252, 280m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4888), null, "Snickers", 5, "\\FoodPhotos\\252.jpg", "Created" },
                    { 253, 250m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4889), null, "Twix", 5, "\\FoodPhotos\\253.jpg", "Created" },
                    { 254, 210m, new DateTime(2024, 7, 10, 15, 57, 14, 284, DateTimeKind.Local).AddTicks(4891), null, "Kit Kat", 5, "\\FoodPhotos\\254.jpg", "Created" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealNutritionDiaries_NutritionDiaryId",
                table: "MealNutritionDiaries",
                column: "NutritionDiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_NutrientNutritionDiaries_NutritionDiaryId",
                table: "NutrientNutritionDiaries",
                column: "NutritionDiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_NutrientCategoryId",
                table: "Nutrients",
                column: "NutrientCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoNutrientDiaries_NutrientDiaryId",
                table: "UserInfoNutrientDiaries",
                column: "NutrientDiaryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealNutritionDiaries");

            migrationBuilder.DropTable(
                name: "NutrientNutritionDiaries");

            migrationBuilder.DropTable(
                name: "UserInfoNutrientDiaries");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropTable(
                name: "NutritionDiaries");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "NutrientCategories");
        }
    }
}
