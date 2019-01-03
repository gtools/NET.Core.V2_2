# ASP.Net Core Web 学习

## 1. 加载最新 twitter-bootstrap 前端框架

- 项目右键添加，添加客户端库，输入名称（名称@版本号）

> 提示 **.Net Core** 最新推出 [libman][2] ， [bower][3] 已弃用，
> 最新 [ASP.Net Core 2.2][1] 已更新为最新的 **twitter-bootstrap** 
> 和 **jquery** ，可跳过此步骤。

``` json
{
  "version": "1.0",
  "defaultProvider": "cdnjs",
  "libraries": [
    {
      "library": "twitter-bootstrap@4.1.3",
      "destination": "wwwroot/lib/twitter-bootstrap/4.1.3/"
    },
    {
      "library": "jquery@3.3.1",
      "destination": "wwwroot/lib/jquery/3.3.1/"
    },
    {
      "library": "jquery-validate@1.19.0",
      "destination": "wwwroot/lib/jquery-validate/1.19.0/"
    },
    {
      "library": "jquery-validation-unobtrusive@3.2.11",
      "destination": "wwwroot/lib/jquery-validation-unobtrusive/3.2.11/"
    },
    {
      "library": "font-awesome@4.7.0",
      "destination": "wwwroot/lib/font-awesome/4.7.0/"
    }
  ]
}
```

## 2. 修改首页引用

- _Layout.cshtml

``` html
<link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />
<!-- 修改 -->
<link rel="stylesheet" href="~/lib/twitter-bootstrap/4.1.3/css/bootstrap.min.css" />

<!-- 添加 -->
<link rel="stylesheet" href="~/lib/font-awesome/4.7.0/css/font-awesome.min.css" />

<script src="~/lib/jquery/dist/jquery.js"></script>
<script src="~/lib/bootstrap/dist/js/bootstrap.js"></script>
<!-- 修改 -->
<script src="~/lib/jquery/3.3.1/jquery.min.js"></script>
<script src="~/lib/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js"></script>
```

- _ValidationScriptsPartial.cshtml

``` html
<script src="~/lib/jquery-validation/dist/jquery.validate.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"></script>
<!-- 修改 -->
<script src="~/lib/jquery-validate/1.19.0/jquery.validate.min.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js"></script>
```

## 3. 创建模型

> 创建模型 **FTP_Page.cs** 页面模型、 **FTP_FileGroup.cs** 文件组模型、 
> **FTP_FileUrl.cs** 文件地址模型

## 4. 创建测试数据

> 创建测试数据 **DbInitializer.cs** 

## 5. 根据模型自动创建试图和控制器

> 控制器右键 > 添加 > 新搭建基架的项目 > 视图使用 Entity Framework 
> 的 MVC 控制器选择模型 > 选择数据上下文 > 添加

## 6. 添加测试数据的提交按钮

> 在 **FTP_PageController.cs** 中添加

``` C#
// 添加测试数据
// POST: FTP_Page/TestData/6
public async Task<IActionResult> TestData()
{
    await DbInitializer.Initialize(_context).SaveChangesAsync();
    return RedirectToAction(nameof(Index));
}
```

> 在 **FTP_Page/Create.cshtml** 中添加

``` html
<form asp-action="TestData">
    <input type="submit" value="测试数据" class="btn btn-primary" />
</form>
```

## 7. 新建数据库

- 创建迁移

``` PowerShell
Add-Migration InitialCreate
```

- 更新数据库

``` PowerShell
Update-Database
```

## 8. 完成

- 1.添加测试数据可能会出现PK出错，如果是外键错误，
请自行更改外键PID的值（已用新方法，#6 已弃用，改为一下代码）。

``` C#
modelBuilder.Entity<Test1>()
    .HasData(new Test1
    {
        Tid = Guid.Parse("{a1952052-7fdc-411d-86e3-dade962fb790}"),
        Address = "http://sample.com",
        Explain = "fds"
    });
```

- 2.下载文件只能在wwwroot文件夹目录下。

## 9. 新添加下载路径的文件列表页面

> 刚学习Net Core 2.2 搞了几天的视图页面发送数据到控制器不会，只能用a标签参数，
> 还有静态模型传输数据，以后在找新的办法，ajax又不会。哎

## 10. SQL Server GUID 主键测试

> Test1.Tid为GUID类型，在ApplicationDbContext.OnModelCreating方法中添加
> b.HasKey(t => t.Tid)和b.Property(t => t.Tid).HasDefaultValueSql("newid()")

``` C#
public class Test1
{
    public Guid Tid { get; set; }
        
    public string Address { get; set; }
}
```

> Test2.Tid为GUID类型，在ApplicationDbContext.OnModelCreating方法中添加
> b.HasKey(t => t.Tid)和b.Property(t => t.Tid).HasDefaultValueSql
> ("newsequentialid()")

``` C#
public class Test2
{
    public Guid Tid { get; set; }
        
    public string Address { get; set; }
}
```

> 注意：[newid()][4] 为少量数据或固定数据时使用，大量数据用 [newsequentialid()][5] 
> 默认值。（sql server 2008 以上才能使用）

## 11.根据 5 生成视图 Test2 进行 Guid 测试

> 注意：test2.Tid = Guid.NewGuid() 要不数据还是 newid()。

``` C#
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create([Bind("Tid,Address,Explain,Sort")] Test2 test2)
{
    if (ModelState.IsValid)
    {
        //test2.Tid = Guid.NewGuid();
        _context.Add(test2);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    return View(test2);
}
```

> 注意：newid() 和 newsequentialid() 区别请自行百度。

## 12. Identity 学习

> 注意：2.0到2.1 [Identity][6] 有重大改变，请参考[变动][7]
> （因为这个变动，我搞了一个星期才弄懂），一定要在项目右键 > 添加 > 新搭建
> 基建的项目 > 标识 > 标识 > 添加（才能有下图，坑啊，隐藏的太深了）。

![深坑](https://i-msdn.sec.s-msft.com/dynimg/IC879846.png)

## 13. 远程验证

> [Remote] 为[远程验证][8]，action 方法，controller 为控制器。

``` C#
/// <summary>
/// 科室编号
/// </summary>
[Remote(action: "VerifyDept_Code", controller: "SYS_Dept")]
[Required(ErrorMessage = Validate.Required)]
[StringLength(50, MinimumLength = 3, ErrorMessage = Validate.StringLength)]
[Display(Name = "科室编号", Order = 1)]
public string Dept_Code { get; set; }
```

> [dept_code] 为字段名（大小写无所谓）。

``` C#
[AcceptVerbs("Get", "Post")]
public IActionResult VerifyDept_Code(string dept_code)
{
    if (_context.SYS_Depts.Where(t => t.Dept_Code == dept_code).Count() > 0)
    {
        return Json($"部门代码 {dept_code} 已存在。");
    }

    return Json(true);
}
```



[1]: https://docs.microsoft.com/zh-cn/aspnet/core/?view=aspnetcore-2.2
[2]: https://docs.microsoft.com/zh-cn/aspnet/core/client-side/libman/?view=aspnetcore-2.2
[3]: https://docs.microsoft.com/zh-cn/aspnet/core/client-side/bower?view=aspnetcore-2.2
[4]: https://docs.microsoft.com/zh-cn/sql/t-sql/functions/newid-transact-sql?view=sql-server-2017
[5]: https://docs.microsoft.com/zh-cn/sql/t-sql/functions/newsequentialid-transact-sql?view=sql-server-2017
[6]: https://docs.microsoft.com/zh-cn/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=visual-studio
[7]: https://docs.microsoft.com/zh-cn/aspnet/core/migration/20_21?view=aspnetcore-2.2#changes-to-authentication-code
[8]: https://docs.microsoft.com/zh-cn/aspnet/core/mvc/models/validation?view=aspnetcore-2.2#remote-validation
