#pragma checksum "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b803f99e40477791e732e68fae3a4626f101ca4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b803f99e40477791e732e68fae3a4626f101ca4", @"/Views/Shared/_AdminLeftNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLeftNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
            WriteLiteral("</span>\r\n    </a>\r\n    <hr>\r\n    <ul class=\"nav nav-pills flex-column mb-auto\">\r\n        <li class=\"nav-item\">\r\n            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 960, "\"", 1010, 3);
            WriteAttributeValue("", 968, "nav-link", 968, 8, true);
#nullable restore
#line 26 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
WriteAttributeValue(" ", 976, adminKitaplarClass, 977, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 996, "aria-current=", 997, 14, true);
            EndWriteAttribute();
            WriteLiteral("page\">\r\n                \r\n                Kitaplar\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 1133, "\"", 1181, 3);
            WriteAttributeValue("", 1141, "nav-link", 1141, 8, true);
            WriteAttributeValue(" ", 1149, "text-white", 1150, 11, true);
#nullable restore
#line 32 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
WriteAttributeValue(" ", 1160, adminEmanetlerClass, 1161, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                \r\n                Emanetler\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 1300, "\"", 1345, 3);
            WriteAttributeValue("", 1308, "nav-link", 1308, 8, true);
            WriteAttributeValue(" ", 1316, "text-white", 1317, 11, true);
#nullable restore
#line 38 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Shared\_AdminLeftNav.cshtml"
WriteAttributeValue(" ", 1327, adminUyelerClass, 1328, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                \r\n                Üyeler\r\n            </a>\r\n        </li>\r\n    </ul>\r\n    <hr>\r\n");
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
            BeginWriteAttribute("alt", " alt=\"", 1836, "\"", 1842, 0);
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
