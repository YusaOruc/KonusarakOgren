#pragma checksum "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a348c5e75a902b54d66be5384fc4f9a5babb009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Quiz), @"mvc.1.0.view", @"/Views/Admin/Quiz.cshtml")]
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
#line 1 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\_ViewImports.cshtml"
using CreateQuiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\_ViewImports.cshtml"
using CreateQuiz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
using EntityLayer.Concreate.EntityFrameworkSqlite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a348c5e75a902b54d66be5384fc4f9a5babb009", @"/Views/Admin/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321d9065386011b64b79d7131a1f612b092c8790", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Quiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
  
    ViewData["Title"] = "Quiz";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    
    <br />
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Başlık</th>
                <th scope=""col"">Tarih</th>
                <th scope=""col"">Sil</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
                               Write(item.ExamID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
                   Write(item.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
                   Write(item.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th scope=\"col\"><a style=\"width:100px;color:white;\"");
            BeginWriteAttribute("href", "href=\"", 821, "\"", 857, 2);
            WriteAttributeValue("", 827, "/Admin/DeleteExam/", 827, 18, true);
#nullable restore
#line 29 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
WriteAttributeValue("", 845, item.ExamID, 845, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></th>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Yusa\source\repos\CreateQuiz\CreateQuiz\Views\Admin\Quiz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591