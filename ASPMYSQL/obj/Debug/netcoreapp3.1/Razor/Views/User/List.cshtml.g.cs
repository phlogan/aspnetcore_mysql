#pragma checksum "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ea68fa4f19fd957a0ba6b5cca93471d9c23b61"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ea68fa4f19fd957a0ba6b5cca93471d9c23b61", @"/Views/User/List.cshtml")]
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div id=\"inner\">\r\n\r\n    </div>\r\n    <div class=\"row center\">\r\n        <div class=\"col m8 s12 offset-m2\">\r\n            <h4>Gerenciamento de usuários</h4>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 310, "\"", 343, 1);
#nullable restore
#line 15 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 317, Url.Action("New", "User"), 317, 26, false);

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
#line 26 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.UserType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1168, 1);
#nullable restore
#line 33 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1115, Url.Action("View", "User", new { id = user.UserId }), 1115, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small\" title=\"Visualizar\" target=\"_blank\"><i class=\"material-icons\">portrait</i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1314, "\"", 1374, 1);
#nullable restore
#line 34 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1321, Url.Action("Edit", "User", new { id = user.UserId }), 1321, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small\" title=\"Editar\" target=\"_blank\"><i class=\"material-icons\">mode_edit</i></a>\r\n");
            WriteLiteral("                                <button type=\"button\" onclick=\"chamada()\"> teste </button>\r\n                        </td>\r\n                        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
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
                document.getElementById('inner').innerHTML = xhr.responseText;
            }
            if (xhr.status == 404) {
                alert(xhr.responseText);
            }
            if (xhr.status == 400) {
                alert(xhr.responseText);
            }
        }
    }

    function chamada() {
        xhr.open(""post"", """);
#nullable restore
#line 66 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                     Write(Url.Action("Remove", "User", new { id = Guid.Parse("85DCEAE9-983F-43E9-ADDC-0A0ADAC888CD")}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", false);\r\n        xhr.send();\r\n    }\r\n\r\n</script>");
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
