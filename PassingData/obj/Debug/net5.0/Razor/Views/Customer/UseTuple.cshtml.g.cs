#pragma checksum "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ea2e53e9b6145e9c80566f13da6084d0bac21e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UseTuple), @"mvc.1.0.view", @"/Views/Customer/UseTuple.cshtml")]
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
#line 1 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
using PassingData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ea2e53e9b6145e9c80566f13da6084d0bac21e", @"/Views/Customer/UseTuple.cshtml")]
    #nullable restore
    public class Views_Customer_UseTuple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<Customer> customers,Product product,string date)>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    <h2 style=\"text-align:center\">Product</h2>\r\n    Name: ");
#nullable restore
#line 6 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     Write(Model.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Category: ");
#nullable restore
#line 7 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
         Write(Model.product.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Price: ");
#nullable restore
#line 8 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
      Write(Model.product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" k TL\r\n</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 12 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     foreach (Customer item in Model.customers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 14 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 15 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>\r\n    Date: ");
#nullable restore
#line 19 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     Write(Model.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<Customer> customers,Product product,string date)> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
