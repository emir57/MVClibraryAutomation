#pragma checksum "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6efc8416e0c70a2e5db0a9b9d4df488cbce39df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_Kitaplar), @"mvc.1.0.view", @"/Views/Kitap/Kitaplar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6efc8416e0c70a2e5db0a9b9d4df488cbce39df4", @"/Views/Kitap/Kitaplar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kitap_Kitaplar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<libraryMVC.Models.Kitap>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditKitaplar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteKitaplar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left; margin-bottom:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateKitaplar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""jumbotron mt-5"">
    <h2 style=""float:left;"" class=""text-info"">Kitap Listesi</h2>
    <div class=""searchSection"">
        <input class=""form-control"" style=""max-width: 100px;"" placeholder=""ID"" id=""id"" type=""number"" />
        <input class=""form-control"" style=""max-width: 200px;"" placeholder=""Ara"" id=""searchString"" type=""text"" />
    </div>
    <table class=""table table-hover mt-3"">
        <thead>
            <th>Kitap No</th>
            <th>Kitap Adı</th>
            <th>Kitap Yazarı</th>
            <th>Kitap Baskı Yılı</th>
            <th>Kitap Sayfa Sayısı</th>
            <th>Kitap Dili</th>
            <th>Kitap Yayın Evi</th>
            <th>Kitap Açıklama</th>
            <th width=""155px"">İşlemler</th>
        </thead>
");
#nullable restore
#line 21 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
               Write(item.KitapNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 26 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                     if (@item.KitapAd.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 29 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                   Write(item.KitapAd);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 36 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                     if (@item.KitapYazari.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 39 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                   Write(item.KitapYazari);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
               Write(item.KitapBaskiYil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
               Write(item.KitapSayfaSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 48 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                     if (@item.KitapDil.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 51 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                   Write(item.KitapDil);

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 58 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                     if (@item.KitapYayinEvi.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 61 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                   Write(item.KitapYayinEvi);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                           
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 68 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                     if (@item.KitapAciklama.Contains("^") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>-</p>\r\n");
#nullable restore
#line 71 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                   Write(item.KitapAciklama);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                           
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <!-- Button trigger modal -->\r\n                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#modal");
#nullable restore
#line 79 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                                                                                Write(item.KitapNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Sil\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6efc8416e0c70a2e5db0a9b9d4df488cbce39df413857", async() => {
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
#line 82 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                                                                           WriteLiteral(item.KitapNo);

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
            BeginWriteAttribute("id", " id=\"", 3039, "\"", 3064, 2);
            WriteAttributeValue("", 3044, "modal", 3044, 5, true);
#nullable restore
#line 85 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
WriteAttributeValue("", 3049, item.KitapNo, 3049, 15, false);

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
#line 95 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                                         Write(item.KitapNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 95 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                                                         Write(item.KitapAd);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    <br>
                                    Bu Kaydı Silmek İstediğinizden Emin misiniz?
                                </div>
                                <div class=""modal-footer"">
                                    <a class=""btn btn-secondary text text-white"" data-dismiss=""modal"">İptal</a>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6efc8416e0c70a2e5db0a9b9d4df488cbce39df418437", async() => {
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
#line 102 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"
                                      WriteLiteral(item.KitapNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 110 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Kitap\Kitaplar.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6efc8416e0c70a2e5db0a9b9d4df488cbce39df421108", async() => {
                WriteLiteral("Yeni Kitap Oluştur");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<libraryMVC.Models.Kitap>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
