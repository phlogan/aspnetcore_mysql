#pragma checksum "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aefdae43d7fd3248a063e168a8c86b3ccd2e95ad"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aefdae43d7fd3248a063e168a8c86b3ccd2e95ad", @"/Views/User/List.cshtml")]
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row center\">\r\n        <div class=\"col m8 s12 offset-m2\">\r\n            <h4>Gerenciamento de usuários</h4>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 274, "\"", 307, 1);
#nullable restore
#line 12 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 281, Url.Action("New", "User"), 281, 26, false);

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
#line 23 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                           Write(user.UserType.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1072, "\"", 1132, 1);
#nullable restore
#line 30 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1079, Url.Action("View", "User", new { id = user.UserId }), 1079, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small\" title=\"Visualizar\" target=\"_blank\"><i class=\"material-icons\">portrait</i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1331, 1);
#nullable restore
#line 31 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1285, Url.Action("Edit", "User", new { id = user }), 1285, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small\" title=\"Editar\" target=\"_blank\"><i class=\"material-icons\">mode_edit</i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1474, "\"", 1536, 1);
#nullable restore
#line 32 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
WriteAttributeValue("", 1481, Url.Action("Remove", "User", new { id = user.UserId }), 1481, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-floating btn-small btn-remove\" title=\"Remover\"><i class=\"material-icons\">delete</i></a>\r\n                        </td>\r\n                        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Logan\Source\Repos\aspnetcore_mysql\ASPMYSQL\Views\User\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
