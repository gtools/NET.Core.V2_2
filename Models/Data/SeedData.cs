using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NET.Core.V2_2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Models.Data
{
    public class SeedData
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any FTP_Pages.
                if (context.FTP_Pages.Any())
                {
                    return;   // DB has been seeded
                }
                context.FTP_Pages.AddRange(
                    new FTP_Page
                    {
                        Address = "Index",
                        Explain = "首页"
                    },

                    new FTP_Page
                    {
                        Address = "PrinterDriver",
                        Explain = "打印机驱动"
                    }
                );
                context.SaveChanges();

                if (context.FTP_FileGroups.Any())
                {
                    return;
                }
                context.FTP_FileGroups.AddRange(
                    new FTP_FileGroup
                    {
                        Name = "管理地址",
                        PId = 1
                    },

                    new FTP_FileGroup
                    {
                        Name = "医院软件下载",
                        PId = 1
                    },

                    new FTP_FileGroup
                    {
                        Name = "常用软件下载",
                        PId = 1
                    },

                    new FTP_FileGroup
                    {
                        Name = "系统地址",
                        PId = 1
                    },

                    new FTP_FileGroup
                    {
                        Name = "其它地址",
                        PId = 1
                    },

                    new FTP_FileGroup
                    {
                        Name = "管理工具",
                        PId = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
