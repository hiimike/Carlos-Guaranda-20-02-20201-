#pragma checksum "E:\develop\test-bertoni\Test-BertoniSolutions\Views\Shared\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7641533306eed730f0959208b3be997f8829a490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Comments), @"mvc.1.0.view", @"/Views/Shared/Comments.cshtml")]
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
#line 1 "E:\develop\test-bertoni\Test-BertoniSolutions\Views\_ViewImports.cshtml"
using Test_BertoniSolutions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\develop\test-bertoni\Test-BertoniSolutions\Views\_ViewImports.cshtml"
using Test_BertoniSolutions.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7641533306eed730f0959208b3be997f8829a490", @"/Views/Shared/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b15ef1f84653cfa19d7e687fb0da045d3f01172", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h3>Comentarios</h3>\r\n\r\n");
#nullable restore
#line 11 "E:\develop\test-bertoni\Test-BertoniSolutions\Views\Shared\Comments.cshtml"
         foreach (Comment comment in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\">");
#nullable restore
#line 14 "E:\develop\test-bertoni\Test-BertoniSolutions\Views\Shared\Comments.cshtml"
                                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 14 "E:\develop\test-bertoni\Test-BertoniSolutions\Views\Shared\Comments.cshtml"
                                                        Write(comment.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n");
#nullable restore
#line 16 "E:\develop\test-bertoni\Test-BertoniSolutions\Views\Shared\Comments.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591