#pragma checksum "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8524b18303520f262e4eac6a1a6e3243e94e33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\_ViewImports.cshtml"
using CreateQuiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\_ViewImports.cshtml"
using CreateQuiz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml"
using EntityLayer.Concreate.EntityFrameworkSqlite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8524b18303520f262e4eac6a1a6e3243e94e33", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321d9065386011b64b79d7131a1f612b092c8790", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n\r\n            <div class=\"card\" style=\"width: 20rem;\">\r\n\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml"
                                      Write(item.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                    <a style=\"width:100%\"");
            BeginWriteAttribute("href", " href=\"", 473, "\"", 503, 2);
            WriteAttributeValue("", 480, "/Home/Exam/", 480, 11, true);
#nullable restore
#line 20 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml"
WriteAttributeValue("", 491, item.ExamID, 491, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Sınava Başla</a>\r\n                </div>\r\n            </div>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Yusa\Desktop\KonusarakOgren\CreateQuiz\CreateQuiz\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
