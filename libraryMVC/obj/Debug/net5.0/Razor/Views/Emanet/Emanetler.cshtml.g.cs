#pragma checksum "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7441af281d332630e5d9c1bf424a63a02f521d58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emanet_Emanetler), @"mvc.1.0.view", @"/Views/Emanet/Emanetler.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#line 2 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7441af281d332630e5d9c1bf424a63a02f521d58", @"/Views/Emanet/Emanetler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Emanet_Emanetler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<libraryMVC.Dtos.EmanetDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left; margin-bottom:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEmanetler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <h2 style=""float:left;"" class=""text-info"">Emanet Listesi</h2>
    <div class=""searchSection"">
        <input class=""form-control"" style=""max-width: 100px;"" placeholder=""ID"" id=""id"" type=""number"" />&nbsp;
        <input class=""form-control"" style=""max-width: 200px;"" placeholder=""Ara"" id=""searchString"" type=""text"" />
    </div>
    <table class=""table table-hover mt-3 table-striped"">
        <thead>
            <th>Emanet No</th>
            <th>Üye Ad Soyad</th>
            <th>Kitap Ad</th>
            <th>Emanet Verme Tarihi</th>
            <th>Emanet Geri Alma Tarihi</th>
            <th>Emanet İşlem Tarihi </th>
            <th>Emanet Not</th>
            <th>Emanet Teslim Edildi</th>
            <th width=""155px"">İşlemler</th>
        </thead>
        <tbody id=""emanetler"">

        </tbody>
");
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7441af281d332630e5d9c1bf424a63a02f521d585694", async() => {
                WriteLiteral("Yeni Emanet Oluştur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    $(document).ready(function () {
        getAll();
    })
    $(document).ready(function () {
        let emanetler = $(""#emanetler"");
        $(""#id"").keyup(function () {
            if ($(this).val()) {
                $.ajax({
                    url: ""/Emanet/EmanetlerSearchById?id="" + $(this).val(),
                    method: ""GET"",
                    success: function (data) {
                        let html = getData(data);
                        emanetler.empty().append(html);
                        console.log(data)
                    },
                    error: function (error) {
                        if (error.responseText === ""Not Found"") {
                            showErrorAlert(""Böyle bir emanet yok"");
                        }
                    }
                })
            } else {
                getAll();
            }   
        })
    })

    function getDatas(datas) {
        let html = """";
        datas.forEach(data => {
    ");
                WriteLiteral(@"        html += `
                <tr id=""${data.emanetNo}"">
                    <td>${data.emanetNo}</td>
                    <td>
                        <a href=""/Uye/Uyeler#${data.uye.uyeNo}"">${data.uye.uyeAd} ${data.uye.uyeSoyad}</a>
                    </td>
                    <td>
                        <a href=""/Kitap/Kitaplar#${data.kitap.kitapNo}"">${data.kitap.kitapAd}</a>
                    </td>
                    <td>${data.emanetVermeTarih}</td>
                    <td>${data.emanetGeriAlmaTarih}</td>
                    <td>${data.emanetIslemTarih}</td>
                    <td>${data.emanetNot}</td>
                    <td>${data.emanetTeslimEdildi}</td>
                    <td>
                        <!-- Button trigger modal -->
                        <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#modal${data.emanetNo}"">
                            Sil
                        </button>
                        <a class=""btn btn-primary t");
                WriteLiteral(@"ext text-white"" href=""/Emanet/EditEmanetler/${data.emanetNo}""
                        role=""button"">Düzenle</a>
                        <!-- Modal -->
                        <div class=""modal fade"" id=""modal${data.emanetNo}"" role=""dialog"" tabindex=""-1""
                        aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"" id=""exampleModalLabel"">Kayıt Siliniyor</h5>
                                        <button type=""button"" class=""btn-close"" data-dismiss=""modal""
                                        aria-label=""Close"">X</button>
                                    </div>
                                    <div class=""modal-body"">
                                        <span class=""text-danger"">${data.emanetNo} - ${data.emanetTeslimEdildi}</spa");
                WriteLiteral(@"n>
                                        <br>
                                        Bu Kaydı Silmek İstediğinizden Emin misiniz?
                                    </div>
                                    <div class=""modal-footer"">
                                        <a class=""btn  btn-secondary text text-white"" data-dismiss=""modal""
                                        role=""button"">İptal</a>
                                        <a class=""btn btn-danger text text-white"" asp-action=""DeleteEmanetler""
                                        asp-route-id=""${data.emanetNo}"" role=""button"">Sil</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
            `;
        })
        return html;
    }
    function getData(data) {
        let html = `
                <tr id=""${data.emanetNo}"">
                    <td>${data.emanetNo}</td>");
                WriteLiteral(@"
                    <td>
                        <a href=""/Uye/Uyeler#${data.uye.uyeNo}"">${data.uye.uyeAd} ${data.uye.uyeSoyad}</a>
                    </td>
                    <td>
                        <a href=""/Kitap/Kitaplar#${data.kitap.kitapNo}"">${data.kitap.kitapAd}</a>
                    </td>
                    <td>${data.emanetVermeTarih}</td>
                    <td>${data.emanetGeriAlmaTarih}</td>
                    <td>${data.emanetIslemTarih}</td>
                    <td>${data.emanetNot}</td>
                    <td>${data.emanetTeslimEdildi}</td>
                    <td>
                        <!-- Button trigger modal -->
                        <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#modal${data.emanetNo}"">
                            Sil
                        </button>
                        <a class=""btn btn-primary text text-white"" href=""/Emanet/EditEmanetler/${data.emanetNo}""
                        role=""button"">Düzenle");
                WriteLiteral(@"</a>
                        <!-- Modal -->
                        <div class=""modal fade"" id=""modal${data.emanetNo}"" role=""dialog"" tabindex=""-1""
                        aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                            <div class=""modal-dialog"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"" id=""exampleModalLabel"">Kayıt Siliniyor</h5>
                                        <button type=""button"" class=""btn-close"" data-dismiss=""modal""
                                        aria-label=""Close"">X</button>
                                    </div>
                                    <div class=""modal-body"">
                                        <span class=""text-danger"">${data.emanetNo} - ${data.emanetTeslimEdildi}</span>
                                        <br>
                                        Bu Kaydı Silmek İs");
                WriteLiteral(@"tediğinizden Emin misiniz?
                                    </div>
                                    <div class=""modal-footer"">
                                        <a class=""btn  btn-secondary text text-white"" data-dismiss=""modal""
                                        role=""button"">İptal</a>
                                        <a class=""btn btn-danger text text-white"" asp-action=""DeleteEmanetler""
                                        asp-route-id=""${data.emanetNo}"" role=""button"">Sil</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
            `;
        return html;
    }

    function getAll() {
        let emanetler = $(""#emanetler"");
        $.ajax({
            url: ""/Emanet/EmanetlerSearchBySearchString?searchString="" + $(""#searchString"").val(),
            method: ""GET"",
            success: function (datas) {
     ");
                WriteLiteral(@"           let html = getDatas(datas);
                emanetler.empty().append(html);
            },
            error: function (error) {
                if (error.responseText === ""Not Found"") {
                    showErrorAlert(""Böyle bir emanet yok"");
                }
            }
        })
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<libraryMVC.Dtos.EmanetDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
