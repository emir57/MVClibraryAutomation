#pragma checksum "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94173c9d7cff7e4b856b7bb6da0a3729e962ba5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uye_Uyeler), @"mvc.1.0.view", @"/Views/Uye/Uyeler.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94173c9d7cff7e4b856b7bb6da0a3729e962ba5b", @"/Views/Uye/Uyeler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Uye_Uyeler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<libraryMVC.Models.Uye>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUyeler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUyeler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left; margin-bottom:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUyeler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <style>\r\n        #searchSection{\r\n            display: flex;\r\n            justify-content: flex-end;\r\n            align-items: center;\r\n            margin-top: 50px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""jumbotron mt-5"">
    <h2 style=""float:left;"" class=""text-info"">Üye Listesi</h2>
    <div id=""searchSection"">
        <input class=""form-control"" style=""max-width: 100px;"" placeholder=""ID"" id=""id"" type=""number"" />
        <input class=""form-control"" style=""max-width: 200px;"" placeholder=""Ara"" id=""searchString"" type=""text"" />
    </div>
    <table class=""table table-hover mt-3"">
        <thead>
            <th>Üye No</th>
            <th>Üye Adı</th>
            <th>Üye Soyadı</th>
            <th>Üye Telefonu</th>
            <th>Üye E-postası</th>
            <th>Üye Adres</th>
            <th>İşlemler</th>
        </thead>
");
#nullable restore
#line 30 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
               Write(item.UyeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 35 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                     if (@item.UyeAd.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 38 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                   Write(item.UyeAd);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 45 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                     if (@item.UyeSoyad.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 48 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                   Write(item.UyeSoyad);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
               Write(item.UyeTelefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
               Write(item.UyeEposta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 57 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                     if (@item.UyeAdres.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 60 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                   Write(item.UyeAdres);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <!-- Button trigger modal -->\r\n                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#modal");
#nullable restore
#line 69 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                                                                                Write(item.UyeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Sil\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94173c9d7cff7e4b856b7bb6da0a3729e962ba5b11774", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                                                                         WriteLiteral(item.UyeNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <!-- Modal -->\r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2497, "\"", 2520, 2);
            WriteAttributeValue("", 2502, "modal", 2502, 5, true);
#nullable restore
#line 75 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
WriteAttributeValue("", 2507, item.UyeNo, 2507, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""dialog"" tabindex=""-1""
                    aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLabel"">Kayıt Siliniyor</h5>
                                    <button type=""button"" class=""btn-close"" data-dismiss=""modal""
                                    aria-label=""Close"">X</button>
                                </div>
                                <div class=""modal-body"">
                                    <span class=""text-danger"">");
#nullable restore
#line 85 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                                         Write(item.UyeAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 85 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                                                       Write(item.UyeSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 85 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                                                                        Write(item.UyeEposta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    <br>
                                    Bu Kaydı Silmek İstediğinizden Emin misiniz?
                                </div>
                                <div class=""modal-footer"">
                                    <!-- Button trigger modal -->
                                <a class=""btn btn-secondary text text-white"" data-dismiss=""modal""
                                    role=""button"">İptal</a>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94173c9d7cff7e4b856b7bb6da0a3729e962ba5b16751", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"
                                      WriteLiteral(item.UyeNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 100 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Uye\Uyeler.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94173c9d7cff7e4b856b7bb6da0a3729e962ba5b19464", async() => {
                WriteLiteral("Yeni\r\n    Üye Oluştur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<libraryMVC.Models.Uye>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
