﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NET.Core.V2_2.Areas.Identity.Data;
using NET.Core.V2_2.Models;

namespace NET.Core.V2_2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>//添加用户扩展类
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
        /// <summary>
        /// 测试表
        /// </summary>
        public DbSet<Test1> Test1s { get; set; }
        /// <summary>
        /// 测试表
        /// </summary>
        public DbSet<Test2> Test2s { get; set; }
        /// <summary>
        /// 人员表
        /// </summary>
        public DbSet<SYS_Emp> SYS_Emps { get; set; }
        /// <summary>
        /// 科室表
        /// </summary>
        public DbSet<SYS_Dept> SYS_Depts { get; set; }
        /// <summary>
        /// 菜单表
        /// </summary>
        public DbSet<SYS_Navbar> SYS_Navbars { get; set; }

        //数据库字段配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //少量数据用newid()默认值，创建用test2.Tid = Guid.NewGuid()（或不写没有测试）;
            //大量数据用newsequentialid()默认值，创建用test2.Tid不能等于Guid.NewGuid()（已测试）;
            //模型种子数据，例如，这会将配置的种子数据Blog在OnModelCreating:   https://docs.microsoft.com/zh-cn/ef/core/modeling/data-seeding?view=aspnetcore-2.2
            //modelBuilder.Entity<Blog>().HasData(new Blog { BlogId = 1, Url = "http://sample.com" });
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

            modelBuilder.Entity<Test1>(b => {
                b.HasKey(t => t.Tid);
                b.Property(t => t.Tid)
                .HasDefaultValueSql("newid()");

                b.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(50);

                b.Property(t => t.Explain)
                .HasMaxLength(50);

                b.Property(t => t.Sort)
                .HasMaxLength(5)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<Test2>(b => {
                b.HasKey(t => t.Tid);
                b.Property(t => t.Tid)
                .HasDefaultValueSql("newsequentialid()");

                b.Property(t => t.Sort)
                .HasMaxLength(5)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<Test1>()
                .HasData(new Test1
                {
                    Tid = Guid.Parse("{a1952052-7fdc-411d-86e3-dade962fb790}"),
                    Address = "http://sample.com",
                    Explain = "fds"
                });

            modelBuilder.Entity<Test2>()
                .HasData(new Test2
                {
                    Tid = Guid.Parse("{61d8230f-7b89-4f15-8e79-ae65966a929e}"),
                    Address = "1",
                    Explain = "1"
                }, new Test2
                {
                    Tid = Guid.Parse("{31975595-26e5-47c1-bb8c-21b579a11b6b}"),
                    Address = "2",
                    Explain = "1"
                },new Test2
                {
                    Tid = Guid.Parse("{17ba4f00-ed3a-4a2f-9a2f-26bdb9f11420}"),
                    Address = "3",
                    Explain = "4"
                },new Test2
                {
                    Tid = Guid.Parse("{c4fb37e8-9f4d-40a8-b469-06b026e682a4}"),
                    Address = "5",
                    Explain = "5"
                });
            //科室
            modelBuilder.Entity<SYS_Dept>(b => {
                b.HasKey(t => t.Dept_Code);

                b.Property(t => t.Dept_Name)
                .IsRequired()
                .HasMaxLength(50);
            });
            //人员
            modelBuilder.Entity<SYS_Emp>(b => {
                b.HasKey(t => t.Emp_Code);

                b.Property(t => t.Emp_Name)
                .IsRequired()
                .HasMaxLength(50);

                b.HasOne(t => t.SYS_Dept)
                .WithMany(t => t.SYS_Emps)
                .HasForeignKey(t => t.Dept_Code);
            });
            //菜单
            //modelBuilder.Entity<SYS_Navbar>();//包括类
            //modelBuilder.Ignore<SYS_Navbar>();//排除类
            //b.Ignore(t => t.LoadedFromDatabase);//排除属性
            //b.ToTable("SYS_Navbar");//表名称
            //.HasColumnName("blog_id");//列名
            //.HasColumnType("varchar(200)");//数据类型
            //b.HasKey(b => b.BlogId).HasName("PrimaryKey_BlogId");//主键
            //.HasComputedColumnSql("[LastName] + ', ' + [FirstName]");//计算列
            //.HasDefaultValue(3);//默认值
            //.HasDefaultValueSql("getdate()");//默认值

            /* //外键
            .HasOne(p => p.Blog)
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BlogId)
            .HasConstraintName("ForeignKey_Post_Blog");
            */ //外键

            /*   //序列
            modelBuilder.HasSequence<int>("OrderNumbers", schema: "shared")
            .StartsAt(1000)
            .IncrementsBy(5);

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderNo)
                .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumbers");
            */  //序列

            //菜单表
            modelBuilder.Entity<SYS_Navbar>(b => {
                b.ToTable("SYS_Navbar");//表名称

                b.HasKey(t => t.Id);

                b.Property(t => t.Id)
                .HasDefaultValueSql("newid()");

                b.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

                b.Property(t => t.Url)
                .IsRequired();

                b.Property(t => t.Sort)
                .HasDefaultValue(0);

                b.Property(t => t.Is_Stop)
                .HasDefaultValue(false);

                b.HasOne(t => t.Father)
                .WithMany(t => t.Childs)
                .HasForeignKey(t => t.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull);//子关联不可级联删除
            });




        }
    }
}