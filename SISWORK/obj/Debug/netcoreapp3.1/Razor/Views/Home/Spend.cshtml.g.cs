#pragma checksum "C:\Users\user\source\repos\SISWORK\SISWORK\Views\Home\Spend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31410402e0f522f04ca1783f274816619426ab3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Spend), @"mvc.1.0.razor-page", @"/Views/Home/Spend.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31410402e0f522f04ca1783f274816619426ab3a", @"/Views/Home/Spend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34afa9c5dc7641e8b978d4e65b243a5ffb36aff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Spend : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:2000px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31410402e0f522f04ca1783f274816619426ab3a3526", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <script src=""http://code.jquery.com/jquery-latest.js""></script>
    <style>
        #field {
            width: 200px;
            height: 150px;
            border: 10px solid black;
            background-color: #00FF00;
            position: relative;
            overflow: hidden;
            cursor: pointer;
        }

        #ball {
            position: absolute;
            left: 0;
            top: 0;
            width: 40px;
            height: 40px;
            transition: all 1s;

        }
        p{
            position:absolute;
            text-align:center;
            font-size:60px;
            top: 23%;
        }
        button {
            position: absolute;
            text-align: center;
            font-size: 30px;
            top:27%;
        }
    </style>
    

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31410402e0f522f04ca1783f274816619426ab3a5364", async() => {
                WriteLiteral(@"
    <h1 style=""color:red;"">СПАСИБО ЧТО ПОСЕТИЛИ НАШ САЙТ!</h1>
    Оцените наши будущие разработки!
    <br>
    <div id=""field"">
        <img src=""https://ru.js.cx/clipart/ball.svg"" id=""ball""> . . . . . .
        . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
        . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
        . . . . . . . . . . . . . . . . . . . . . . .
        . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
        . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
        . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .
        . . . . . . . . . . . . . . . . . . . .
    </div>
    <script>
        field.onclick = function (event) {

            // координаты поля относительно окна браузера
            let fieldCoords = this.getBoundingClientRect();

            // мяч имеет абсолютное позиционирование (position:absolute), поле - относительное (position:relative)
            ");
                WriteLiteral(@"// таким образом, координаты мяча рассчитываются относительно внутреннего, верхнего левого угла поля
            let ballCoords = {
                top: event.clientY - fieldCoords.top - field.clientTop - ball.clientHeight / 2,
                left: event.clientX - fieldCoords.left - field.clientLeft - ball.clientWidth / 2
            };

            // запрещаем пересекать верхнюю границу поля
            if (ballCoords.top < 0) ballCoords.top = 0;

            // запрещаем пересекать левую границу поля
            if (ballCoords.left < 0) ballCoords.left = 0;


            // // запрещаем пересекать правую границу поля
            if (ballCoords.left + ball.clientWidth > field.clientWidth) {
                ballCoords.left = field.clientWidth - ball.clientWidth;
            }

            // запрещаем пересекать нижнюю границу поля
            if (ballCoords.top + ball.clientHeight > field.clientHeight) {
                ballCoords.top = field.clientHeight - ball.clientHeight;
         ");
                WriteLiteral(@"   }

            ball.style.left = ballCoords.left + 'px';
            ball.style.top = ballCoords.top + 'px';
        }
        status = 1;
        function switchStyle() {
            x = document.getElementById(""text"");
            if (status == 1) {
                x.style.color = 'blue';
                status = 2;
            }
            else if (status == 2) {
                x.style.color = 'red';
                status = 1;
            }
            
            
        }
    </script>
    <p id=""text"">ПОМЕНЯЙ МЕНЯ НА КРАСНЫЙ ИЛИ СИНИЙ :D</p><br>
    <button type=""button"" onclick=""javascript:switchStyle();"">Switch Style</button>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SISWORK.Views.Home.SpendModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SISWORK.Views.Home.SpendModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SISWORK.Views.Home.SpendModel>)PageContext?.ViewData;
        public SISWORK.Views.Home.SpendModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
