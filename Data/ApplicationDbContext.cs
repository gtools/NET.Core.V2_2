using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NET.Core.V2_2.Models;

namespace NET.Core.V2_2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// 页面
        /// </summary>
        public DbSet<FTP_Page> FTP_Pages { get; set; }
        /// <summary>
        /// 文件组
        /// </summary>
        public DbSet<FTP_FileGroup> FTP_FileGroups { get; set; }
        /// <summary>
        /// 文件地址
        /// </summary>
        public DbSet<FTP_FileUrl> FTP_FileUrls { get; set; }

        //数据库字段配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FTP_Page>(b => {
                b.HasKey(t => t.PId);//主键TitleId

                b.Property(t => t.Address)
                .IsRequired()//不为空
                .HasMaxLength(50);//最大长度

                b.Property(t => t.Explain)
                .HasMaxLength(50);

                b.Property(t => t.Sort)
                .HasMaxLength(5)
                .HasDefaultValue(0);//默认值
                //.HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<FTP_FileGroup>(b => {
                b.HasKey(t => t.FGId);

                b.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

                b.Property(t => t.Sort)
                .HasMaxLength(5)
                .HasDefaultValue(0);

                b.HasOne(t => t.FTP_Page)
                .WithMany(t => t.FTP_FileGroups)
                .HasForeignKey(t => t.PId)//外键
                //.HasConstraintName("ForeignKey_Post_Blog");//配置外键名称
                .OnDelete(DeleteBehavior.Cascade);//级联删除
            });

            modelBuilder.Entity<FTP_FileUrl>(b => {
                b.HasKey(t => t.FUId);

                b.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

                b.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(50);

                b.Property(t => t.Sort)
                .HasMaxLength(5)
                .HasDefaultValue(0);

                b.HasOne(t => t.FTP_FileGroup)
                .WithMany(t => t.FTP_FileUrls)
                .HasForeignKey(t => t.FGId)
                .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
