using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    FloorId = table.Column<Guid>(type: "uuid", nullable: false),
                    AllowedPersons = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomAssignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomAssignments_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomInventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false),
                    InventoryItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpectedQuantity = table.Column<int>(type: "integer", nullable: false),
                    ActualQuantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomInventories_InventoryItems_InventoryItemId",
                        column: x => x.InventoryItemId,
                        principalTable: "InventoryItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomInventories_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    InitialPassword = table.Column<string>(type: "text", nullable: false),
                    RoomAssignmentId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_RoomAssignments_RoomAssignmentId",
                        column: x => x.RoomAssignmentId,
                        principalTable: "RoomAssignments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AdminUsers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("2fac0890-f4a9-417b-854b-07a390ae223d"), "john.doe@example.com", "John", "Doe", "4d337c6c91099310b0d66d3c581e10ea958971eef83251a3a0c615f948cb8372" },
                    { new Guid("5b9e1ebb-8eb3-488e-9666-70da603150ec"), "jane.doe@example.com", "Jane", "Doe", "0e4d12c8083054721084530af46bb793e61a4cf1227610f9ba8eb5e5f787866a" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1cd54103-7de5-4ef8-b7fe-8bb68a4776de"), "Building A" },
                    { new Guid("5beffe66-c807-4406-aadb-0e80fcbd4013"), "Building B" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), "Lamp" },
                    { new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), "Curtains" },
                    { new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), "Bed" },
                    { new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), "Desk" },
                    { new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), "Bookshelf" },
                    { new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), "Chair" },
                    { new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), "Wardrobe" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Number" },
                values: new object[,]
                {
                    { new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), new Guid("5beffe66-c807-4406-aadb-0e80fcbd4013"), 1 },
                    { new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), new Guid("1cd54103-7de5-4ef8-b7fe-8bb68a4776de"), 2 },
                    { new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), new Guid("1cd54103-7de5-4ef8-b7fe-8bb68a4776de"), 1 },
                    { new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), new Guid("5beffe66-c807-4406-aadb-0e80fcbd4013"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllowedPersons", "FloorId", "Number" },
                values: new object[,]
                {
                    { new Guid("01359265-c494-48eb-8013-46fb74b70138"), 3, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-08" },
                    { new Guid("01f21fdf-7643-49d5-87d8-e43750f18222"), 5, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-05" },
                    { new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd"), 4, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-04" },
                    { new Guid("0bc3bf73-9f19-48a9-8f43-b280638692a1"), 3, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-06" },
                    { new Guid("286e8d49-0d47-4fd3-813d-4fca2ebad2fb"), 3, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-02" },
                    { new Guid("2cc9ba1d-2031-49fc-9cb0-49cf7861cb97"), 3, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-04" },
                    { new Guid("34cf6fc9-414e-43d7-b2b6-a3d0f295aabe"), 4, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-10" },
                    { new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288"), 3, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-06" },
                    { new Guid("501f860a-4fef-45d9-931f-3262d623fbb3"), 4, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-01" },
                    { new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e"), 5, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-05" },
                    { new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d"), 4, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-08" },
                    { new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5"), 5, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-04" },
                    { new Guid("6ed88f41-2a66-4ce0-b260-e024263be30e"), 5, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-01" },
                    { new Guid("73c6a91a-392f-4805-b7d8-60067a48622c"), 3, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-02" },
                    { new Guid("775980b6-b53a-49ee-a755-f9895ce056dd"), 5, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-02" },
                    { new Guid("7c4b1d60-c4fb-498d-bb9e-e31c2f6ea273"), 5, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-07" },
                    { new Guid("7f6db1ee-bd2b-4496-8431-9ab1ef5ccee3"), 5, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-05" },
                    { new Guid("83e285eb-0fe9-47a4-ac43-e57e81cb169c"), 5, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-10" },
                    { new Guid("85f42658-b1ab-4675-bbfc-3a360405679a"), 5, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-03" },
                    { new Guid("87392290-0fa1-4f27-bf71-37e251dd142a"), 5, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-08" },
                    { new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003"), 5, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-03" },
                    { new Guid("9d9a2f5d-d3ee-46c7-a578-57d7154406a1"), 5, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-07" },
                    { new Guid("a683b43e-ce24-4038-8dc8-28db63800250"), 5, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-09" },
                    { new Guid("b0742d90-9107-4995-a8a9-caf9912613bc"), 3, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-09" },
                    { new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e"), 3, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-09" },
                    { new Guid("b5126541-af82-4238-b114-2e84486f4aca"), 4, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-09" },
                    { new Guid("b7adee2a-35af-493c-90d7-94a564464c9b"), 3, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-07" },
                    { new Guid("bbde25a6-5757-4d2e-b164-8e0865f0fd57"), 5, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-01" },
                    { new Guid("bccea54e-00b7-498e-ae27-fec9563dd07a"), 3, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-01" },
                    { new Guid("c3c195ad-15a1-489a-9144-63beea5b0911"), 3, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-06" },
                    { new Guid("c9697c95-6bfb-4dc0-8b98-f4d99d82ffe4"), 5, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-03" },
                    { new Guid("e113cff2-2b54-4874-b9ee-33db47e6aaa3"), 3, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-04" },
                    { new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d"), 3, new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"), "A1-10" },
                    { new Guid("e2c38730-d943-41df-8301-10ced186371b"), 5, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-05" },
                    { new Guid("e8f17544-4d24-463b-916c-aede080578e0"), 4, new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"), "A2-06" },
                    { new Guid("ebc4ba13-f254-4893-8ec1-562415546f3a"), 3, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-10" },
                    { new Guid("ecb31258-af4c-46f6-a433-a131c0293c8d"), 4, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-03" },
                    { new Guid("f780a94e-fbaa-41e6-920a-f9e23a81fa02"), 5, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-08" },
                    { new Guid("f9d6e3c7-33c8-4dd9-8056-5b4064fcc5e9"), 3, new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"), "B2-02" },
                    { new Guid("fa0c4a88-be68-47ec-9826-21444389b1ba"), 4, new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"), "B1-07" }
                });

            migrationBuilder.InsertData(
                table: "RoomInventories",
                columns: new[] { "Id", "ActualQuantity", "ExpectedQuantity", "InventoryItemId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("08353be6-4053-4b88-a8a4-03c2df06f258"), 3, 3, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288") },
                    { new Guid("08935f09-778a-4e58-b320-065bf19321db"), 4, 3, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5") },
                    { new Guid("0957a7d4-6c44-44b1-a0de-2dfc9e36200e"), 2, 2, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("87392290-0fa1-4f27-bf71-37e251dd142a") },
                    { new Guid("0b037943-5d16-498e-a1fb-050fff9bd2cb"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("bccea54e-00b7-498e-ae27-fec9563dd07a") },
                    { new Guid("0b786df1-65ef-41ca-a0f5-e12a63708c7c"), 4, 4, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("bbde25a6-5757-4d2e-b164-8e0865f0fd57") },
                    { new Guid("0ce3536e-29ce-45ec-9298-cf8f7be83147"), 1, 1, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("b5126541-af82-4238-b114-2e84486f4aca") },
                    { new Guid("0f17f419-4d0e-497f-a36e-4ffb1f80c08b"), 4, 4, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("e8f17544-4d24-463b-916c-aede080578e0") },
                    { new Guid("0fc52dec-ffeb-47b7-973d-70a34b2a1f82"), 3, 3, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e") },
                    { new Guid("1072e63f-22c9-4c74-b68c-5d966a5d6365"), 1, 1, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e") },
                    { new Guid("12bfa2f6-acb5-4bae-87b5-3855b0f1aa7c"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("01359265-c494-48eb-8013-46fb74b70138") },
                    { new Guid("12e338e1-2fc0-4186-9a3f-66c425500fd3"), 1, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("fa0c4a88-be68-47ec-9826-21444389b1ba") },
                    { new Guid("135359b3-be6b-4abe-a90e-df563b522a87"), 4, 4, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("73c6a91a-392f-4805-b7d8-60067a48622c") },
                    { new Guid("13a843ac-157d-444b-94e4-710961ef0de1"), 4, 4, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5") },
                    { new Guid("14ac02c8-c23d-4623-aabe-802c6e16bdf7"), 2, 2, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("01359265-c494-48eb-8013-46fb74b70138") },
                    { new Guid("185711f1-a7ed-48e1-928d-4404a7124aa2"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("e113cff2-2b54-4874-b9ee-33db47e6aaa3") },
                    { new Guid("188dec5a-5950-403f-a1c9-cbd8bebf630d"), 4, 4, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("ebc4ba13-f254-4893-8ec1-562415546f3a") },
                    { new Guid("1b8d9a8f-bb95-476b-a1bd-4d08b877a9b8"), 3, 3, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("775980b6-b53a-49ee-a755-f9895ce056dd") },
                    { new Guid("1ee7bc2f-2fb5-47ad-8f20-a04458957157"), 1, 1, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d") },
                    { new Guid("1faa13e5-0b09-496b-bedb-c14828a81653"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("87392290-0fa1-4f27-bf71-37e251dd142a") },
                    { new Guid("20943410-5332-40f8-becc-925a4ce33f9c"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("01f21fdf-7643-49d5-87d8-e43750f18222") },
                    { new Guid("214abe79-fedf-44ad-a94c-cb7aab8174c4"), 1, 4, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("9d9a2f5d-d3ee-46c7-a578-57d7154406a1") },
                    { new Guid("236522cd-6cf8-4a09-bb1b-b6ae4107c453"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("bbde25a6-5757-4d2e-b164-8e0865f0fd57") },
                    { new Guid("23f0dea6-3507-4a94-adc7-bd082e720a15"), 1, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("e2c38730-d943-41df-8301-10ced186371b") },
                    { new Guid("24a60785-f27e-4842-b38f-b2fbc5ecbd94"), 2, 2, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("6ed88f41-2a66-4ce0-b260-e024263be30e") },
                    { new Guid("250a0f74-992d-432b-9e4d-e71a26dba93d"), 1, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e") },
                    { new Guid("2b86da6e-3dd2-4ce6-9801-21f713e83bc7"), 4, 4, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("7f6db1ee-bd2b-4496-8431-9ab1ef5ccee3") },
                    { new Guid("2c29050e-f9b5-4c20-b646-40a4ffb3029c"), 4, 4, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("501f860a-4fef-45d9-931f-3262d623fbb3") },
                    { new Guid("2d34d51b-046d-4b2a-bd5c-9cca2c910a4d"), 3, 3, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("01f21fdf-7643-49d5-87d8-e43750f18222") },
                    { new Guid("30d6e9c3-7d43-4a67-bcd9-64cf7ab74f51"), 1, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e") },
                    { new Guid("38505790-ec6a-4150-bfd1-8ff4cb4b8b0a"), 1, 1, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("c3c195ad-15a1-489a-9144-63beea5b0911") },
                    { new Guid("386d7b7b-7901-48ce-aa56-3212d2d585bc"), 2, 2, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003") },
                    { new Guid("3eea122f-27c1-432e-9f38-56b6cbd6857c"), 2, 3, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("f9d6e3c7-33c8-4dd9-8056-5b4064fcc5e9") },
                    { new Guid("3f083d57-b72d-41e9-ac6b-182cdfce90d4"), 2, 2, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d") },
                    { new Guid("3f45c016-6299-4a44-8fe9-2dd0fb9c0a66"), 2, 3, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d") },
                    { new Guid("457e1afa-c08d-4d6d-aacd-915562382667"), 3, 3, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("01f21fdf-7643-49d5-87d8-e43750f18222") },
                    { new Guid("4bcee73b-25e5-460b-b069-4b4963605ca0"), 4, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d") },
                    { new Guid("4d01c25a-0784-49cb-87ef-681aa3e88295"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("fa0c4a88-be68-47ec-9826-21444389b1ba") },
                    { new Guid("4f3a5bd6-10f9-4d3f-b666-08c94df7b358"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e") },
                    { new Guid("53c0c296-3b87-493c-94e2-4b51e3df09f1"), 2, 2, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("01359265-c494-48eb-8013-46fb74b70138") },
                    { new Guid("54cf6c3f-3d4a-45f8-8346-dd43563ec01e"), 3, 3, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("01f21fdf-7643-49d5-87d8-e43750f18222") },
                    { new Guid("567e2298-025b-4b79-b576-8f2c5a1eb4ef"), 2, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("b7adee2a-35af-493c-90d7-94a564464c9b") },
                    { new Guid("59565263-6966-4c4a-8abe-71b984393ae1"), 3, 3, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("87392290-0fa1-4f27-bf71-37e251dd142a") },
                    { new Guid("5b0d9f2f-4e7e-4291-bc19-24a517039832"), 1, 1, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5") },
                    { new Guid("5dd2ad5f-93aa-421e-a855-896791aecab7"), 1, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("a683b43e-ce24-4038-8dc8-28db63800250") },
                    { new Guid("5ee99d70-2d61-4b48-8046-fdcba007e9c7"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("9d9a2f5d-d3ee-46c7-a578-57d7154406a1") },
                    { new Guid("5fc1dd90-48be-4376-aa60-5fc82def3af0"), 1, 1, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("775980b6-b53a-49ee-a755-f9895ce056dd") },
                    { new Guid("609c3261-71dc-4bd4-9fb4-ddd4b1d48a59"), 4, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("b7adee2a-35af-493c-90d7-94a564464c9b") },
                    { new Guid("6221cc3f-b3b8-4e8e-8884-0896807100cc"), 3, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288") },
                    { new Guid("62e16444-25a7-44b3-8ee2-8d6a94654730"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003") },
                    { new Guid("6328c631-700a-4f70-81e6-f9cfb7331dc0"), 1, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("bccea54e-00b7-498e-ae27-fec9563dd07a") },
                    { new Guid("63d002d6-e941-4e2f-b275-e3c4a932d1f9"), 3, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("501f860a-4fef-45d9-931f-3262d623fbb3") },
                    { new Guid("63db92be-1cdc-4735-8e16-16445700dff9"), 3, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("e113cff2-2b54-4874-b9ee-33db47e6aaa3") },
                    { new Guid("6736659b-b92c-4dbc-a51f-fd78431d6f6b"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("0bc3bf73-9f19-48a9-8f43-b280638692a1") },
                    { new Guid("68e37f72-c436-43f7-ab03-8ccb96621a27"), 2, 2, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd") },
                    { new Guid("69b6b072-9169-4a5f-9345-631b342bb733"), 3, 3, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("b5126541-af82-4238-b114-2e84486f4aca") },
                    { new Guid("6b4c6b27-40b2-4680-b6d8-6fb9b4ac26b6"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("b5126541-af82-4238-b114-2e84486f4aca") },
                    { new Guid("6bd7b1d2-f843-4df5-b0b3-c776ef243a60"), 1, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("a683b43e-ce24-4038-8dc8-28db63800250") },
                    { new Guid("6d2fe021-c08e-484f-ad7d-956754662b95"), 1, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("7f6db1ee-bd2b-4496-8431-9ab1ef5ccee3") },
                    { new Guid("6f786d66-e7e2-4cd7-b8a9-31d3aa15bdd9"), 2, 2, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("c3c195ad-15a1-489a-9144-63beea5b0911") },
                    { new Guid("70a8dde0-d247-4b8b-a177-e601b94b5f4f"), 3, 1, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("85f42658-b1ab-4675-bbfc-3a360405679a") },
                    { new Guid("71383ffa-8ec6-4bf5-aea6-86cb0e5b10b3"), 1, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("b5126541-af82-4238-b114-2e84486f4aca") },
                    { new Guid("7192ef6b-bcea-4c93-b0a3-c32a1cab58d7"), 3, 3, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003") },
                    { new Guid("71baeb63-42b8-4f18-9280-aa0039b96eeb"), 3, 3, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d") },
                    { new Guid("7544646d-83b1-4ae2-8b4d-e85d578bf1a3"), 3, 3, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5") },
                    { new Guid("76101480-4f38-45a6-adc6-0f3ade66136f"), 2, 3, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("7f6db1ee-bd2b-4496-8431-9ab1ef5ccee3") },
                    { new Guid("7ab94c64-26eb-476e-a0b5-a4b6e725e47e"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d") },
                    { new Guid("7f5b6f95-0a4f-4c18-9d5a-d6afde5ac89c"), 3, 3, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("0bc3bf73-9f19-48a9-8f43-b280638692a1") },
                    { new Guid("7ffee662-de95-4939-9e5e-9a8fc6b06cb0"), 1, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("775980b6-b53a-49ee-a755-f9895ce056dd") },
                    { new Guid("808663ed-12c4-4a87-8b20-94a33405a0cc"), 2, 2, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("0bc3bf73-9f19-48a9-8f43-b280638692a1") },
                    { new Guid("84b95643-47df-43fb-8686-fafa6d238dc9"), 4, 4, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("e113cff2-2b54-4874-b9ee-33db47e6aaa3") },
                    { new Guid("89de51d7-a83e-49c9-9cd8-e5ca2374d6bd"), 4, 4, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("2cc9ba1d-2031-49fc-9cb0-49cf7861cb97") },
                    { new Guid("8a9db13d-8937-452e-a3de-8846de42338e"), 2, 2, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("01f21fdf-7643-49d5-87d8-e43750f18222") },
                    { new Guid("8f960dc6-1c2e-4909-88b7-1c0f32ee29b7"), 4, 4, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("2cc9ba1d-2031-49fc-9cb0-49cf7861cb97") },
                    { new Guid("9125704f-e040-461c-9ba6-8c6b4cc18699"), 4, 4, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("7c4b1d60-c4fb-498d-bb9e-e31c2f6ea273") },
                    { new Guid("934fd4c0-a0f7-449d-a4a7-c7475af4092c"), 1, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("bccea54e-00b7-498e-ae27-fec9563dd07a") },
                    { new Guid("962ba1b3-0e0d-45d2-9c33-b56214878f7e"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("c3c195ad-15a1-489a-9144-63beea5b0911") },
                    { new Guid("979d60ab-0281-4fa6-bfbb-280a85757560"), 3, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("87392290-0fa1-4f27-bf71-37e251dd142a") },
                    { new Guid("9a4f1343-f5de-4eae-b968-71cce4a106d4"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("2cc9ba1d-2031-49fc-9cb0-49cf7861cb97") },
                    { new Guid("9c6e2c78-2083-411c-b189-73573da85743"), 3, 3, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("83e285eb-0fe9-47a4-ac43-e57e81cb169c") },
                    { new Guid("9e52b6a0-0b27-4468-886e-9ad4ba60babc"), 3, 3, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("b7adee2a-35af-493c-90d7-94a564464c9b") },
                    { new Guid("a15b35d4-93df-424d-8356-7e471c4406ba"), 3, 3, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd") },
                    { new Guid("a16eed23-f2b0-4624-afe0-ea21471726d2"), 4, 4, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd") },
                    { new Guid("a1be8b0e-e86f-4dcd-a4b2-428c37ae1ca4"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("c3c195ad-15a1-489a-9144-63beea5b0911") },
                    { new Guid("a4f39246-57d3-4b4a-89d9-3ccb5e4d0bc2"), 4, 4, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("01f21fdf-7643-49d5-87d8-e43750f18222") },
                    { new Guid("a58e771d-d0d1-4fa3-be8e-ea83742ba12a"), 4, 4, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("b7adee2a-35af-493c-90d7-94a564464c9b") },
                    { new Guid("a5edf076-1c71-4999-bebb-002c27620660"), 1, 1, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("a683b43e-ce24-4038-8dc8-28db63800250") },
                    { new Guid("a971ff7f-8956-4549-a5de-fe009df8199e"), 2, 2, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d") },
                    { new Guid("ab777bf4-6874-4766-88af-74780250b23b"), 3, 4, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("501f860a-4fef-45d9-931f-3262d623fbb3") },
                    { new Guid("ac31f395-2cca-41a4-93bd-eef4a4e4dcc1"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("286e8d49-0d47-4fd3-813d-4fca2ebad2fb") },
                    { new Guid("af5592cb-7e0b-4e1b-8f99-3187f13089f1"), 2, 2, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("73c6a91a-392f-4805-b7d8-60067a48622c") },
                    { new Guid("b20caceb-8538-4bc8-9e7f-ba1961a5a4ed"), 4, 4, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288") },
                    { new Guid("b283b092-7d5f-4e79-a684-3637eab2f041"), 4, 4, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("01359265-c494-48eb-8013-46fb74b70138") },
                    { new Guid("b2f76b07-0c35-4681-848e-e92b7dc683cd"), 1, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e") },
                    { new Guid("b3b25dfb-5baa-4202-aab1-f1e8cad0c89b"), 1, 1, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("85f42658-b1ab-4675-bbfc-3a360405679a") },
                    { new Guid("b3e120b2-7a7f-44d3-8417-dd6b0b8268a0"), 2, 2, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("34cf6fc9-414e-43d7-b2b6-a3d0f295aabe") },
                    { new Guid("b50e252a-ae80-4206-9efc-08609a58ce54"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288") },
                    { new Guid("b76d6646-9e68-4e86-836a-62f8c8ef4ae5"), 2, 2, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("b7adee2a-35af-493c-90d7-94a564464c9b") },
                    { new Guid("b7a8f3aa-716d-4d01-8625-49578d8e6829"), 1, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003") },
                    { new Guid("b8500c60-7252-44d7-8b2d-08d143f606d7"), 2, 2, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e") },
                    { new Guid("b8979bc9-9f1d-4be2-ae37-ae2f45837a72"), 1, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("501f860a-4fef-45d9-931f-3262d623fbb3") },
                    { new Guid("b8e45c1e-3f4a-4ca2-8983-37a80e1ebfa2"), 4, 4, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("85f42658-b1ab-4675-bbfc-3a360405679a") },
                    { new Guid("b9ea0669-0599-4895-9b83-087c9aaa8bf2"), 1, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("83e285eb-0fe9-47a4-ac43-e57e81cb169c") },
                    { new Guid("bd0ae9f4-93d2-406b-8c2a-a322b12c1b65"), 1, 1, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("a683b43e-ce24-4038-8dc8-28db63800250") },
                    { new Guid("bd16f0e3-f156-44ba-8cf2-88a8a8dd098f"), 3, 3, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("286e8d49-0d47-4fd3-813d-4fca2ebad2fb") },
                    { new Guid("bd759beb-1b29-484c-8442-67f4d56409ce"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d") },
                    { new Guid("c1d421c3-fa7f-4bd0-a896-e03d0af4053f"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d") },
                    { new Guid("c30439ab-1b09-4846-b6bf-8cea992fb79b"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e") },
                    { new Guid("c78df47c-36e7-4d6f-8f7e-3852d6085fc0"), 2, 2, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("ecb31258-af4c-46f6-a433-a131c0293c8d") },
                    { new Guid("cd03393a-34d6-4203-a17a-93ae1141d478"), 2, 4, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("85f42658-b1ab-4675-bbfc-3a360405679a") },
                    { new Guid("cfa41ab9-d83b-4774-bbf6-485a181be249"), 4, 4, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("6ed88f41-2a66-4ce0-b260-e024263be30e") },
                    { new Guid("cfdcca21-b0a6-4a37-a615-3ac6e9819f78"), 3, 3, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e") },
                    { new Guid("d0c069b2-1ab6-4b93-9c45-5b25fd18189e"), 3, 3, new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"), new Guid("01359265-c494-48eb-8013-46fb74b70138") },
                    { new Guid("d1f6e7e2-0161-4f89-ab93-f508ef847789"), 1, 4, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("fa0c4a88-be68-47ec-9826-21444389b1ba") },
                    { new Guid("d3c7de30-0003-4dc3-8f1c-e199f6ad130e"), 2, 2, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e") },
                    { new Guid("d3d6b0fd-aad4-4989-9fa9-9127a943bf3f"), 4, 4, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("bccea54e-00b7-498e-ae27-fec9563dd07a") },
                    { new Guid("d49ebb39-2c69-4d1d-943f-b096c945e585"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("01359265-c494-48eb-8013-46fb74b70138") },
                    { new Guid("d56d225a-ae6d-4385-adbc-98ac157ad877"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("c9697c95-6bfb-4dc0-8b98-f4d99d82ffe4") },
                    { new Guid("d87b4048-2a8e-45f4-8794-3db65558856e"), 3, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd") },
                    { new Guid("d8d9a97c-dd66-45e6-b678-eb35005a3d53"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("fa0c4a88-be68-47ec-9826-21444389b1ba") },
                    { new Guid("db93cd4d-405b-41f3-bb18-5139415fe008"), 3, 4, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d") },
                    { new Guid("e0eda4d3-0938-410b-a7d0-ef8f55fb7347"), 4, 4, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("2cc9ba1d-2031-49fc-9cb0-49cf7861cb97") },
                    { new Guid("e2e774b5-951c-4437-8f9e-1056dc1a7835"), 1, 1, new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"), new Guid("501f860a-4fef-45d9-931f-3262d623fbb3") },
                    { new Guid("e4e4dca4-a61f-4b16-bb17-5fe8d9f34bfa"), 3, 3, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("a683b43e-ce24-4038-8dc8-28db63800250") },
                    { new Guid("e6144855-6c03-46dc-b419-4282cc1c2251"), 3, 3, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("f780a94e-fbaa-41e6-920a-f9e23a81fa02") },
                    { new Guid("e990f3a2-44b1-436c-8721-4e445f9d4889"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003") },
                    { new Guid("ea33b5c2-d8e8-4612-96e6-218363171ac0"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("b7adee2a-35af-493c-90d7-94a564464c9b") },
                    { new Guid("ea5694fd-d8f5-4cc3-a9bc-f7a6c95bbed4"), 3, 3, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd") },
                    { new Guid("ec8d80aa-091a-4aa5-8ac7-c14e0405c0fb"), 3, 3, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("87392290-0fa1-4f27-bf71-37e251dd142a") },
                    { new Guid("ec91948b-da87-4c55-ab6c-e72d7431c171"), 3, 3, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288") },
                    { new Guid("ed7a641b-00ac-4441-b96d-a7298f461b87"), 3, 3, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("c9697c95-6bfb-4dc0-8b98-f4d99d82ffe4") },
                    { new Guid("f1477e9d-55ae-4d0a-bfec-72c7f870e036"), 4, 1, new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"), new Guid("f780a94e-fbaa-41e6-920a-f9e23a81fa02") },
                    { new Guid("f14d2939-24dd-45f5-900d-7378beb5e3c9"), 4, 4, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5") },
                    { new Guid("f3856719-6e31-4ce0-aaee-c639c5e2e74c"), 2, 2, new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"), new Guid("ecb31258-af4c-46f6-a433-a131c0293c8d") },
                    { new Guid("f490a2b8-d91e-4362-8845-54a5a01a4d95"), 1, 1, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("a683b43e-ce24-4038-8dc8-28db63800250") },
                    { new Guid("f7752b66-e55b-4ba3-841e-f8f18e109a45"), 2, 2, new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"), new Guid("b0742d90-9107-4995-a8a9-caf9912613bc") },
                    { new Guid("fe476b63-e93e-46f2-84c0-86cdd457648e"), 1, 1, new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"), new Guid("9d9a2f5d-d3ee-46c7-a578-57d7154406a1") },
                    { new Guid("ffc06bf2-1247-4b4c-9fd5-ec86cea29fe1"), 4, 1, new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"), new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAssignments_RoomId",
                table: "RoomAssignments",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInventories_InventoryItemId",
                table: "RoomInventories",
                column: "InventoryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInventories_RoomId",
                table: "RoomInventories",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FloorId",
                table: "Rooms",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_RoomAssignmentId",
                table: "Students",
                column: "RoomAssignmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUsers");

            migrationBuilder.DropTable(
                name: "RoomInventories");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "RoomAssignments");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
