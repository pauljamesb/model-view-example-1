#pragma checksum "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38fe4461e9abaa243d1e76d7f40a2790ab99557e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
#line 1 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\_ViewImports.cshtml"
using S1;

#line default
#line hidden
#line 2 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\_ViewImports.cshtml"
using S1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fe4461e9abaa243d1e76d7f40a2790ab99557e", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba86782c7353f7932ad7901bce8eff2a6bedb52", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<S1.Models.MenuModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(75, 40, true);
            WriteLiteral("\r\n<h2>Menu</h2>\r\n\r\n<h3>Pizza</h3>\r\n<p>\r\n");
            EndContext();
#line 11 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
     foreach(Pizza pizza in Model.PizzaMV)
    {
        

#line default
#line hidden
            BeginContext(175, 17, false);
#line 13 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
   Write(pizza.NameOfPizza);

#line default
#line hidden
            EndContext();
            BeginContext(192, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 14 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(207, 43, true);
            WriteLiteral("</p>\r\n\r\n<hr />\r\n\r\n<h3>Ice Cream</h3>\r\n<p>\r\n");
            EndContext();
#line 21 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
     foreach(IceCream iceCream in Model.IceCreamMV)
    {
        

#line default
#line hidden
            BeginContext(319, 16, false);
#line 23 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
   Write(iceCream.Flavour);

#line default
#line hidden
            EndContext();
            BeginContext(335, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 24 "C:\Users\pauljames\source\repos\ModelViewTest\s1\S1\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(350, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<S1.Models.MenuModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591