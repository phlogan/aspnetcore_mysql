#pragma checksum "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf6e98ece104da9bc036854ee0d426e6cc125a02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6e98ece104da9bc036854ee0d426e6cc125a02", @"/Views/Shared/_Header.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\Shared\_Header.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <nav style=\"background-color: #6b7db3;\">\r\n    <div class=\"navbar-fixed\">\r\n        <div class=\"nav-wrapper\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 164, "\"", 199, 1);
#nullable restore
#line 8 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 171, Url.Action("Index", "Home"), 171, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"brand-logo\">\r\n                <i class=\"large material-icons\" style=\"color: white\">home</i>\r\n            </a>\r\n            <ul id=\"nav-mobile\" class=\"right hide-on-med-and-down\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 446, 1);
#nullable restore
#line 12 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 417, Url.Action("Login", "Login"), 417, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Login</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>\r\n</header>");
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
