#pragma checksum "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "927054963fcc59fe46e6fee365ceef69638f94ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navbar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Navbar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Navbar_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927054963fcc59fe46e6fee365ceef69638f94ac", @"/Views/Shared/Components/Navbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4789e95135678e0dfe69ca3b846262d4dbdbcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Navbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NET.Core.V2_2.Models.SYS_Navbar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
  
    int i = 0;
    string str = "navbarDropdownMenuLink";

#line default
#line hidden
            BeginContext(122, 128, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-dark bg-info border-bottom box-shadow mb-3\">\r\n    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(250, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "927054963fcc59fe46e6fee365ceef69638f94ac5921", async() => {
                BeginContext(315, 11, true);
                WriteLiteral("第六人民医院信息化建设");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(330, 394, true);
            WriteLiteral(@"
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse d-sm-inline-flex flex-sm-row-reverse"" id=""navbarNavDropdown"">
            ");
            EndContext();
            BeginContext(724, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "927054963fcc59fe46e6fee365ceef69638f94ac7998", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(756, 117, true);
            WriteLiteral("\r\n            <ul class=\"navbar-nav flex-grow-1\">\r\n                <li class=\"nav-item active\">\r\n                    ");
            EndContext();
            BeginContext(873, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "927054963fcc59fe46e6fee365ceef69638f94ac9377", async() => {
                BeginContext(934, 2, true);
                WriteLiteral("首页");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(940, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 20 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                 foreach (var item in Model)
                {
                    if (item.Childs is null)
                    {
                        if (string.IsNullOrWhiteSpace(item.Url))
                        {

#line default
#line hidden
            BeginContext(1192, 83, true);
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                ");
            EndContext();
            BeginContext(1275, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "927054963fcc59fe46e6fee365ceef69638f94ac11622", async() => {
                BeginContext(1356, 39, false);
#line 27 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                        WriteLiteral(item.Controller);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                                      WriteLiteral(item.Action);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1399, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1520, 102, true);
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1622, "\"", 1638, 1);
#line 33 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
WriteAttributeValue("", 1629, item.Url, 1629, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1639, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1641, 39, false);
#line 33 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 35 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                        }
                    }
                    else
                    {
                        i++;

#line default
#line hidden
            BeginContext(1850, 128, true);
            WriteLiteral("                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\" href=\"#\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1978, "\"", 2000, 2);
#line 41 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
WriteAttributeValue("", 1983, str, 1983, 4, false);

#line default
#line hidden
#line 41 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
WriteAttributeValue("", 1987, i.ToString(), 1987, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2001, 115, true);
            WriteLiteral(" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                                ");
            EndContext();
            BeginContext(2117, 39, false);
#line 42 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 90, true);
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"dropdown-menu\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2246, "\"", 2281, 2);
#line 44 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
WriteAttributeValue("", 2264, str, 2264, 4, false);

#line default
#line hidden
#line 44 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
WriteAttributeValue("", 2268, i.ToString(), 2268, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2282, 65, true);
            WriteLiteral(">\r\n                                <span class=\"dropdown-header\">");
            EndContext();
            BeginContext(2348, 39, false);
#line 45 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 79, true);
            WriteLiteral("</span>\r\n                                <div class=\"dropdown-divider\"></div>\r\n");
            EndContext();
#line 47 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                 foreach (var arr in item.Childs)
                                {
                                    if (string.IsNullOrWhiteSpace(arr.Url))
                                    {

#line default
#line hidden
            BeginContext(2684, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2724, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "927054963fcc59fe46e6fee365ceef69638f94ac19406", async() => {
                BeginContext(2808, 38, false);
#line 51 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                                                                      Write(Html.DisplayFor(modelItem => arr.Name));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                     WriteLiteral(arr.Controller);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                                                  WriteLiteral(arr.Action);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2850, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2972, 64, true);
            WriteLiteral("                                        <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3036, "\"", 3051, 1);
#line 55 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
WriteAttributeValue("", 3043, arr.Url, 3043, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3052, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3054, 38, false);
#line 55 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => arr.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3092, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 56 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(3172, 67, true);
            WriteLiteral("                            </div>\r\n                        </li>\r\n");
            EndContext();
#line 60 "C:\Users\Administrator\Desktop\NET.Core.V2_2\NET.Core.V2_2\Views\Shared\Components\Navbar\Default.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3281, 55, true);
            WriteLiteral("            </ul>\r\n\r\n        </div>\r\n    </div>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NET.Core.V2_2.Models.SYS_Navbar>> Html { get; private set; }
    }
}
#pragma warning restore 1591