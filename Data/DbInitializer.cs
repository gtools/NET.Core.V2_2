using NET.Core.V2_2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Data
{
    public static class DbInitializer
    {
        public static ApplicationDbContext Initialize(ApplicationDbContext context)
        {
            // context.Database.EnsureCreated();

            // SYS_FileGroups是否存在数据
            if (context.FTP_Pages.Any())
                return context;

            var SYS_Pages = new FTP_Page[]
            {
            new FTP_Page{ Address="Index", Explain="首页" },
            new FTP_Page{ Address="PrinterDriver", Explain="打印机驱动" }
            };
            foreach (FTP_Page s in SYS_Pages)
            {
                context.FTP_Pages.Add(s);
            }
            context.SaveChanges();

            if (context.FTP_FileGroups.Any())
                return context;

            var SYS_FileGroups = new FTP_FileGroup[]
            {
            new FTP_FileGroup{ Name="管理地址" , PId=1 },
            new FTP_FileGroup{ Name="医院软件下载" , PId=1 },
            new FTP_FileGroup{ Name="常用软件下载" , PId=1 },
            new FTP_FileGroup{ Name="系统地址" , PId=1 },
            new FTP_FileGroup{ Name="其它地址" , PId=1 },
            new FTP_FileGroup{ Name="管理工具", PId=1 }
            };
            foreach (FTP_FileGroup s in SYS_FileGroups)
            {
                context.FTP_FileGroups.Add(s);
            }
            context.SaveChanges();
            return context;
        }
    }
}
