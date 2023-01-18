using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
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
        public DbSet<DigitalHistory> DigitalHistories { get; set; }

        public DbSet<Analog> Analogs { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertHistory> AlertHistorys { get; set; }
        public DbSet<AlertHistory2> AlertHistory2s { get; set; }

        public DbSet<DoThiKhuynhHuong> DoThiKhuynhHuongs { get; set; }
        public DbSet<XuHuongVaTinHieu> XuHuongVaTinHieus { get; set; }

        public DbSet<DateInitDatabase> DateInitDatabases { get; set; }




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
            //digital hisstory
            modelBuilder.Entity<DigitalHistory>(entity =>
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
            modelBuilder.Entity<AlertHistory2>(entity =>
            {
                entity.Property(e => e.ThoiGian).HasDefaultValueSql("(getdate())");
            });
            modelBuilder.Entity<DoThiKhuynhHuong>(entity =>
            {
                entity.HasIndex(e => e.TenDoThi).IsUnique();
            });

            //db
            modelBuilder.Entity<DateInitDatabase>(entity =>
            {
                entity.Property(e => e.CreateAt).HasDefaultValueSql("(getdate())");
            });


        }
        public async void CreateDatabase()
        {
            //this.Database.EnsureDeleted();
            if (this.Database.EnsureCreated() == true)
            {

                this.DateInitDatabases.Add(new DateInitDatabase());
                this.SaveChanges();


                //tao quuyen cho admin
                DALGroup.AddGroup(Common.GroupAdmin);
                //tao tai khoan admin
                DALUser.AddUser(Common.UserAdmin);

                DALActivity.AddActivity(new Activity("Hệ thống", "Khởi tạo tài khoản admin.", Common.UserAdmin.Username));

                try
                {


                    var x = DALDigitalHistory.GetAll();
                    if (x == null || x.Count < 1)
                    {
                        PLCDigital plcDigital = new PLCDigital();
                        if (await plcDigital.Open() == 0)
                        {
                            List<Digital>? listDigital = await plcDigital.GetListDataDigital(new DigitalCommon().ListAllDigitals);
                            if (listDigital != null && listDigital.Count > 0)
                            {
                                await DALDigitalHistory.AddRangeHistory(listDigital);
                            }
                            else
                            {
                                this.Database.EnsureDeleted();
                                Application.Restart();
                            }

                            await plcDigital.Close();
                        }
                        else
                        {
                            this.Database.EnsureDeleted();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        this.Database.EnsureDeleted();
                        Application.Restart();
                    }







                    var xs = DALAlertHistory2.GetAll();
                    if (xs == null || xs.Count < 1)
                    {
                        PLCAlert plcAlert = new PLCAlert();
                        if (await plcAlert.Open() == 0)
                        {
                            List<Alert>? listAlert = await plcAlert.GetListDataAlert(new AlertCommon().ListAllAlerts);
                            if (listAlert != null && listAlert.Count > 0)
                            {
                                await DALAlertHistory2.AddRangeHistory(listAlert);
                            }
                            else
                            {
                                this.Database.EnsureDeleted();
                                Application.Restart();
                            }

                            await plcAlert.Close();
                        }
                        else
                        {
                            this.Database.EnsureDeleted();
                            Application.Restart();
                        }
                    }
                    else
                    {
                        this.Database.EnsureDeleted();
                        Application.Restart();
                    }



                 
                }
                catch
                {
                    this.Database.EnsureDeleted();
                    Application.Restart();
                }


            }
        }


    }
}
