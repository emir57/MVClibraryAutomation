#pragma checksum "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f52f888bcc2c153589a2195b8dd06b7efd25b9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f52f888bcc2c153589a2195b8dd06b7efd25b9", @"/Views/Emanet/Emanetler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Emanet_Emanetler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<libraryMVC.Dtos.EmanetDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEmanetler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left; margin-bottom:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f52f888bcc2c153589a2195b8dd06b7efd25b95445", async() => {
                WriteLiteral("Yeni\r\n    Emanet Oluştur");
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
            WriteLiteral(@"
<div class=""jumbotron mt-2"">
    <h2 style=""float:left;"" class=""text-info display-4"">Emanet Listesi</h2>

    <div class=""searchSection"">
        <input class=""form-control"" style=""max-width: 100px;"" placeholder=""ID"" id=""id"" type=""number"" />&nbsp;
        <input class=""form-control"" style=""max-width: 200px;"" placeholder=""Ara"" id=""searchString"" type=""text"" />
    </div>
    <div class=""searchSection"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""type"" id=""emanetverme"">
            <label class=""form-check-label"" for=""emanetverme"">
                Emanet Verme
            </label>
        </div>
        &nbsp;
        <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""type"" id=""emanetgerialma"">
            <label class=""form-check-label"" for=""emanetgerialma"">
                Emanet Geri Alma
            </label>
        </div>
        &nbsp;
        <div class=""form-check"">
            <input class=""");
            WriteLiteral(@"form-check-input"" type=""radio"" name=""type"" id=""emanetislem"">
            <label class=""form-check-label"" for=""emanetislem"">
                Emanet İşlem
            </label>
        </div>
    </div>
    <div class=""searchSection"">
        <span class=""text-primary"">Başlangıç:</span>&nbsp;<input type=""date"" style=""max-width: 200px;""
            class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 1641, "\"", 1648, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"startDate\">&nbsp;\r\n        <span class=\"text-primary\">Bitiş:</span>&nbsp;<input type=\"date\" style=\"max-width: 200px;\" class=\"form-control\"");
            BeginWriteAttribute("name", "\r\n            name=\"", 1792, "\"", 1812, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""finishDate"">&nbsp;
        <button id=""searchByDateResetButton"" class=""btn btn-info"">Sıfırla</button>&nbsp;
        <button id=""searchByDateButton"" class=""btn btn-primary"">Ara</button>
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
        <tbody id=""emanetler""></tbody>
    </table>

</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f52f888bcc2c153589a2195b8dd06b7efd25b99475", async() => {
                WriteLiteral("Yeni Emanet Oluştur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
    getAll();

    //GetById
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

    $(document).ready(function () {
        $(""#searchByDateButton"").click(function () {
            let emanetler = $(""#emanetler"");
            let startDate = $(""#st");
                WriteLiteral(@"artDate"").val();
            let finishDate = $(""#finishDate"").val();
            if ($(""#emanetverme:checked"").length === 1) {
                console.log(""emanetverme"")
            }
            else if ($(""#emanetgerialma:checked"").length === 1) {
                $.ajax({
                    url: ""/Emanet/EmanetSearchByEmanetGeriAlma"",
                    method: ""POST"",
                    data: { startDate, finishDate },
                    success: function (datas) {
                        emanetler.empty().append(getDatas(datas))
                    }
                })
            }
            else if ($(""#emanetislem:checked"").length === 1) {
                $.ajax({
                    url: ""/Emanet/EmanetSearchByEmanetIslem"",
                    method: ""POST"",
                    data: { startDate, finishDate },
                    success: function (datas) {
                        emanetler.empty().append(getDatas(datas))
                    }
                })
       ");
                WriteLiteral(@"     }
        })
        $(""#searchByDateResetButton"").click(function () {
            getAll();
        })
    })

    //GetBySearchString
    $(document).ready(function () {
        let emanetler = $(""#emanetler"");
        $(""#searchString"").keyup(function () {
            if ($(this).val()) {
                $.ajax({
                    url: ""/Emanet/EmanetlerSearchBySearchString?searchString="" + $(this).val(),
                    method: ""GET"",
                    success: function (datas) {
                        let html = getDatas(datas);
                        emanetler.empty().append(html);
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
            html += generatorHtml(data);
        })
        return html;
    }
    function getData(data) {
        return generatorHtml(data);
    }

    function getAll");
                WriteLiteral(@"() {
        let emanetler = $(""#emanetler"");
        $.ajax({
            url: ""/Emanet/EmanetlerSearchBySearchString?searchString="" + $(""#searchString"").val(),
            method: ""GET"",
            success: function (datas) {
                let html = getDatas(datas);
                emanetler.empty().append(html);
            },
            error: function (error) {
                if (error.responseText === ""Not Found"") {
                    showErrorAlert(""Emanet bulunamadı"");
                }
            }
        })
    }

    function generatorHtml(data) {
        let emanetClass = """";
        if (data.emanetTeslimEdildi === ""Sürüyor"") { emanetClass = ""text-primary""; }
        else if (data.emanetTeslimEdildi === ""Teslim Edildi"") { emanetClass = ""text-success""; }
        else if (data.emanetTeslimEdildi === ""Teslim Edilmedi"") { emanetClass = ""text-danger""; }
        return `
                <tr id=""${data.emanetNo}"">
                    <td>${data.emanetNo}</td>
           ");
                WriteLiteral(@"         <td>
                        <a href=""/Uye/Uyeler#${data.uye.uyeNo}"">${data.uye.uyeAd} ${data.uye.uyeSoyad}</a>
                    </td>
                    <td>
                        <a href=""/Kitap/Kitaplar#${data.kitap.kitapNo}"">${data.kitap.kitapAd}</a>
                    </td>
                    <td>${data.emanetVermeTarih}</td>
                    <td>${data.emanetGeriAlmaTarih}</td>
                    <td>${data.emanetIslemTarih}</td>
                    <td>${data.emanetNot}</td>
                    <td>
                        <p class=""${emanetClass}"">${data.emanetTeslimEdildi}</p>
                    </td>
                    <td>
                        <!-- Button trigger modal -->
                        <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#modal${data.emanetNo}"" title=""Emaneti Sil"">
                            <i class=""fa-solid fa-trash""></i>
                        </button>
                        <a class=""btn btn-pr");
                WriteLiteral(@"imary text text-white"" href=""/Emanet/EditEmanetler/${data.emanetNo}""
                        role=""button"" title=""Emaneti Düzenle"">
                            <i class=""fa-solid fa-pen-to-square""></i>
                        </a>
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
                                    <div class=""modal-bod");
                WriteLiteral(@"y"">
                                        <span class=""text-danger"">${data.emanetNo} - ${data.emanetTeslimEdildi}</span>
                                        <br>
                                        Bu Kaydı Silmek İstediğinizden Emin misiniz?
                                    </div>
                                    <div class=""modal-footer"">
                                        <a class=""btn  btn-secondary text text-white"" data-dismiss=""modal""
                                        role=""button"">İptal</a>
                                        <a class=""btn btn-danger text text-white"" href=""/Emanet/DeleteEmanetler/${data.emanetNo}"" role=""button"">Sil</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
            `;
    }
    function showSuccessAlert(message) {
        const Toast = Swal.mixin({
            toast: true,
    ");
                WriteLiteral(@"        position: 'bottom-end',
            showConfirmButton: false,
            timer: 3000,
            timerProgressBar: true,
            didOpen: (toast) => {
                toast.addEventListener('mouseenter', Swal.stopTimer)
                toast.addEventListener('mouseleave', Swal.resumeTimer)
            }
        })

        Toast.fire({
            icon: 'success',
            title: message
        })
    }
</script>
");
#nullable restore
#line 249 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
 if (ViewBag.Message != null && ViewBag.Message.EndsWith("başarıyla güncellendi"))
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<script>\r\n    showSuccessAlert(\"");
#nullable restore
#line 252 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n</script>\r\n");
#nullable restore
#line 254 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
}
else if(ViewBag.Message != null && ViewBag.Message.EndsWith("başarıyla eklendi"))
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<script>\r\n    showSuccessAlert(\"");
#nullable restore
#line 258 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n</script>\r\n");
#nullable restore
#line 260 "C:\Users\lolem\Desktop\MVClibraryAutomation\libraryMVC\Views\Emanet\Emanetler.cshtml"
}

#line default
#line hidden
#nullable disable
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
