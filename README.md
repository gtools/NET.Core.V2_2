# ASP.Net Core Web 学习

## 1. 加载最新 twitter-bootstrap 前端框架

- 项目右键添加，添加客户端库，输入名称（名称@版本号）

> 提示 **.Net Core** 最新推出 **libman** ， **bower** 已弃用，
> 最新 **ASP.Net Core 2.2** 已更新为最新的 **twitter-bootstrap** 
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

> 注意：
> - 1.添加测试数据可能会出现PK出错，如果是外键错误，请自行更改外键PID的值。
> - 2.下载文件只能在wwwroot文件夹目录下。

