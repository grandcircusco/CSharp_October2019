#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceca6148bb321f8fd48616ef498344831f849081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyDb_DepartmentIndex), @"mvc.1.0.view", @"/Views/CompanyDb/DepartmentIndex.cshtml")]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\_ViewImports.cshtml"
using Day_28___EFCoreCodeFirst1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\_ViewImports.cshtml"
using Day_28___EFCoreCodeFirst1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
using Day_28___EFCoreCodeFirst1.Context;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceca6148bb321f8fd48616ef498344831f849081", @"/Views/CompanyDb/DepartmentIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b402706cd53010779438ce2b10f56c40e381fb47", @"/Views/_ViewImports.cshtml")]
    public class Views_CompanyDb_DepartmentIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
  
    ViewData["Title"] = "DepartmentIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Department Index</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Location</th>\r\n        <th>Type</th>\r\n        <th>Budget</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
     foreach (Department department in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
           Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
           Write(department.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
           Write(department.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
           Write(department.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 557, "\"", 621, 2);
            WriteAttributeValue("", 564, "../CompanyDb/UpdateDepartment?id=", 564, 33, true);
#nullable restore
#line 24 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
WriteAttributeValue("", 597, department.DepartmentId, 597, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Update Database</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 764, 2);
            WriteAttributeValue("", 707, "../CompanyDb/DeleteDepartment?id=", 707, 33, true);
#nullable restore
#line 27 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
WriteAttributeValue("", 740, department.DepartmentId, 740, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Delete Department</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 845, "\"", 918, 2);
            WriteAttributeValue("", 852, "../CompanyDb/ListEmployeesByDepartment?id=", 852, 42, true);
#nullable restore
#line 30 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
WriteAttributeValue("", 894, department.DepartmentId, 894, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> List Employees In Department</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\Student Docs\CSharp_October2019\Day 28 - EFCoreCodeFirst1\Day 28 - EFCoreCodeFirst1\Views\CompanyDb\DepartmentIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"../CompanyDb/AddDepartment\">Add New Department!</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591