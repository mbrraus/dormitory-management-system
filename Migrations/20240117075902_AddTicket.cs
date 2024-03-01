using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DormitoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fac0890-f4a9-417b-854b-07a390ae223d"));

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b9e1ebb-8eb3-488e-9666-70da603150ec"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("08353be6-4053-4b88-a8a4-03c2df06f258"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("08935f09-778a-4e58-b320-065bf19321db"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0957a7d4-6c44-44b1-a0de-2dfc9e36200e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0b037943-5d16-498e-a1fb-050fff9bd2cb"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0b786df1-65ef-41ca-a0f5-e12a63708c7c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0ce3536e-29ce-45ec-9298-cf8f7be83147"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0f17f419-4d0e-497f-a36e-4ffb1f80c08b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0fc52dec-ffeb-47b7-973d-70a34b2a1f82"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1072e63f-22c9-4c74-b68c-5d966a5d6365"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("12bfa2f6-acb5-4bae-87b5-3855b0f1aa7c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("12e338e1-2fc0-4186-9a3f-66c425500fd3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("135359b3-be6b-4abe-a90e-df563b522a87"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("13a843ac-157d-444b-94e4-710961ef0de1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("14ac02c8-c23d-4623-aabe-802c6e16bdf7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("185711f1-a7ed-48e1-928d-4404a7124aa2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("188dec5a-5950-403f-a1c9-cbd8bebf630d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1b8d9a8f-bb95-476b-a1bd-4d08b877a9b8"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1ee7bc2f-2fb5-47ad-8f20-a04458957157"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1faa13e5-0b09-496b-bedb-c14828a81653"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("20943410-5332-40f8-becc-925a4ce33f9c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("214abe79-fedf-44ad-a94c-cb7aab8174c4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("236522cd-6cf8-4a09-bb1b-b6ae4107c453"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("23f0dea6-3507-4a94-adc7-bd082e720a15"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("24a60785-f27e-4842-b38f-b2fbc5ecbd94"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("250a0f74-992d-432b-9e4d-e71a26dba93d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2b86da6e-3dd2-4ce6-9801-21f713e83bc7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2c29050e-f9b5-4c20-b646-40a4ffb3029c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2d34d51b-046d-4b2a-bd5c-9cca2c910a4d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("30d6e9c3-7d43-4a67-bcd9-64cf7ab74f51"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("38505790-ec6a-4150-bfd1-8ff4cb4b8b0a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("386d7b7b-7901-48ce-aa56-3212d2d585bc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3eea122f-27c1-432e-9f38-56b6cbd6857c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3f083d57-b72d-41e9-ac6b-182cdfce90d4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3f45c016-6299-4a44-8fe9-2dd0fb9c0a66"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("457e1afa-c08d-4d6d-aacd-915562382667"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4bcee73b-25e5-460b-b069-4b4963605ca0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4d01c25a-0784-49cb-87ef-681aa3e88295"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4f3a5bd6-10f9-4d3f-b666-08c94df7b358"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("53c0c296-3b87-493c-94e2-4b51e3df09f1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("54cf6c3f-3d4a-45f8-8346-dd43563ec01e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("567e2298-025b-4b79-b576-8f2c5a1eb4ef"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("59565263-6966-4c4a-8abe-71b984393ae1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5b0d9f2f-4e7e-4291-bc19-24a517039832"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5dd2ad5f-93aa-421e-a855-896791aecab7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5ee99d70-2d61-4b48-8046-fdcba007e9c7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5fc1dd90-48be-4376-aa60-5fc82def3af0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("609c3261-71dc-4bd4-9fb4-ddd4b1d48a59"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6221cc3f-b3b8-4e8e-8884-0896807100cc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("62e16444-25a7-44b3-8ee2-8d6a94654730"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6328c631-700a-4f70-81e6-f9cfb7331dc0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("63d002d6-e941-4e2f-b275-e3c4a932d1f9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("63db92be-1cdc-4735-8e16-16445700dff9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6736659b-b92c-4dbc-a51f-fd78431d6f6b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("68e37f72-c436-43f7-ab03-8ccb96621a27"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("69b6b072-9169-4a5f-9345-631b342bb733"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6b4c6b27-40b2-4680-b6d8-6fb9b4ac26b6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6bd7b1d2-f843-4df5-b0b3-c776ef243a60"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6d2fe021-c08e-484f-ad7d-956754662b95"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6f786d66-e7e2-4cd7-b8a9-31d3aa15bdd9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("70a8dde0-d247-4b8b-a177-e601b94b5f4f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("71383ffa-8ec6-4bf5-aea6-86cb0e5b10b3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7192ef6b-bcea-4c93-b0a3-c32a1cab58d7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("71baeb63-42b8-4f18-9280-aa0039b96eeb"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7544646d-83b1-4ae2-8b4d-e85d578bf1a3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("76101480-4f38-45a6-adc6-0f3ade66136f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7ab94c64-26eb-476e-a0b5-a4b6e725e47e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7f5b6f95-0a4f-4c18-9d5a-d6afde5ac89c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7ffee662-de95-4939-9e5e-9a8fc6b06cb0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("808663ed-12c4-4a87-8b20-94a33405a0cc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("84b95643-47df-43fb-8686-fafa6d238dc9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("89de51d7-a83e-49c9-9cd8-e5ca2374d6bd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8a9db13d-8937-452e-a3de-8846de42338e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8f960dc6-1c2e-4909-88b7-1c0f32ee29b7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9125704f-e040-461c-9ba6-8c6b4cc18699"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("934fd4c0-a0f7-449d-a4a7-c7475af4092c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("962ba1b3-0e0d-45d2-9c33-b56214878f7e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("979d60ab-0281-4fa6-bfbb-280a85757560"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9a4f1343-f5de-4eae-b968-71cce4a106d4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9c6e2c78-2083-411c-b189-73573da85743"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9e52b6a0-0b27-4468-886e-9ad4ba60babc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a15b35d4-93df-424d-8356-7e471c4406ba"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a16eed23-f2b0-4624-afe0-ea21471726d2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a1be8b0e-e86f-4dcd-a4b2-428c37ae1ca4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a4f39246-57d3-4b4a-89d9-3ccb5e4d0bc2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a58e771d-d0d1-4fa3-be8e-ea83742ba12a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a5edf076-1c71-4999-bebb-002c27620660"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a971ff7f-8956-4549-a5de-fe009df8199e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ab777bf4-6874-4766-88af-74780250b23b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ac31f395-2cca-41a4-93bd-eef4a4e4dcc1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("af5592cb-7e0b-4e1b-8f99-3187f13089f1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b20caceb-8538-4bc8-9e7f-ba1961a5a4ed"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b283b092-7d5f-4e79-a684-3637eab2f041"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b2f76b07-0c35-4681-848e-e92b7dc683cd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b3b25dfb-5baa-4202-aab1-f1e8cad0c89b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b3e120b2-7a7f-44d3-8417-dd6b0b8268a0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b50e252a-ae80-4206-9efc-08609a58ce54"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b76d6646-9e68-4e86-836a-62f8c8ef4ae5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b7a8f3aa-716d-4d01-8625-49578d8e6829"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b8500c60-7252-44d7-8b2d-08d143f606d7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b8979bc9-9f1d-4be2-ae37-ae2f45837a72"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b8e45c1e-3f4a-4ca2-8983-37a80e1ebfa2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b9ea0669-0599-4895-9b83-087c9aaa8bf2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bd0ae9f4-93d2-406b-8c2a-a322b12c1b65"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bd16f0e3-f156-44ba-8cf2-88a8a8dd098f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bd759beb-1b29-484c-8442-67f4d56409ce"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c1d421c3-fa7f-4bd0-a896-e03d0af4053f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c30439ab-1b09-4846-b6bf-8cea992fb79b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c78df47c-36e7-4d6f-8f7e-3852d6085fc0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cd03393a-34d6-4203-a17a-93ae1141d478"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cfa41ab9-d83b-4774-bbf6-485a181be249"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cfdcca21-b0a6-4a37-a615-3ac6e9819f78"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d0c069b2-1ab6-4b93-9c45-5b25fd18189e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d1f6e7e2-0161-4f89-ab93-f508ef847789"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d3c7de30-0003-4dc3-8f1c-e199f6ad130e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d3d6b0fd-aad4-4989-9fa9-9127a943bf3f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d49ebb39-2c69-4d1d-943f-b096c945e585"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d56d225a-ae6d-4385-adbc-98ac157ad877"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d87b4048-2a8e-45f4-8794-3db65558856e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d8d9a97c-dd66-45e6-b678-eb35005a3d53"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("db93cd4d-405b-41f3-bb18-5139415fe008"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e0eda4d3-0938-410b-a7d0-ef8f55fb7347"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e2e774b5-951c-4437-8f9e-1056dc1a7835"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e4e4dca4-a61f-4b16-bb17-5fe8d9f34bfa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e6144855-6c03-46dc-b419-4282cc1c2251"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e990f3a2-44b1-436c-8721-4e445f9d4889"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ea33b5c2-d8e8-4612-96e6-218363171ac0"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ea5694fd-d8f5-4cc3-a9bc-f7a6c95bbed4"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ec8d80aa-091a-4aa5-8ac7-c14e0405c0fb"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ec91948b-da87-4c55-ab6c-e72d7431c171"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ed7a641b-00ac-4441-b96d-a7298f461b87"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f1477e9d-55ae-4d0a-bfec-72c7f870e036"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f14d2939-24dd-45f5-900d-7378beb5e3c9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f3856719-6e31-4ce0-aaee-c639c5e2e74c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f490a2b8-d91e-4362-8845-54a5a01a4d95"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f7752b66-e55b-4ba3-841e-f8f18e109a45"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fe476b63-e93e-46f2-84c0-86cdd457648e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ffc06bf2-1247-4b4c-9fd5-ec86cea29fe1"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("0b6b68c9-dcc3-485a-b57f-261afccc563b"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("26561bf3-b86f-4f54-a467-95b4c665d313"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("513dc087-d049-4eda-8028-04bbb84da4eb"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("5dfb67f1-f3d3-484f-aba0-edd061a979f8"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("b64db9db-4f21-4a60-87c4-a3cfe8cc62d3"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("c8fbd975-680f-4789-8436-6da02eb8c515"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("edfdd34f-ab82-41b5-aeea-e70c94de11e5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("01359265-c494-48eb-8013-46fb74b70138"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("01f21fdf-7643-49d5-87d8-e43750f18222"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("06d0cf9a-9f39-4450-be55-aa7664f51dfd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0bc3bf73-9f19-48a9-8f43-b280638692a1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("286e8d49-0d47-4fd3-813d-4fca2ebad2fb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2cc9ba1d-2031-49fc-9cb0-49cf7861cb97"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("34cf6fc9-414e-43d7-b2b6-a3d0f295aabe"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("47a7159d-3750-435c-aa7d-c9d3cae0b288"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("501f860a-4fef-45d9-931f-3262d623fbb3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("61e82084-1580-45bb-8cee-1c49ff1ce68e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("67103671-a489-4fcf-bb2c-d64a87d1c37d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6c92a379-681e-4d60-bd6b-455f08dea4d5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6ed88f41-2a66-4ce0-b260-e024263be30e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("73c6a91a-392f-4805-b7d8-60067a48622c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("775980b6-b53a-49ee-a755-f9895ce056dd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7c4b1d60-c4fb-498d-bb9e-e31c2f6ea273"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7f6db1ee-bd2b-4496-8431-9ab1ef5ccee3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("83e285eb-0fe9-47a4-ac43-e57e81cb169c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("85f42658-b1ab-4675-bbfc-3a360405679a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("87392290-0fa1-4f27-bf71-37e251dd142a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8f8d01a1-7a7b-4df5-81a5-58c543bbd003"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9d9a2f5d-d3ee-46c7-a578-57d7154406a1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a683b43e-ce24-4038-8dc8-28db63800250"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b0742d90-9107-4995-a8a9-caf9912613bc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b476507a-e9a1-4f1d-8b27-6a935ea3585e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b5126541-af82-4238-b114-2e84486f4aca"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b7adee2a-35af-493c-90d7-94a564464c9b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bbde25a6-5757-4d2e-b164-8e0865f0fd57"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bccea54e-00b7-498e-ae27-fec9563dd07a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c3c195ad-15a1-489a-9144-63beea5b0911"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c9697c95-6bfb-4dc0-8b98-f4d99d82ffe4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e113cff2-2b54-4874-b9ee-33db47e6aaa3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e21d3173-4b0b-4d89-ad5c-b602ecc2028d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e2c38730-d943-41df-8301-10ced186371b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e8f17544-4d24-463b-916c-aede080578e0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ebc4ba13-f254-4893-8ec1-562415546f3a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ecb31258-af4c-46f6-a433-a131c0293c8d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f780a94e-fbaa-41e6-920a-f9e23a81fa02"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f9d6e3c7-33c8-4dd9-8056-5b4064fcc5e9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fa0c4a88-be68-47ec-9826-21444389b1ba"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("13552aa8-40b1-4e8a-9f98-45262b62c8cd"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("ad49cb68-76a6-4c28-beb0-de7214916611"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("b5e23022-9890-4156-9e63-9f2326efae6a"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("c4e5c3e7-2892-4d46-89c8-9faef418f553"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("1cd54103-7de5-4ef8-b7fe-8bb68a4776de"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("5beffe66-c807-4406-aadb-0e80fcbd4013"));

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsClosed = table.Column<bool>(type: "boolean", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdminUsers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("0f251e7a-cc96-4b04-98b4-e24f313cdeaf"), "john.doe@example.com", "John", "Doe", "4d337c6c91099310b0d66d3c581e10ea958971eef83251a3a0c615f948cb8372" },
                    { new Guid("c8729257-0e82-40b1-b2fb-5200c33f1ed2"), "jane.doe@example.com", "Jane", "Doe", "0e4d12c8083054721084530af46bb793e61a4cf1227610f9ba8eb5e5f787866a" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14969e97-76fe-44a0-9ee0-6929b1d63191"), "Building A" },
                    { new Guid("624d1900-4000-4288-bb7e-05aad525460c"), "Building B" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), "Chair" },
                    { new Guid("219caaee-16ad-4205-a906-e7c190339d63"), "Bookshelf" },
                    { new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), "Wardrobe" },
                    { new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), "Curtains" },
                    { new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), "Desk" },
                    { new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), "Lamp" },
                    { new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), "Bed" }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Number" },
                values: new object[,]
                {
                    { new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), new Guid("624d1900-4000-4288-bb7e-05aad525460c"), 2 },
                    { new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), new Guid("14969e97-76fe-44a0-9ee0-6929b1d63191"), 1 },
                    { new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), new Guid("624d1900-4000-4288-bb7e-05aad525460c"), 1 },
                    { new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), new Guid("14969e97-76fe-44a0-9ee0-6929b1d63191"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllowedPersons", "FloorId", "Number" },
                values: new object[,]
                {
                    { new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef"), 4, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-03" },
                    { new Guid("0658d770-508c-4122-a480-b628c04bbd14"), 4, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-10" },
                    { new Guid("09d758c8-de0e-445f-aaba-00efd30cc95d"), 4, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-01" },
                    { new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c"), 3, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-10" },
                    { new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47"), 5, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-07" },
                    { new Guid("16d0e689-e827-49ba-9f66-fcaefcb81e92"), 3, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-08" },
                    { new Guid("16f530e4-4ae3-4f2e-abb1-d25eee60aaf7"), 3, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-03" },
                    { new Guid("22d141f2-482e-413a-82d8-155e126b0c7b"), 4, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-10" },
                    { new Guid("253ae235-9a0c-44c3-8c25-b93fc1677407"), 5, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-09" },
                    { new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3"), 3, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-01" },
                    { new Guid("2ef4548b-5c59-4c79-94f0-5ef7234be1ec"), 5, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-09" },
                    { new Guid("33a2e0ee-8834-43c3-b9c9-8a0994a1d331"), 3, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-09" },
                    { new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58"), 3, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-04" },
                    { new Guid("4fe434a3-e072-4d2a-86a4-0845eacad4e5"), 5, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-02" },
                    { new Guid("53312856-4cee-450f-89dd-c9f94f58cd16"), 5, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-05" },
                    { new Guid("5a6c4841-8d60-4eed-bb70-71896f80bf0c"), 3, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-03" },
                    { new Guid("5b5dd9f9-4d4b-47fc-9262-b014a89d1a4d"), 3, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-04" },
                    { new Guid("6b73c63d-5849-454b-8dd6-dabdd589adc9"), 4, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-06" },
                    { new Guid("6c461032-a612-454c-8ba6-f20bc862a241"), 4, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-06" },
                    { new Guid("782cadc7-29a0-4a6a-bf88-f97ec7aee747"), 3, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-02" },
                    { new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08"), 4, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-08" },
                    { new Guid("7fad5428-25fd-4a12-a2b6-87ed21eb2e01"), 4, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-05" },
                    { new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9"), 4, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-08" },
                    { new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605"), 5, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-07" },
                    { new Guid("8a73eb50-c2df-41d8-88f8-2d3fa9bb8201"), 4, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-09" },
                    { new Guid("8cd34782-0561-449b-98e9-fc8d7d1fbf96"), 5, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-10" },
                    { new Guid("8dc4ceaa-8eec-4c51-947a-c4566ed1430f"), 5, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-07" },
                    { new Guid("9e50ae24-ab61-4f9a-b0f4-1fd3d832e43b"), 3, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-04" },
                    { new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5"), 4, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-01" },
                    { new Guid("ad177cdb-96ea-4236-9f8e-dc7747439d94"), 5, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-06" },
                    { new Guid("b2a4aa88-6a16-4c5d-8d5f-07f262b17d6d"), 5, new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"), "A1-05" },
                    { new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4"), 3, new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"), "B2-04" },
                    { new Guid("bd2cd950-65e9-46ea-8bb2-746cec262a9e"), 3, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-05" },
                    { new Guid("c42ba717-015f-4c8f-8350-8e91d230e4be"), 5, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-07" },
                    { new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f"), 3, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-01" },
                    { new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a"), 4, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-03" },
                    { new Guid("ce2c0784-7b42-4271-8f13-e95932057cc5"), 5, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-02" },
                    { new Guid("ed7da385-1883-4e8a-9bcc-6b31c224b0a7"), 5, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-06" },
                    { new Guid("f3fd5baf-5430-4e9c-9387-26a0bcc053a8"), 5, new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"), "B1-08" },
                    { new Guid("f4c42f77-0cdd-401e-b77e-afe2b9f349f2"), 4, new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"), "A2-02" }
                });

            migrationBuilder.InsertData(
                table: "RoomInventories",
                columns: new[] { "Id", "ActualQuantity", "ExpectedQuantity", "InventoryItemId", "RoomId" },
                values: new object[,]
                {
                    { new Guid("0029a6d3-bedd-4a25-9a81-aeae8959dd87"), 1, 4, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3") },
                    { new Guid("03bd570a-7e2a-4c0c-a98c-0226580e5b62"), 1, 4, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58") },
                    { new Guid("050e9912-c6cf-4460-a44e-d9b37d2242bc"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5") },
                    { new Guid("05aad1a5-4655-47a6-a79f-b7828fba801d"), 3, 3, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a") },
                    { new Guid("066f0e7a-4b8c-422e-bd2b-e42a5a504af7"), 2, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3") },
                    { new Guid("07456be3-9884-4419-84bd-9dcd9a1a3c50"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9") },
                    { new Guid("088a95ad-a8b9-4a46-ac07-8f17ad6b1fd3"), 3, 2, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("8a73eb50-c2df-41d8-88f8-2d3fa9bb8201") },
                    { new Guid("0ad6406a-8f08-47e5-8884-cfca2a7ec72a"), 1, 1, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("8dc4ceaa-8eec-4c51-947a-c4566ed1430f") },
                    { new Guid("0c63001b-f1ce-4423-aa3c-99f607df5ac3"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c") },
                    { new Guid("0e1075cd-d911-4b93-ab83-8c3b2942421f"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("ce2c0784-7b42-4271-8f13-e95932057cc5") },
                    { new Guid("0ec5216a-87e5-4bc1-a34a-3b62def725fd"), 2, 2, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("2ef4548b-5c59-4c79-94f0-5ef7234be1ec") },
                    { new Guid("1068967e-ce27-408c-8b1a-45e7f572a97d"), 1, 1, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4") },
                    { new Guid("120961b9-f60d-4ab7-8162-ca0da5053e55"), 3, 3, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("bd2cd950-65e9-46ea-8bb2-746cec262a9e") },
                    { new Guid("13056941-712d-4ac6-91df-65313aa8bcec"), 3, 2, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("f3fd5baf-5430-4e9c-9387-26a0bcc053a8") },
                    { new Guid("134f4fa2-f3bc-49da-976e-0f9d444f98eb"), 2, 2, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("f4c42f77-0cdd-401e-b77e-afe2b9f349f2") },
                    { new Guid("15913001-35c7-42b7-a255-061dfb4cf199"), 1, 1, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c") },
                    { new Guid("1687c17a-5e5f-40e4-81d3-8eef89eee566"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08") },
                    { new Guid("171f3c3b-e47d-49a2-a18f-fdbfa03755ef"), 2, 2, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("8a73eb50-c2df-41d8-88f8-2d3fa9bb8201") },
                    { new Guid("18097f5e-0074-4c9c-b750-0b48144fe50b"), 1, 1, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef") },
                    { new Guid("203fb690-8d69-4986-b5c0-2f9f9ade4f47"), 4, 4, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605") },
                    { new Guid("2193ef19-138b-4e8b-89b1-26b4e0e18651"), 2, 1, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("782cadc7-29a0-4a6a-bf88-f97ec7aee747") },
                    { new Guid("22b06dcb-a757-411d-9b74-aebfe24368e6"), 3, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("0658d770-508c-4122-a480-b628c04bbd14") },
                    { new Guid("22fc14d4-7c8f-4e00-882a-85558c61c02f"), 2, 2, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("22d141f2-482e-413a-82d8-155e126b0c7b") },
                    { new Guid("25796d0e-9050-450c-b52c-88958fbbf8b6"), 4, 4, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("f3fd5baf-5430-4e9c-9387-26a0bcc053a8") },
                    { new Guid("260b2303-2af5-447f-ba0b-596b2e2d9821"), 1, 1, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("53312856-4cee-450f-89dd-c9f94f58cd16") },
                    { new Guid("2673a5df-f471-469c-a986-5bdf98f3c681"), 4, 4, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("ed7da385-1883-4e8a-9bcc-6b31c224b0a7") },
                    { new Guid("291c1780-fe99-43ac-970d-bae8c82defb9"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c") },
                    { new Guid("2adad499-01fa-4074-85a3-4cfba9312d84"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605") },
                    { new Guid("2cdc2730-0900-4d9a-a2e0-61d236578f37"), 3, 3, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("16d0e689-e827-49ba-9f66-fcaefcb81e92") },
                    { new Guid("2d95f5d0-33a7-4db1-a7aa-08f6ebcbacb3"), 3, 1, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("0658d770-508c-4122-a480-b628c04bbd14") },
                    { new Guid("2fd01864-adaa-42f0-be50-7cf76ccd8c73"), 4, 4, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9") },
                    { new Guid("30b56e76-c4d9-4cb8-bdfe-4fd07790eeef"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("22d141f2-482e-413a-82d8-155e126b0c7b") },
                    { new Guid("35209758-24a9-4dec-a8b6-a5d4c5607dc6"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58") },
                    { new Guid("3603e847-de8f-4e47-827a-e86228b8347b"), 1, 1, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4") },
                    { new Guid("38a6fbc6-f439-4e2c-9256-b069cc0ff3b7"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("16f530e4-4ae3-4f2e-abb1-d25eee60aaf7") },
                    { new Guid("43053dd0-f7e7-4c93-81d7-013a9df7a0a6"), 1, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a") },
                    { new Guid("456451a9-3358-4ec6-8ce8-18907d3a8d5c"), 3, 3, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58") },
                    { new Guid("4820ccd3-b2e1-42b4-b50d-f47d02340f2d"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3") },
                    { new Guid("4ae3796c-3efc-45e5-a0aa-e3099b9bf926"), 2, 2, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9") },
                    { new Guid("50c00f1b-2ca0-40b2-90f9-cf755b6cc965"), 1, 1, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08") },
                    { new Guid("51dda55b-8c6a-4a9d-8b48-da9ac94d6c19"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("0658d770-508c-4122-a480-b628c04bbd14") },
                    { new Guid("524939bc-c69f-4870-945f-555a145b7b42"), 2, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58") },
                    { new Guid("53e8edec-cc2a-4207-8794-f022cf7d105e"), 1, 1, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("ad177cdb-96ea-4236-9f8e-dc7747439d94") },
                    { new Guid("54d3665f-8e85-4a4d-9b25-c205a5dc260e"), 1, 1, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a") },
                    { new Guid("58eb9320-9904-4e0d-985d-5f608ea5d796"), 1, 1, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef") },
                    { new Guid("5963ca1a-c8ce-4677-a0b1-d52ebf4b7239"), 1, 1, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef") },
                    { new Guid("5c31e715-4575-444d-bf61-c93dd61c8251"), 1, 1, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("22d141f2-482e-413a-82d8-155e126b0c7b") },
                    { new Guid("5c8ae99a-d404-4852-b7b6-e6079136db0b"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("ce2c0784-7b42-4271-8f13-e95932057cc5") },
                    { new Guid("5d2cf5ee-bffa-41d9-bbcd-adc03c0b59ff"), 1, 3, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47") },
                    { new Guid("5e0eee73-ec56-4da9-9886-e31a052a478a"), 3, 3, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("bd2cd950-65e9-46ea-8bb2-746cec262a9e") },
                    { new Guid("605227a7-3881-4f0b-8461-37b2b055c98d"), 4, 4, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("2ef4548b-5c59-4c79-94f0-5ef7234be1ec") },
                    { new Guid("60e7ba7f-968d-4672-8afd-fcf1078fef9f"), 3, 3, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("6c461032-a612-454c-8ba6-f20bc862a241") },
                    { new Guid("62abe065-661a-4125-91d9-c1092ec8e81d"), 2, 3, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58") },
                    { new Guid("643b20df-51b6-4222-bbdf-2da77e1d26b6"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3") },
                    { new Guid("6ae47987-39a2-4538-98a8-02ff6af4fba7"), 2, 2, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9") },
                    { new Guid("6bc1d125-18e5-4f69-b57c-4897bc13065d"), 2, 3, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("c42ba717-015f-4c8f-8350-8e91d230e4be") },
                    { new Guid("71077e86-0fa6-4a93-98aa-631c48579a18"), 4, 1, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f") },
                    { new Guid("71f56864-c6e1-4454-b136-ad3170f55c3f"), 4, 4, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("ed7da385-1883-4e8a-9bcc-6b31c224b0a7") },
                    { new Guid("72564a4b-e1f3-4ab2-ab09-6c80fc90bc3f"), 2, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("b2a4aa88-6a16-4c5d-8d5f-07f262b17d6d") },
                    { new Guid("74432f18-da8b-4674-86b3-f5e6735a4f6e"), 2, 2, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("2ef4548b-5c59-4c79-94f0-5ef7234be1ec") },
                    { new Guid("791f7968-6049-4bb1-a81b-e596243112bc"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("8a73eb50-c2df-41d8-88f8-2d3fa9bb8201") },
                    { new Guid("79923d92-2b5d-43ec-8b29-6b93214eb767"), 4, 2, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("5a6c4841-8d60-4eed-bb70-71896f80bf0c") },
                    { new Guid("7a15995d-a8ce-4473-8bbe-1760764c2f1c"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a") },
                    { new Guid("7bec88cf-66a8-4abe-9554-0e2f94ceb889"), 3, 3, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("09d758c8-de0e-445f-aaba-00efd30cc95d") },
                    { new Guid("7dcf3c5d-e9ef-47b4-9f7f-8c40e4b2a646"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47") },
                    { new Guid("7f74bdae-52bb-4b0e-8bcd-903a13cee825"), 4, 4, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("4fe434a3-e072-4d2a-86a4-0845eacad4e5") },
                    { new Guid("8476f6c4-c9d0-4ae7-bfbd-cbef78bb9757"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("f3fd5baf-5430-4e9c-9387-26a0bcc053a8") },
                    { new Guid("8560758e-51e3-4991-88e0-dc32331711dd"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3") },
                    { new Guid("862e838a-7eb9-436e-9526-c1388231ce20"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("16f530e4-4ae3-4f2e-abb1-d25eee60aaf7") },
                    { new Guid("86bcb23b-b0d0-4c0d-bd60-44ec768e5da3"), 2, 2, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605") },
                    { new Guid("8ae79b56-f8df-4adb-92e2-0f911ed81357"), 2, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f") },
                    { new Guid("8bede690-a1a5-4741-beed-71984c634c90"), 1, 1, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("6b73c63d-5849-454b-8dd6-dabdd589adc9") },
                    { new Guid("97444a89-e6ef-4c65-8753-4b7c6d6f394d"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a") },
                    { new Guid("987cc216-950d-4787-9d42-47e9489735be"), 1, 1, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47") },
                    { new Guid("98ff8d75-d2d0-4d2a-a096-79e70edff5aa"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("09d758c8-de0e-445f-aaba-00efd30cc95d") },
                    { new Guid("9a26d7a7-ff1a-40e0-89fa-c44c38190cea"), 1, 1, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("7fad5428-25fd-4a12-a2b6-87ed21eb2e01") },
                    { new Guid("9d0e9786-6974-4304-81ac-e372f7ec644a"), 2, 1, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("8a73eb50-c2df-41d8-88f8-2d3fa9bb8201") },
                    { new Guid("a02179b6-e527-4534-b33f-b9d7bb2bd337"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605") },
                    { new Guid("a463614d-93ef-4194-92d0-5b12875adfab"), 4, 1, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4") },
                    { new Guid("a4af5ada-e12c-42ac-842e-f8c9a80a2cb5"), 1, 1, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605") },
                    { new Guid("aed562a0-0b8b-402a-a498-7092356ef220"), 4, 4, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("782cadc7-29a0-4a6a-bf88-f97ec7aee747") },
                    { new Guid("b1145e7b-97de-47fe-9f79-ed630178592f"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c") },
                    { new Guid("b19d55a4-e439-4cf8-8c50-94df5a1fd8a1"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08") },
                    { new Guid("b31e635c-f58f-4345-9f0b-f972176fdb36"), 1, 1, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("16f530e4-4ae3-4f2e-abb1-d25eee60aaf7") },
                    { new Guid("b553c631-3ff6-4b80-aa9e-ec77a068aa5d"), 4, 3, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("5b5dd9f9-4d4b-47fc-9262-b014a89d1a4d") },
                    { new Guid("b5b8a197-d8e1-485c-97b8-c42f104bdff5"), 4, 3, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4") },
                    { new Guid("b5cb3c3b-0594-45ab-aa09-a66fb778083d"), 2, 2, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("6c461032-a612-454c-8ba6-f20bc862a241") },
                    { new Guid("b5dd4a68-81b2-413d-adab-6d1baadf9666"), 1, 2, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("ed7da385-1883-4e8a-9bcc-6b31c224b0a7") },
                    { new Guid("b67bffa1-3b82-4cc7-8dd6-234d99820fc9"), 3, 3, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("33a2e0ee-8834-43c3-b9c9-8a0994a1d331") },
                    { new Guid("b6aacca4-4872-462b-87b9-5f7e59e4688b"), 2, 2, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("09d758c8-de0e-445f-aaba-00efd30cc95d") },
                    { new Guid("b6e29518-e91b-4c29-8736-018c197d6e35"), 2, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5") },
                    { new Guid("b7a2fe25-3416-4d89-8117-ae0602df8165"), 2, 2, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef") },
                    { new Guid("b9aa5170-b237-4f80-9b6c-99828561e7aa"), 2, 2, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08") },
                    { new Guid("ba1fce1b-fd4c-417d-91e4-2d5c785c385f"), 2, 2, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f") },
                    { new Guid("bf5ba8a3-b563-4fa4-b027-072b6bf4640c"), 1, 3, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("16d0e689-e827-49ba-9f66-fcaefcb81e92") },
                    { new Guid("bf75fcd2-78e6-45df-b30a-ca1d2c4cd7ab"), 1, 1, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08") },
                    { new Guid("c180554f-c399-4d68-a0da-9a6ae2eaa51b"), 3, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("f4c42f77-0cdd-401e-b77e-afe2b9f349f2") },
                    { new Guid("c232c8fd-f9aa-460b-bf1e-66ab664df371"), 1, 1, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("9e50ae24-ab61-4f9a-b0f4-1fd3d832e43b") },
                    { new Guid("c2df65cd-fb1d-44d6-abbf-40049bd342f3"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47") },
                    { new Guid("c68fd777-a7a8-4ad9-b719-f94c494ee9db"), 3, 3, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("8cd34782-0561-449b-98e9-fc8d7d1fbf96") },
                    { new Guid("c9a1f8a8-162a-4102-a5f8-10a82643c0ef"), 2, 2, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c") },
                    { new Guid("cb4fe895-64ff-4d4d-a901-50903ded794b"), 4, 4, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c") },
                    { new Guid("cc2d7d43-c00c-4e52-8d3f-1e12c52a4d26"), 4, 4, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("782cadc7-29a0-4a6a-bf88-f97ec7aee747") },
                    { new Guid("ccbbedec-796e-4b73-9bd9-ceebc1334994"), 1, 2, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("0658d770-508c-4122-a480-b628c04bbd14") },
                    { new Guid("ccc591c1-17c2-4f7a-bf69-821dd75f857d"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5") },
                    { new Guid("ce8d8e1c-5b0a-42e0-9810-dac5561900db"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("8cd34782-0561-449b-98e9-fc8d7d1fbf96") },
                    { new Guid("d5d32350-d70d-4f80-b002-c8d245dff300"), 2, 2, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("7fad5428-25fd-4a12-a2b6-87ed21eb2e01") },
                    { new Guid("d6fa4a83-2f72-4615-abb8-d4d905066926"), 1, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9") },
                    { new Guid("d7cac3b0-4297-4945-aa90-47b5107f59ca"), 1, 1, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("9e50ae24-ab61-4f9a-b0f4-1fd3d832e43b") },
                    { new Guid("d82484a7-a930-4e23-bce3-08d6117d04d5"), 4, 4, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("5b5dd9f9-4d4b-47fc-9262-b014a89d1a4d") },
                    { new Guid("d992e0af-35ec-4cc8-b4f6-fb4487ab5d44"), 3, 3, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("16f530e4-4ae3-4f2e-abb1-d25eee60aaf7") },
                    { new Guid("da182319-b117-42f3-91b9-d090b7f09f7e"), 1, 1, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4") },
                    { new Guid("da557f9b-5e3d-4f70-9c3c-67f80f446db9"), 4, 4, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47") },
                    { new Guid("db0557d0-ee63-4928-a7e0-36678d928d3f"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("bd2cd950-65e9-46ea-8bb2-746cec262a9e") },
                    { new Guid("dc635b5f-de13-4b4f-ade0-83a25c498697"), 2, 2, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("5a6c4841-8d60-4eed-bb70-71896f80bf0c") },
                    { new Guid("e1090f7b-9abf-4622-a951-c5bf269b6bfd"), 1, 3, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5") },
                    { new Guid("e2e49048-8202-4203-8428-f86b373b5ca3"), 2, 2, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58") },
                    { new Guid("e32ab879-c249-4d33-a8d0-2a3844fbc34c"), 4, 4, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("5b5dd9f9-4d4b-47fc-9262-b014a89d1a4d") },
                    { new Guid("e3457602-25f2-465b-b273-78ed80d82f89"), 1, 1, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f") },
                    { new Guid("e41a24f2-ee43-4c9e-82cb-228305c6addd"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a") },
                    { new Guid("e4534556-1f30-459c-b419-967d5459292e"), 1, 1, new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"), new Guid("0658d770-508c-4122-a480-b628c04bbd14") },
                    { new Guid("ee1c7ab1-6b0d-43ad-aefa-dce8ca03c727"), 1, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08") },
                    { new Guid("ef8199d8-a9e2-407a-a5ca-c23f84eb86d3"), 4, 4, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("09d758c8-de0e-445f-aaba-00efd30cc95d") },
                    { new Guid("f046e37e-4c44-4137-a271-2d6cee7ae20f"), 4, 4, new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"), new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5") },
                    { new Guid("f29840ab-baaa-4726-80e9-91036bbd308c"), 2, 2, new Guid("1bc99984-7f63-4642-b005-0aab23caed86"), new Guid("782cadc7-29a0-4a6a-bf88-f97ec7aee747") },
                    { new Guid("f3674da6-f0d3-406e-bd58-14e44707a63a"), 2, 2, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605") },
                    { new Guid("f4da95c6-57ef-47f8-864c-4eac4a981c5f"), 1, 1, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3") },
                    { new Guid("f6287997-1284-4c12-ab4f-cfd33d218f9c"), 2, 2, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("8cd34782-0561-449b-98e9-fc8d7d1fbf96") },
                    { new Guid("f973592d-f1cb-4262-ae2f-f42217210d21"), 4, 4, new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"), new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef") },
                    { new Guid("fb6d8252-e867-4b20-8b8b-fff086a0bbd1"), 3, 3, new Guid("219caaee-16ad-4205-a906-e7c190339d63"), new Guid("253ae235-9a0c-44c3-8c25-b93fc1677407") },
                    { new Guid("fd555c6a-5f8f-4e50-9e45-27e7ae820098"), 3, 3, new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"), new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f") },
                    { new Guid("ffdbb3a7-92a6-430c-a1d9-14e2adb8132c"), 1, 1, new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"), new Guid("253ae235-9a0c-44c3-8c25-b93fc1677407") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RoomId",
                table: "Tickets",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StudentId",
                table: "Tickets",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f251e7a-cc96-4b04-98b4-e24f313cdeaf"));

            migrationBuilder.DeleteData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8729257-0e82-40b1-b2fb-5200c33f1ed2"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0029a6d3-bedd-4a25-9a81-aeae8959dd87"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("03bd570a-7e2a-4c0c-a98c-0226580e5b62"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("050e9912-c6cf-4460-a44e-d9b37d2242bc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("05aad1a5-4655-47a6-a79f-b7828fba801d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("066f0e7a-4b8c-422e-bd2b-e42a5a504af7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("07456be3-9884-4419-84bd-9dcd9a1a3c50"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("088a95ad-a8b9-4a46-ac07-8f17ad6b1fd3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0ad6406a-8f08-47e5-8884-cfca2a7ec72a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0c63001b-f1ce-4423-aa3c-99f607df5ac3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0e1075cd-d911-4b93-ab83-8c3b2942421f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("0ec5216a-87e5-4bc1-a34a-3b62def725fd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1068967e-ce27-408c-8b1a-45e7f572a97d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("120961b9-f60d-4ab7-8162-ca0da5053e55"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("13056941-712d-4ac6-91df-65313aa8bcec"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("134f4fa2-f3bc-49da-976e-0f9d444f98eb"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("15913001-35c7-42b7-a255-061dfb4cf199"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("1687c17a-5e5f-40e4-81d3-8eef89eee566"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("171f3c3b-e47d-49a2-a18f-fdbfa03755ef"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("18097f5e-0074-4c9c-b750-0b48144fe50b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("203fb690-8d69-4986-b5c0-2f9f9ade4f47"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2193ef19-138b-4e8b-89b1-26b4e0e18651"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("22b06dcb-a757-411d-9b74-aebfe24368e6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("22fc14d4-7c8f-4e00-882a-85558c61c02f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("25796d0e-9050-450c-b52c-88958fbbf8b6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("260b2303-2af5-447f-ba0b-596b2e2d9821"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2673a5df-f471-469c-a986-5bdf98f3c681"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("291c1780-fe99-43ac-970d-bae8c82defb9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2adad499-01fa-4074-85a3-4cfba9312d84"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2cdc2730-0900-4d9a-a2e0-61d236578f37"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2d95f5d0-33a7-4db1-a7aa-08f6ebcbacb3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("2fd01864-adaa-42f0-be50-7cf76ccd8c73"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("30b56e76-c4d9-4cb8-bdfe-4fd07790eeef"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("35209758-24a9-4dec-a8b6-a5d4c5607dc6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("3603e847-de8f-4e47-827a-e86228b8347b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("38a6fbc6-f439-4e2c-9256-b069cc0ff3b7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("43053dd0-f7e7-4c93-81d7-013a9df7a0a6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("456451a9-3358-4ec6-8ce8-18907d3a8d5c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4820ccd3-b2e1-42b4-b50d-f47d02340f2d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("4ae3796c-3efc-45e5-a0aa-e3099b9bf926"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("50c00f1b-2ca0-40b2-90f9-cf755b6cc965"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("51dda55b-8c6a-4a9d-8b48-da9ac94d6c19"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("524939bc-c69f-4870-945f-555a145b7b42"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("53e8edec-cc2a-4207-8794-f022cf7d105e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("54d3665f-8e85-4a4d-9b25-c205a5dc260e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("58eb9320-9904-4e0d-985d-5f608ea5d796"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5963ca1a-c8ce-4677-a0b1-d52ebf4b7239"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5c31e715-4575-444d-bf61-c93dd61c8251"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5c8ae99a-d404-4852-b7b6-e6079136db0b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5d2cf5ee-bffa-41d9-bbcd-adc03c0b59ff"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("5e0eee73-ec56-4da9-9886-e31a052a478a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("605227a7-3881-4f0b-8461-37b2b055c98d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("60e7ba7f-968d-4672-8afd-fcf1078fef9f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("62abe065-661a-4125-91d9-c1092ec8e81d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("643b20df-51b6-4222-bbdf-2da77e1d26b6"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6ae47987-39a2-4538-98a8-02ff6af4fba7"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("6bc1d125-18e5-4f69-b57c-4897bc13065d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("71077e86-0fa6-4a93-98aa-631c48579a18"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("71f56864-c6e1-4454-b136-ad3170f55c3f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("72564a4b-e1f3-4ab2-ab09-6c80fc90bc3f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("74432f18-da8b-4674-86b3-f5e6735a4f6e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("791f7968-6049-4bb1-a81b-e596243112bc"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("79923d92-2b5d-43ec-8b29-6b93214eb767"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7a15995d-a8ce-4473-8bbe-1760764c2f1c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7bec88cf-66a8-4abe-9554-0e2f94ceb889"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7dcf3c5d-e9ef-47b4-9f7f-8c40e4b2a646"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("7f74bdae-52bb-4b0e-8bcd-903a13cee825"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8476f6c4-c9d0-4ae7-bfbd-cbef78bb9757"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8560758e-51e3-4991-88e0-dc32331711dd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("862e838a-7eb9-436e-9526-c1388231ce20"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("86bcb23b-b0d0-4c0d-bd60-44ec768e5da3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8ae79b56-f8df-4adb-92e2-0f911ed81357"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("8bede690-a1a5-4741-beed-71984c634c90"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("97444a89-e6ef-4c65-8753-4b7c6d6f394d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("987cc216-950d-4787-9d42-47e9489735be"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("98ff8d75-d2d0-4d2a-a096-79e70edff5aa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9a26d7a7-ff1a-40e0-89fa-c44c38190cea"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("9d0e9786-6974-4304-81ac-e372f7ec644a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a02179b6-e527-4534-b33f-b9d7bb2bd337"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a463614d-93ef-4194-92d0-5b12875adfab"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("a4af5ada-e12c-42ac-842e-f8c9a80a2cb5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("aed562a0-0b8b-402a-a498-7092356ef220"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b1145e7b-97de-47fe-9f79-ed630178592f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b19d55a4-e439-4cf8-8c50-94df5a1fd8a1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b31e635c-f58f-4345-9f0b-f972176fdb36"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b553c631-3ff6-4b80-aa9e-ec77a068aa5d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b5b8a197-d8e1-485c-97b8-c42f104bdff5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b5cb3c3b-0594-45ab-aa09-a66fb778083d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b5dd4a68-81b2-413d-adab-6d1baadf9666"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b67bffa1-3b82-4cc7-8dd6-234d99820fc9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b6aacca4-4872-462b-87b9-5f7e59e4688b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b6e29518-e91b-4c29-8736-018c197d6e35"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b7a2fe25-3416-4d89-8117-ae0602df8165"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("b9aa5170-b237-4f80-9b6c-99828561e7aa"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ba1fce1b-fd4c-417d-91e4-2d5c785c385f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bf5ba8a3-b563-4fa4-b027-072b6bf4640c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("bf75fcd2-78e6-45df-b30a-ca1d2c4cd7ab"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c180554f-c399-4d68-a0da-9a6ae2eaa51b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c232c8fd-f9aa-460b-bf1e-66ab664df371"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c2df65cd-fb1d-44d6-abbf-40049bd342f3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c68fd777-a7a8-4ad9-b719-f94c494ee9db"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("c9a1f8a8-162a-4102-a5f8-10a82643c0ef"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cb4fe895-64ff-4d4d-a901-50903ded794b"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("cc2d7d43-c00c-4e52-8d3f-1e12c52a4d26"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ccbbedec-796e-4b73-9bd9-ceebc1334994"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ccc591c1-17c2-4f7a-bf69-821dd75f857d"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ce8d8e1c-5b0a-42e0-9810-dac5561900db"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d5d32350-d70d-4f80-b002-c8d245dff300"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d6fa4a83-2f72-4615-abb8-d4d905066926"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d7cac3b0-4297-4945-aa90-47b5107f59ca"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d82484a7-a930-4e23-bce3-08d6117d04d5"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("d992e0af-35ec-4cc8-b4f6-fb4487ab5d44"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("da182319-b117-42f3-91b9-d090b7f09f7e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("da557f9b-5e3d-4f70-9c3c-67f80f446db9"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("db0557d0-ee63-4928-a7e0-36678d928d3f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("dc635b5f-de13-4b4f-ade0-83a25c498697"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e1090f7b-9abf-4622-a951-c5bf269b6bfd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e2e49048-8202-4203-8428-f86b373b5ca3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e32ab879-c249-4d33-a8d0-2a3844fbc34c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e3457602-25f2-465b-b273-78ed80d82f89"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e41a24f2-ee43-4c9e-82cb-228305c6addd"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("e4534556-1f30-459c-b419-967d5459292e"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ee1c7ab1-6b0d-43ad-aefa-dce8ca03c727"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ef8199d8-a9e2-407a-a5ca-c23f84eb86d3"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f046e37e-4c44-4137-a271-2d6cee7ae20f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f29840ab-baaa-4726-80e9-91036bbd308c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f3674da6-f0d3-406e-bd58-14e44707a63a"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f4da95c6-57ef-47f8-864c-4eac4a981c5f"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f6287997-1284-4c12-ab4f-cfd33d218f9c"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("f973592d-f1cb-4262-ae2f-f42217210d21"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fb6d8252-e867-4b20-8b8b-fff086a0bbd1"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("fd555c6a-5f8f-4e50-9e45-27e7ae820098"));

            migrationBuilder.DeleteData(
                table: "RoomInventories",
                keyColumn: "Id",
                keyValue: new Guid("ffdbb3a7-92a6-430c-a1d9-14e2adb8132c"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("1bc99984-7f63-4642-b005-0aab23caed86"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("219caaee-16ad-4205-a906-e7c190339d63"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("2d36531b-1ceb-4b47-b469-a7bc6f9049c0"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("5c58d892-cf1b-4e66-84de-b68ac8b81583"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("7a22f39e-efa4-4ca1-8dae-1ae8b6aeb7d2"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("998523fb-9507-4db2-a0aa-971a0bf3d86f"));

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: new Guid("b2f00ff7-591c-4e45-964e-c1dd03ce2134"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0024ef1c-059e-4eac-a68c-6ae615ca57ef"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0658d770-508c-4122-a480-b628c04bbd14"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("09d758c8-de0e-445f-aaba-00efd30cc95d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c02c93a-9d1c-4bb1-b324-0187b72b102c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c1c77fe-ed23-4f0f-8e4e-274feb813a47"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("16d0e689-e827-49ba-9f66-fcaefcb81e92"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("16f530e4-4ae3-4f2e-abb1-d25eee60aaf7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("22d141f2-482e-413a-82d8-155e126b0c7b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("253ae235-9a0c-44c3-8c25-b93fc1677407"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2714a3af-69a3-4b0e-8599-d32a5cc5d8c3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2ef4548b-5c59-4c79-94f0-5ef7234be1ec"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("33a2e0ee-8834-43c3-b9c9-8a0994a1d331"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4c928ee3-6366-40f8-9ee6-93100e85bb58"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4fe434a3-e072-4d2a-86a4-0845eacad4e5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("53312856-4cee-450f-89dd-c9f94f58cd16"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5a6c4841-8d60-4eed-bb70-71896f80bf0c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5b5dd9f9-4d4b-47fc-9262-b014a89d1a4d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6b73c63d-5849-454b-8dd6-dabdd589adc9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6c461032-a612-454c-8ba6-f20bc862a241"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("782cadc7-29a0-4a6a-bf88-f97ec7aee747"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7ebeebec-644c-449c-ad0e-5fe6f998ff08"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7fad5428-25fd-4a12-a2b6-87ed21eb2e01"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("81e50420-2a54-4727-bad6-e50350b9f6a9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("82cb6d9f-fdd7-4e06-b037-39cfe3416605"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8a73eb50-c2df-41d8-88f8-2d3fa9bb8201"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8cd34782-0561-449b-98e9-fc8d7d1fbf96"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8dc4ceaa-8eec-4c51-947a-c4566ed1430f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9e50ae24-ab61-4f9a-b0f4-1fd3d832e43b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("aa1033b8-1e3e-4492-b8d7-680a96deb0a5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ad177cdb-96ea-4236-9f8e-dc7747439d94"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b2a4aa88-6a16-4c5d-8d5f-07f262b17d6d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ba9dbcec-2ea7-4d71-aea8-f2f80a7eb5b4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bd2cd950-65e9-46ea-8bb2-746cec262a9e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c42ba717-015f-4c8f-8350-8e91d230e4be"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cd9863d9-c2e1-4582-b69c-c74b5411406f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cdfeb53d-0729-4f79-b703-7d70ac94e03a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce2c0784-7b42-4271-8f13-e95932057cc5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ed7da385-1883-4e8a-9bcc-6b31c224b0a7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f3fd5baf-5430-4e9c-9387-26a0bcc053a8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f4c42f77-0cdd-401e-b77e-afe2b9f349f2"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("31544269-fe63-4ca0-bc6f-e435d563598e"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("5772ebaf-9330-4454-a348-1ddcec292d3d"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("ae28f8a0-f38d-4054-8398-2851c1eb9adb"));

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: new Guid("d814ee59-793b-403c-8ac1-00978cdbe354"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("14969e97-76fe-44a0-9ee0-6929b1d63191"));

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("624d1900-4000-4288-bb7e-05aad525460c"));

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
        }
    }
}
