﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDataBase.Models;

namespace TestDataBase.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201020141653_seeder_table_Thethao")]
    partial class seeder_table_Thethao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestDataBase.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Thời sự"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Thế giới"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Thể thao"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Sức khỏe"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Du lịch"
                        });
                });

            modelBuilder.Entity("TestDataBase.Models.Dulich", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Duliches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            Description = "https://i1-dulich.vnecdn.net/2020/10/20/San-Andres-4861-1603192085.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=XBCe1NjxNgYuPLpS72v_gg",
                            ImageUrl = "https://i1-vnexpress.vnecdn.net/2020/10/20/Tong.jpg?w=&h=&q=100&dpr=1&fit=crop&s=J-M3uAWDHgnznPZkPUqcZA",
                            Name = "Hòn đảo nơi biển có 7 màu"
                        });
                });

            modelBuilder.Entity("TestDataBase.Models.Suckhoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Suckhoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Description = "Vaccine Covid-19 của hãng Sinovac Biotech cho thấy độ an toàn trong thử nghiệm lâm sàng giai đoạn cuối ở Brazil.",
                            ImageUrl = "https://i1-suckhoe.vnecdn.net/2020/10/20/download-13-1603165156-3580-1603165280.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=pD-6kUyQJQlnDGRYVcm-NA",
                            Name = "Vaccine Covid-19 Trung Quốc thử nghiệm giai đoạn cuối an toàn"
                        });
                });

            modelBuilder.Entity("TestDataBase.Models.Thegioi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Thegiois");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Dù chiến tranh thương mại dưới thời chính quyền Tổng thống Trump khiến nhiều nông dân Mỹ điêu đứng, họ vẫn tin tưởng đặt cược tương lai vào ông. Khoảng hai tháng sau khi Tổng thống Donald Trump bắt đầu nhiệm kỳ thứ nhất, Ron Prestage cầm chiếc xẻng và cười tươi với một nhiếp ảnh gia trên cánh đồng ngô ở bang Iowa. Ông đã kiếm được 309 triệu USD nhờ khu đất rộng hơn 60 hecta gần thị trấn Eagle Grove, nơi sắp xây dựng một nhà máy sản xuất thịt lợn, giúp công ty Prestage Farms Inc. của gia đình kiếm tiền từ các ngành xuất khẩu đang phát triển của Mỹ.",
                            ImageUrl = "https://i1-vnexpress.vnecdn.net/2020/10/20/trump-nong-dna-3-6507-1603178278.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=09J4EplvLxsB4cDQzdtBNQ",
                            Name = "Những nông dân Mỹ 'một lòng' với Trump"
                        });
                });

            modelBuilder.Entity("TestDataBase.Models.Thethao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Thethaos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Description = "HLV Park Hang-seo sẽ tập trung đội U22 và đội tuyển quốc gia sau khi các giải bóng đá chuyên nghiệp Việt Nam kết thúc.",
                            ImageUrl = "https://img.nhandan.com.vn/Files/Images/2020/06/13/1592042314000_fa24c455bd305f6b80cf3d0742e4ab95.jpg",
                            Name = "Tháng 12 đội tuyển Việt Nam hội quân"
                        });
                });

            modelBuilder.Entity("TestDataBase.Models.Thoisu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Thoisus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Sáng 20/10, hơn 177.920 nhà dân ở miền Trung đang bị ngập do mưa lũ, trong đó 3 tỉnh chịu ảnh hưởng nặng nhất là Hà Tĩnh, Quảng Bình và Quảng Trị.",
                            ImageUrl = "https://i1-vnexpress.vnecdn.net/2020/10/20/Tong.jpg?w=&h=&q=100&dpr=1&fit=crop&s=J-M3uAWDHgnznPZkPUqcZA",
                            Name = "Ba tỉnh miền Trung chìm trong mưa lũ"
                        });
                });

            modelBuilder.Entity("TestDataBase.Models.Dulich", b =>
                {
                    b.HasOne("TestDataBase.Models.Category", "Category")
                        .WithMany("Duliches")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestDataBase.Models.Suckhoe", b =>
                {
                    b.HasOne("TestDataBase.Models.Category", "Category")
                        .WithMany("Suckhoes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestDataBase.Models.Thegioi", b =>
                {
                    b.HasOne("TestDataBase.Models.Category", "Category")
                        .WithMany("Thegiois")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestDataBase.Models.Thethao", b =>
                {
                    b.HasOne("TestDataBase.Models.Category", "Category")
                        .WithMany("Thethaos")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestDataBase.Models.Thoisu", b =>
                {
                    b.HasOne("TestDataBase.Models.Category", "Category")
                        .WithMany("Thoisus")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
