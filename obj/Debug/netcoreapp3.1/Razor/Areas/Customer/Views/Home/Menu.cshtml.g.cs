#pragma checksum "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af858331f531d092e778a572cb7233b2cceb0cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Menu), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Menu.cshtml")]
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
#line 1 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\_ViewImports.cshtml"
using RestaurantManagementsystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\_ViewImports.cshtml"
using RestaurantManagementsystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af858331f531d092e778a572cb7233b2cceb0cd", @"/Areas/Customer/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935a581d67408894ef04aeeba9e1223d5ed5bcf4", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantManagementsystem.Models.ViewModels.MenuViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Menu";
    Layout = "~/Views/Shared/_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"backgroundWhite container\">\n\n    <ul id=\"menu-filters\" class=\"menu-filter-list list-inline text-center\">\n        <li class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\".menu-restaurant\">Show All</li>\n\n");
#nullable restore
#line 12 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 14 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
                                                                    Write(item.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 14 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
                                                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 15 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n\n");
#nullable restore
#line 18 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
     foreach (var category in Model.Category)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" id=\"menu-wrapper\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2af858331f531d092e778a572cb7233b2cceb0cd5531", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u=>u.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 23 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<br />\n\n");
#nullable restore
#line 28 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
 if (Model.Coupon.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border\">\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\n");
#nullable restore
#line 32 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
             for (int i = 0; i < Model.Coupon.Count(); i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\n");
#nullable restore
#line 37 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1417, "\"", 1430, 1);
#nullable restore
#line 41 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
WriteAttributeValue("", 1423, imgsrc, 1423, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\n                    </div>\n");
#nullable restore
#line 43 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\n");
#nullable restore
#line 47 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1876, "\"", 1889, 1);
#nullable restore
#line 51 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
WriteAttributeValue("", 1882, imgsrc, 1882, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\n                    </div>\n");
#nullable restore
#line 53 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 58 "E:\BIRLASOFT\DOTNETTRAINING\Restro-master\Areas\Customer\Views\Home\Menu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>

    <script>

        var posts = $('.post');

        (function ($) {

            $(""#menu-filters li"").click(function () {
                $(""#menu-filters li"").removeClass('active btn btn-secondary');
                $(this).addClass('active btn btn-secondary');

                var selectedFilter = $(this).data(""filter"");

                $("".menu-restaurant"").fadeOut();

                setTimeout(function () {
                    $(selectedFilter).slideDown();
                }, 100);
            });



        })(jQuery);

    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantManagementsystem.Models.ViewModels.MenuViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
