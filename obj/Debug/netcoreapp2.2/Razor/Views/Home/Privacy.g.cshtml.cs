#pragma checksum "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79841282caf411dd0555bdbec877f893654837bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\_ViewImports.cshtml"
using NET.Core.V2_2;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\_ViewImports.cshtml"
using NET.Core.V2_2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79841282caf411dd0555bdbec877f893654837bb", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4789e95135678e0dfe69ca3b846262d4dbdbcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "测试";

#line default
#line hidden
            BeginContext(38, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(43, 17, false);
#line 4 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(60, 17, true);
            WriteLiteral("</h1>\r\n\r\n<p>当前地址：");
            EndContext();
            BeginContext(78, 21, false);
#line 6 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml"
   Write(ViewData["Path_Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 16, true);
            WriteLiteral("</p>\r\n\r\n<p>上级地址：");
            EndContext();
            BeginContext(116, 23, false);
#line 8 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml"
   Write(ViewData["Path_UpName"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 16, true);
            WriteLiteral("</p>\r\n\r\n<p>完全地址：");
            EndContext();
            BeginContext(156, 16, false);
#line 10 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml"
   Write(ViewData["Path"]);

#line default
#line hidden
            EndContext();
            BeginContext(172, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(181, 77, false);
#line 12 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Home\Privacy.cshtml"
Write(await Component.InvokeAsync("FileList", new { path = ViewData["Path_Name"] }));

#line default
#line hidden
            EndContext();
            BeginContext(258, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
