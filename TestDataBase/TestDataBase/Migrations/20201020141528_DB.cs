using Microsoft.EntityFrameworkCore.Migrations;

namespace TestDataBase.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duliches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duliches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Duliches_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suckhoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suckhoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suckhoes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thegiois",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thegiois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thegiois_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thethaos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thethaos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thethaos_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thoisus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thoisus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thoisus_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Thời sự", null },
                    { 2, "Thế giới", null },
                    { 3, "Thể thao", null },
                    { 4, "Sức khỏe", null },
                    { 5, "Du lịch", null }
                });

            migrationBuilder.InsertData(
                table: "Duliches",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, 5, "https://i1-dulich.vnecdn.net/2020/10/20/San-Andres-4861-1603192085.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=XBCe1NjxNgYuPLpS72v_gg", "https://i1-vnexpress.vnecdn.net/2020/10/20/Tong.jpg?w=&h=&q=100&dpr=1&fit=crop&s=J-M3uAWDHgnznPZkPUqcZA", "Hòn đảo nơi biển có 7 màu" });

            migrationBuilder.InsertData(
                table: "Suckhoes",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, 4, "Vaccine Covid-19 của hãng Sinovac Biotech cho thấy độ an toàn trong thử nghiệm lâm sàng giai đoạn cuối ở Brazil.", "https://i1-suckhoe.vnecdn.net/2020/10/20/download-13-1603165156-3580-1603165280.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=pD-6kUyQJQlnDGRYVcm-NA", "Vaccine Covid-19 Trung Quốc thử nghiệm giai đoạn cuối an toàn" });

            migrationBuilder.InsertData(
                table: "Thegiois",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, 2, "Dù chiến tranh thương mại dưới thời chính quyền Tổng thống Trump khiến nhiều nông dân Mỹ điêu đứng, họ vẫn tin tưởng đặt cược tương lai vào ông. Khoảng hai tháng sau khi Tổng thống Donald Trump bắt đầu nhiệm kỳ thứ nhất, Ron Prestage cầm chiếc xẻng và cười tươi với một nhiếp ảnh gia trên cánh đồng ngô ở bang Iowa. Ông đã kiếm được 309 triệu USD nhờ khu đất rộng hơn 60 hecta gần thị trấn Eagle Grove, nơi sắp xây dựng một nhà máy sản xuất thịt lợn, giúp công ty Prestage Farms Inc. của gia đình kiếm tiền từ các ngành xuất khẩu đang phát triển của Mỹ.", "https://i1-vnexpress.vnecdn.net/2020/10/20/trump-nong-dna-3-6507-1603178278.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=09J4EplvLxsB4cDQzdtBNQ", "Những nông dân Mỹ 'một lòng' với Trump" });

            migrationBuilder.InsertData(
                table: "Thethaos",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, 3, "HLV Park Hang-seo sẽ tập trung đội U22 và đội tuyển quốc gia sau khi các giải bóng đá chuyên nghiệp Việt Nam kết thúc.", "https://img.nhandan.com.vn/Files/Images/2020/06/13/1592042314000_fa24c455bd305f6b80cf3d0742e4ab95.jpg", "Tháng 12 đội tuyển Việt Nam hội quân" });

            migrationBuilder.InsertData(
                table: "Thoisus",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, 1, "Sáng 20/10, hơn 177.920 nhà dân ở miền Trung đang bị ngập do mưa lũ, trong đó 3 tỉnh chịu ảnh hưởng nặng nhất là Hà Tĩnh, Quảng Bình và Quảng Trị.", "https://i1-vnexpress.vnecdn.net/2020/10/20/Tong.jpg?w=&h=&q=100&dpr=1&fit=crop&s=J-M3uAWDHgnznPZkPUqcZA", "Ba tỉnh miền Trung chìm trong mưa lũ" });

            migrationBuilder.CreateIndex(
                name: "IX_Duliches_CategoryId",
                table: "Duliches",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Suckhoes_CategoryId",
                table: "Suckhoes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Thegiois_CategoryId",
                table: "Thegiois",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Thethaos_CategoryId",
                table: "Thethaos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Thoisus_CategoryId",
                table: "Thoisus",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Duliches");

            migrationBuilder.DropTable(
                name: "Suckhoes");

            migrationBuilder.DropTable(
                name: "Thegiois");

            migrationBuilder.DropTable(
                name: "Thethaos");

            migrationBuilder.DropTable(
                name: "Thoisus");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
