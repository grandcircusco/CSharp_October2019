#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 26 - TempData\Day 26 - TempData\Views\TempData\Second.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d84deb9a79391e5d5055ec0ef548905f5a4386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TempData_Second), @"mvc.1.0.view", @"/Views/TempData/Second.cshtml")]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 26 - TempData\Day 26 - TempData\Views\_ViewImports.cshtml"
using Day_26___TempData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 26 - TempData\Day 26 - TempData\Views\_ViewImports.cshtml"
using Day_26___TempData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d84deb9a79391e5d5055ec0ef548905f5a4386", @"/Views/TempData/Second.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09eaf2379ff21fb4d136ba41e88e15c0a27ebbc9", @"/Views/_ViewImports.cshtml")]
    public class Views_TempData_Second : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 26 - TempData\Day 26 - TempData\Views\TempData\Second.cshtml"
  
    ViewData["Title"] = "Second";
    var haroldVariable = TempData["HaroldsKey"]?.ToString();
    TempData.Keep();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Second</h1>\r\n\r\nHarold\'s Name: ");
#nullable restore
#line 10 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 26 - TempData\Day 26 - TempData\Views\TempData\Second.cshtml"
          Write(haroldVariable);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
