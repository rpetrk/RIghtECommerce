#pragma checksum "C:\Training\DIPPP_source-code\RightECommerce\src\Commerce.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f8fb1ab3c4bef567d5ece8e5a35f1f1d8cc635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Training\DIPPP_source-code\RightECommerce\src\Commerce.Web\Views\_ViewImports.cshtml"
using Ploeh.Samples.Commerce.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f8fb1ab3c4bef567d5ece8e5a35f1f1d8cc635", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bdf36d204608128450cd9ded22463190d463470", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ploeh.Samples.Commerce.Web.Models.FeaturedProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 34, true);
            WriteLiteral("\n<h2>Featured Products</h2>\n<div>\n");
            EndContext();
#line 5 "C:\Training\DIPPP_source-code\RightECommerce\src\Commerce.Web\Views\Home\Index.cshtml"
     foreach (var product in this.Model.Products)
    {

#line default
#line hidden
            BeginContext(157, 13, true);
            WriteLiteral("        <div>");
            EndContext();
            BeginContext(171, 19, false);
#line (7,15)-(7,34) 6 "C:\Training\DIPPP_source-code\RightECommerce\src\Commerce.Web\Views\Home\Index.cshtml"
Write(product.SummaryText);

#line default
#line hidden
            EndContext();
            BeginContext(190, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 8 "C:\Training\DIPPP_source-code\RightECommerce\src\Commerce.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(203, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ploeh.Samples.Commerce.Web.Models.FeaturedProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591