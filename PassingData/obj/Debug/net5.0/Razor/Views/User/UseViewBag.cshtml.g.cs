#pragma checksum "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9871ef805f5a96f94eb5407e8e9f3f17b34a090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UseViewBag), @"mvc.1.0.view", @"/Views/User/UseViewBag.cshtml")]
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
#line 1 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml"
using PassingData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9871ef805f5a96f94eb5407e8e9f3f17b34a090", @"/Views/User/UseViewBag.cshtml")]
    #nullable restore
    public class Views_User_UseViewBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Hello ");
#nullable restore
#line 3 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml"
     Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<p>\r\n    Hello ");
#nullable restore
#line 7 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml"
     Write(ViewBag.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml"
     foreach (User item in ViewBag.Users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 13 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml"
       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 14 "C:\Users\Enes Orhan\Desktop\Lessons\Mvc\PassingData\PassingData\Views\User\UseViewBag.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
