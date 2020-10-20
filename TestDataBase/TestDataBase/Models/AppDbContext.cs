using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDataBase.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Thoisu> Thoisus { get; set; }
        public DbSet<Thegioi> Thegiois { get; set; }
        public DbSet<Thethao> Thethaos { get; set; }
        public DbSet<Suckhoe> Suckhoes { get; set; }
        public DbSet<Dulich> Duliches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Thời sự" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Thế giới" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Thể thao" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, CategoryName = "Sức khỏe" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, CategoryName = "Du lịch" });

            modelBuilder.Entity<Thoisu>().HasData(new Thoisu
            {
                Id = 1,
                Name = "Ba tỉnh miền Trung chìm trong mưa lũ",
                ImageUrl = "https://vovlive.1cdn.vn/2020/10/19/image-vtc-vn_lu-06454599.jpg",
                Description = "Sáng 20/10, hơn 177.920 nhà dân ở miền Trung đang bị ngập do mưa lũ, trong đó 3 tỉnh chịu ảnh hưởng nặng nhất là Hà Tĩnh, Quảng Bình và Quảng Trị.",
                CategoryId=1
            }); ;
            modelBuilder.Entity<Thegioi>().HasData(new Thegioi
            {
                Id = 1,
                Name = "Những nông dân Mỹ 'một lòng' với Trump",
                ImageUrl = "https://i1-vnexpress.vnecdn.net/2020/10/20/trump-nong-dna-3-6507-1603178278.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=09J4EplvLxsB4cDQzdtBNQ",
                Description = "Dù chiến tranh thương mại dưới thời chính quyền Tổng thống Trump khiến nhiều nông dân Mỹ điêu đứng, họ vẫn tin tưởng đặt cược tương lai vào ông. Khoảng hai tháng sau khi Tổng thống Donald Trump bắt đầu nhiệm kỳ thứ nhất, Ron Prestage cầm chiếc xẻng và cười tươi với một nhiếp ảnh gia trên cánh đồng ngô ở bang Iowa. Ông đã kiếm được 309 triệu USD nhờ khu đất rộng hơn 60 hecta gần thị trấn Eagle Grove, nơi sắp xây dựng một nhà máy sản xuất thịt lợn, giúp công ty Prestage Farms Inc. của gia đình kiếm tiền từ các ngành xuất khẩu đang phát triển của Mỹ.",
                CategoryId = 2
            }); ;
            modelBuilder.Entity<Thethao>().HasData(new Thethao
            {
                Id = 1,
                Name = "Tháng 12 đội tuyển Việt Nam hội quân",
                ImageUrl = "https://img.nhandan.com.vn/Files/Images/2020/06/13/1592042314000_fa24c455bd305f6b80cf3d0742e4ab95.jpg",
                Description = "HLV Park Hang-seo sẽ tập trung đội U22 và đội tuyển quốc gia sau khi các giải bóng đá chuyên nghiệp Việt Nam kết thúc.",
                CategoryId = 3
            }); ;
            modelBuilder.Entity<Suckhoe>().HasData(new Suckhoe
            {
                Id = 1,
                Name = "Vaccine Covid-19 Trung Quốc thử nghiệm giai đoạn cuối an toàn",
                ImageUrl = "https://i1-suckhoe.vnecdn.net/2020/10/20/download-13-1603165156-3580-1603165280.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=pD-6kUyQJQlnDGRYVcm-NA",
                Description = "Vaccine Covid-19 của hãng Sinovac Biotech cho thấy độ an toàn trong thử nghiệm lâm sàng giai đoạn cuối ở Brazil.",
                CategoryId = 4
            }); ;
            modelBuilder.Entity<Dulich>().HasData(new Dulich
            {
                Id = 1,
                Name = "Hòn đảo nơi biển có 7 màu",
                ImageUrl = "https://i1-dulich.vnecdn.net/2020/10/20/San-Andres-4861-1603192085.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=XBCe1NjxNgYuPLpS72v_gg",
                Description = "Nằm ngoài khơi Caribbean, cách bờ biển Colombia 720 km là quần đảo San Andrés với những hòn đảo nhỏ San Andrés, Providencia và Santa Catalina. Nơi này có những bãi biển cát trắng, làn nước trong như pha lê và nhiệt độ 27 độ C quanh năm. Tất cả những lợi thế này đã giúp cho ba hòn đảo xinh đẹp trở thành thiên đường nghỉ dưỡng nổi tiếng của người Colombia. Ngoài ra, nó còn nổi tiếng khắp thế giới nhờ sở hữu vùng nước biển bao quanh với 7 sắc thái xanh như ngọc lam, xanh dương, xanh tím than, xanh da trời, xanh lá...",
                CategoryId = 5
            }); ;
        }
    }
}
