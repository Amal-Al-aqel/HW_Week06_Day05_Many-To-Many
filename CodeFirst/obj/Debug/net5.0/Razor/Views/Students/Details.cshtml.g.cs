#pragma checksum "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8be21b8d5f2de25bda60f4b4399e371ea65ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
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
#line 1 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8be21b8d5f2de25bda60f4b4399e371ea65ef6", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\Students\Details.cshtml"
  
    var Student = (StudentModel)ViewData["details"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>ID: ");
#nullable restore
#line 8 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\Students\Details.cshtml"
  Write(Student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>First Name: ");
#nullable restore
#line 9 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\Students\Details.cshtml"
          Write(Student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Last Name: ");
#nullable restore
#line 10 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\Students\Details.cshtml"
         Write(Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email: ");
#nullable restore
#line 11 "C:\Users\96655\source\repos\CodeFirst\CodeFirst\Views\Students\Details.cshtml"
     Write(Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
