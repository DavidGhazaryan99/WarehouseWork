#pragma checksum "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7b6133bdabe77072d4fee1b63bdbdb8bb69b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__detail), @"mvc.1.0.view", @"/Views/Shared/_detail.cshtml")]
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
#line 1 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\_ViewImports.cshtml"
using WarehouseWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\_ViewImports.cshtml"
using WarehouseWork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7b6133bdabe77072d4fee1b63bdbdb8bb69b89", @"/Views/Shared/_detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a06b9ef157cffdc84647d6bd69fb6e4e6598591", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WarehouseWork.Models.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div>\n  <h4>Product</h4>\n    <hr />\n    <div class=\"row\">\n        <dl class=\"col-8\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 14 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 17 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 20 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.manufactured.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 23 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.manufactured.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 26 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.registrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 29 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.registrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 32 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.manufactured.country.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 35 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.manufactured.country.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 38 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 41 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 44 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 47 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 50 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayNameFor(model => model.count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 53 "C:\Users\Zemfira\source\repos\WarehouseWork\WarehouseWork\Views\Shared\_detail.cshtml"
           Write(Html.DisplayFor(model => model.count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n\n    <div class=\"mt-4 text-center\">\n        <a class=\"btn btn-primary\" onclick=\"CloseDetailForm();\" data-icon=\"back\">Back</a>\n    </div>\n    \n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WarehouseWork.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
