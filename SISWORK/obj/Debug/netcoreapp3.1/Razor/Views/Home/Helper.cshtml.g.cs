#pragma checksum "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b9dc45c75c3e685d73d3fa36d52a883e04e2be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Helper), @"mvc.1.0.view", @"/Views/Home/Helper.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\_ViewImports.cshtml"
using SISWORK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\_ViewImports.cshtml"
using SISWORK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b9dc45c75c3e685d73d3fa36d52a883e04e2be", @"/Views/Home/Helper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34afa9c5dc7641e8b978d4e65b243a5ffb36aff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Helper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
  
    ViewBag.Title = "Helpers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"text\" name=\"firstname\" id=\"firstname\"");
            BeginWriteAttribute("value", " value=\"", 89, "\"", 97, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"first\">\r\n");
#nullable restore
#line 6 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
Write(Html.TextBox("firstname", "John",
    new
    {
        style = "background-color:Red; color: black; font-weight:bold",
        title = "Enter your name"
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"second\">\r\n    ");
#nullable restore
#line 14 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
Write(Html.TextBox("firstname", "First name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
Write(Html.Label("firstname", "Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
Write(Html.Password("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"third\">\r\n    ");
#nullable restore
#line 19 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
Write(Html.TextBox("firstname", "First name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 20 "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Helper.cshtml"
Write(Html.TextArea("Comments","",5,20,null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
