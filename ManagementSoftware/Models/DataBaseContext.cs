using ManagementSoftware.DAL;
using ManagementSoftware.Models.TramBomNuoc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ManagementSoftware.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public DbSet<Digital> Digitals { get; set; }
        public DbSet<Analog> Analogs { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertHistory> AlertHistorys { get; set; }
        public DbSet<DoThiKhuynhHuong> DoThiKhuynhHuongs { get; set; }
        public DbSet<XuHuongVaTinHieu> XuHuongVaTinHieus { get; set; }






        // Tạo ILoggerFactory 
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                   .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information)
                   .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            //.AddDebug();
        }
        );

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                //.UseLoggerFactory(loggerFactory)  // - Thiết lập sử Logger
                .UseSqlServer(Common.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //user
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).HasDefaultValueSql("('123')");
                entity.HasIndex(e => e.Username).IsUnique();
            });

            //group
            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.IsManagementGroup).HasDefaultValueSql("(0)");
                entity.Property(e => e.IsManagementUser).HasDefaultValueSql("(0)");
                entity.HasIndex(e => e.GroupName).IsUnique();

            });

            //activity
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });

            //digital
            modelBuilder.Entity<Digital>(entity =>
            {
                entity.Property(e => e.ThoiGian).HasDefaultValueSql("(getdate())");
            });
            //analog
            modelBuilder.Entity<Analog>(entity =>
            {
                entity.Property(e => e.ThoiGian).HasDefaultValueSql("(getdate())");
            });
            //alert
            modelBuilder.Entity<Alert>(entity =>
            {
                entity.Property(e => e.ThoiGian).HasDefaultValueSql("(getdate())");
            });
            //alert history
            modelBuilder.Entity<AlertHistory>(entity =>
            {
                entity.Property(e => e.ThoiGian).HasDefaultValueSql("(getdate())");
            });
            modelBuilder.Entity<DoThiKhuynhHuong>(entity => {
                entity.HasIndex(e => e.TenDoThi).IsUnique();
            });


        }
        public void CreateDatabase()
        {
            //this.Database.EnsureDeleted();
            if (this.Database.EnsureCreated() == true)
            {
                //tao quuyen cho admin
                DALGroup.AddGroup(Common.GroupAdmin);
                //tao tai khoan admin
                DALUser.AddUser(Common.UserAdmin);

                DALActivity.AddActivity(new Activity("Hệ thống", "Khởi tạo tài khoản admin.", Common.UserAdmin.Username));
            }
        }
        public bool ResetDB()
        {
            try
            {
                if (this.Database.EnsureDeleted() == true && this.Database.EnsureCreated() == true)
                {
                    //tao quuyen cho admin
                    DALGroup.AddGroup(Common.GroupAdmin);
                    //tao tai khoan admin
                    DALUser.AddUser(Common.UserAdmin);
                    DALActivity.AddActivity(new Activity("Hệ thống", "Khởi tạo tài khoản admin.", Common.UserAdmin.Username));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }



        }

    }
}
