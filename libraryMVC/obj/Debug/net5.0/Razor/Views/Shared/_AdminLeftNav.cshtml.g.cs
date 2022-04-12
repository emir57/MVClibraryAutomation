#pragma checksum "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f8efc4955c1992f925b8a57bb694a02207a2e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLeftNav), @"mvc.1.0.view", @"/Views/Shared/_AdminLeftNav.cshtml")]
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
#line 1 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\_ViewImports.cshtml"
using site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\_ViewImports.cshtml"
using site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
using libraryMVC.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f8efc4955c1992f925b8a57bb694a02207a2e5", @"/Views/Shared/_AdminLeftNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLeftNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminKitaplar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminEmanetler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
  
    string link = Context.Request.Path.ToString().Split("/")[2];
    string adminKitaplarClass = link.StartsWith("AdminKitaplar") ? "active":"";
    string adminEmanetlerClass = link.StartsWith("AdminEmanetler") ? "active":"";
    string adminUyelerClass = link.StartsWith("AdminUyeler") ? "active":"";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <style>\r\n        #leftNav{\r\n            width: 100%;\r\n            min-height: 100% !important;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"<div id=""leftNav"" class=""d-flex flex-column flex-shrink-0 p-3 text-white bg-dark"">
    <a href=""/"" class=""d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none"">
        <svg class=""bi me-2"" width=""40"" height=""32"">
            <use xlink:href=""#bootstrap"" />
        </svg>
        <span class=""fs-4"">");
#nullable restore
#line 21 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
                      Write(link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n    <hr>\r\n    <ul class=\"nav nav-pills flex-column mb-auto\">\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f8efc4955c1992f925b8a57bb694a02207a2e55724", async() => {
                WriteLiteral("\r\n                <i class=\"fa-solid fa-book\"></i>\r\n                Kitaplar\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1009, "nav-link", 1009, 8, true);
#nullable restore
#line 26 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
AddHtmlAttributeValue(" ", 1017, adminKitaplarClass, 1018, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1037, "aria-current=", 1038, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("page\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f8efc4955c1992f925b8a57bb694a02207a2e58162", async() => {
                WriteLiteral("\r\n                <i class=\"fa-solid fa-book-open-reader\"></i>\r\n                Emanetler\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1256, "nav-link", 1256, 8, true);
            AddHtmlAttributeValue(" ", 1264, "text-white", 1265, 11, true);
#nullable restore
#line 32 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
AddHtmlAttributeValue(" ", 1275, adminEmanetlerClass, 1276, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 1459, "\"", 1504, 3);
            WriteAttributeValue("", 1467, "nav-link", 1467, 8, true);
            WriteAttributeValue(" ", 1475, "text-white", 1476, 11, true);
#nullable restore
#line 38 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
WriteAttributeValue(" ", 1486, adminUyelerClass, 1487, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"fa-solid fa-users\"></i>\r\n                Üyeler\r\n            </a>\r\n        </li>\r\n    </ul>\r\n    <hr>\r\n");
#nullable restore
#line 45 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
      
        Uye uye = (ViewBag.MainViewModel.Uyeler as List<Uye>).FirstOrDefault(x => x.Email == User.Identity.Name);
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""dropdown"">
        <a href=""#"" class=""d-flex align-items-center text-white text-decoration-none dropdown-toggle"" id=""dropdownUser1""
            data-bs-toggle=""dropdown"" aria-expanded=""false"">
            <img src=""https://github.com/mdo.png""");
            BeginWriteAttribute("alt", " alt=\"", 2028, "\"", 2034, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"32\" height=\"32\" class=\"rounded-circle me-2\">\r\n            <strong>");
#nullable restore
#line 52 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
               Write(uye.UyeAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
        </a>
        <ul class=""dropdown-menu dropdown-menu-dark text-small shadow"" aria-labelledby=""dropdownUser1"">
            <li><a class=""dropdown-item"" href=""#"">New project...</a></li>
            <li><a class=""dropdown-item"" href=""#"">Settings</a></li>
            <li><a class=""dropdown-item"" href=""#"">Profile</a></li>
            <li>
                <hr class=""dropdown-divider"">
            </li>
            <li><a class=""dropdown-item"" href=""#"">Sign out</a></li>
        </ul>
    </div>
</div>");
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
