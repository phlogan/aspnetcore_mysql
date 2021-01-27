#pragma checksum "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f2da3e70cf36ff2002450bf6ccff9d5c670cbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_List), @"mvc.1.0.view", @"/Views/User/List.cshtml")]
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
#line 1 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
using BL.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f2da3e70cf36ff2002450bf6ccff9d5c670cbd", @"/Views/User/List.cshtml")]
    public class Views_User_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
  
    ViewBag.Title = "Listagem de usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"main-breadcrumb\">\r\n    <div class=\"nav-wrapper\">\r\n        <div class=\"col s12\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 218, "\"", 253, 1);
#nullable restore
#line 10 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 225, Url.Action("Index", "Home"), 225, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"breadcrumb\">Home</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 298, "\"", 335, 1);
#nullable restore
#line 11 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 305, Url.Action("Profile", "User"), 305, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"breadcrumb\">Perfil</a>\r\n            <a class=\"breadcrumb\">");
#nullable restore
#line 12 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                             Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n</nav>\r\n<div class=\"container\">\r\n    <div id=\"inner\">\r\n\r\n    </div>\r\n    <div class=\"row center\">\r\n        <div class=\"col m8 s12 offset-m2\">\r\n            <h4>Gerenciamento de usuários</h4>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 655, "\"", 688, 1);
#nullable restore
#line 23 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 662, Url.Action("New", "User"), 662, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn right"">Novo usuário<i class=""material-icons right"">add</i></a>
            <table>
                <thead>
                    <tr>
                        <th>E-mail</th>
                        <th>Username</th>
                        <th>Tipo de usuário</th>
                        <th class=""center"">Ações</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 34 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.UserType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1453, "\"", 1513, 1);
#nullable restore
#line 41 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1460, Url.Action("View", "User", new { id = user.UserId }), 1460, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small\" title=\"Visualizar\"><i class=\"material-icons\">portrait</i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1643, "\"", 1703, 1);
#nullable restore
#line 42 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1650, Url.Action("Edit", "User", new { id = user.UserId }), 1650, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small\" title=\"Editar\"><i class=\"material-icons\">mode_edit</i></a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1830, "\"", 1862, 3);
            WriteAttributeValue("", 1840, "remove(\'", 1840, 8, true);
#nullable restore
#line 43 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1848, user.UserId, 1848, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1860, "\')", 1860, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small btn-remove\" title=\"Remover\"><i class=\"material-icons\">delete</i></a>\r\n                        </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>

        </div>
    </div>
</div>

<script>
    const xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4) {
            if (xhr.status == 200) {
                location.reload();
                return false;
            }
            if (xhr.status == 404 || xhr.status == 400) {
                showErrorMessage(xhr.responseText);
            }
        }
    }

    function remove(id) {
        xhr.open(""post"", """);
#nullable restore
#line 71 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                     Write(Url.Action("Remove", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \"/\" + id, false);\r\n        xhr.send();\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
