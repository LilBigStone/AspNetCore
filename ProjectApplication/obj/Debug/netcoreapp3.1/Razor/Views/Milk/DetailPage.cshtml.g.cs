#pragma checksum "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2acb195fad70b4ab022077853ad69e3bba355de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Milk_DetailPage), @"mvc.1.0.view", @"/Views/Milk/DetailPage.cshtml")]
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
#line 1 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\_ViewImports.cshtml"
using ProjectApplication.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\_ViewImports.cshtml"
using ProjectApplication.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\_ViewImports.cshtml"
using ProjectApplication.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2acb195fad70b4ab022077853ad69e3bba355de4", @"/Views/Milk/DetailPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad746df98366742dad8a4bb9b4515687bfed7fc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Milk_DetailPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectApplication.Models.Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chat-input form-inline mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/messageBuilder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";
    string data;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"container mt-3\">\r\n    <div class=\"navbar mt-5\">\r\n      <p><a href=\"/\">Назад</a></p>\r\n    </div>\r\n  <section>\r\n    <div class=\"container\">\r\n            <h1 itemprop=\"name\">");
#nullable restore
#line 18 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                           Write(ViewBag.Milk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 591, "\"", 609, 1);
#nullable restore
#line 21 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
WriteAttributeValue("", 597, ViewBag.img, 597, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 610, "\"", 616, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"product-short-description\">\r\n                        Массовая доля жира:<b><p style=\"font-size:22px;\">");
#nullable restore
#line 25 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                                    Write(ViewBag.fatMass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n                        Масса:<b><p style=\"font-size:22px;\">");
#nullable restore
#line 26 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                       Write(ViewBag.mass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n                        t хранения:<b><p style=\"font-size:22px;\">");
#nullable restore
#line 27 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                            Write(ViewBag.temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n                        Cрок годности:<b><p style=\"font-size:22px;\"> ");
#nullable restore
#line 28 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                                Write(ViewBag.storageDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n                        Цена:<b><p style=\"font-size:22px;\"> ");
#nullable restore
#line 29 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                       Write(ViewBag.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BYN</p></b>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2acb195fad70b4ab022077853ad69e3bba355de410505", async() => {
                WriteLiteral("Добавить в корзину");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                                                          WriteLiteral(ViewBag.MilkId);

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
            WriteLiteral("\r\n        </div>\r\n      <div class=\"row mb-4\">\r\n      <div class=\"col-11 col-md-8 col-lg-6 offset-lg-3 offset-md-2\">\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2acb195fad70b4ab022077853ad69e3bba355de413165", async() => {
                WriteLiteral("\r\n              <div class=\"form-group col-8 col-md-10 pl-0\">\r\n                  <input type=\"hidden\" name=\"roomId\"");
                BeginWriteAttribute("value", " value=\"", 1779, "\"", 1802, 1);
#nullable restore
#line 39 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
WriteAttributeValue("", 1787, ViewBag.MilkId, 1787, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                  <input placeholder=""Поделиться мнением"" aria-label=""Поделиться мнением"" class=""form-control w-100"" type=""text"" name=""message"" id=""message-input"">
              </div>
              <div class=""form-group col-4 col-md-2 pl-0"">
                  <button class=""btn btn-primary ""  type=""submit"">Поделиться</button>
              </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      </div>
      <div class=""row mt-4"">
          <div class=""col-12 col-lg-8 offset-lg-2 m-auto"">
              
          </div>
      </div>
  </section>
    
    <div class=""row mt-4"">
        <div class=""col-12 col-lg-8 offset-lg-2 m-auto"">
");
#nullable restore
#line 57 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
             if (@Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                 foreach (var message in Model.Reverse())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card mb-4 "">
                        <div class=""g-mb-15"">
                           
                            <div class=""card-body-inline px-4"">
                                <div class=""g-mb-15"">
                                    <h5 class=""h5 g-color-gray-dark-v1 mb-0"">");
#nullable restore
#line 66 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                                                        Write(message.owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n\r\n                                <p>");
#nullable restore
#line 69 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                              Write(message.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    \r\n<style>\r\n   \r\n   .g-height-50 {\r\n           height: 50px;\r\n       }\r\n   \r\n       .g-width-50 {\r\n           width: 50px !important;\r\n       }\r\n    ");
            WriteLiteral("@media (min-width: 0) {\r\n        .g-mr-15 {\r\n            margin-right: 1.07143rem !important;\r\n        }\r\n    }\r\n    ");
            WriteLiteral(@"@media (min-width: 0){
        .g-mt-3 {
            margin-top: 0.21429rem !important;
        }
    }
    .g-bg-secondary {
            background-color: #fafafa !important;
        }
    
        .u-shadow-v18 {
            box-shadow: 0 5px 10px -6px rgba(0, 0, 0, 0.15);
        }
    
        .g-color-gray-dark-v4 {
            color: #777 !important;
        }
    
        .g-font-size-12 {
            font-size: 0.85714rem !important;
        }
    
        .media-comment {
            margin-top:20px
        }
    
    ");
            WriteLiteral("@media (min-width: 0){\r\n        .g-pa-30 {\r\n            padding: 2.14286rem !important;\r\n        }\r\n    }\r\n\r\n</style>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2acb195fad70b4ab022077853ad69e3bba355de419430", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2acb195fad70b4ab022077853ad69e3bba355de420530", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script>
    var connection = new signalR.HubConnectionBuilder()
        .withUrl(""/chat"")
        .build();

    var _connectionId = '';

    connection.on(""RecieveMessage"", function (data) {
        var message = messageBuilder()
            .createMessage()
            .withHeader(data.name)
            .withParagraph(data.text)
            .build();

        document.querySelector('.col-12').append(message);
    })

    connection.start()
        .then(function () {
            connection.invoke('joinRoom', '");
#nullable restore
#line 147 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                      Write(ViewBag.MilkId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        })\r\n        .catch(function (err) {\r\n            console.log(err)\r\n        })\r\n\r\n    window.addEventListener(\'onunload\', function () {\r\n        connection.invoke(\'leaveRoom\', \'");
#nullable restore
#line 154 "C:\Users\maksi\source\repos\ProjectApplication\ProjectApplication\Views\Milk\DetailPage.cshtml"
                                   Write(ViewBag.MilkId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
    })

    var sendMessage = function (event) {
        event.preventDefault();

        var data = new FormData(event.target);
        document.getElementById('message-input').value = '';
        axios.post('/Home/SendMessage', data)
            .then(res => {
                console.log(""Message Sent!"")
            })
            .catch(err => {
                console.log(""Failed to send message!"")
            })
    }

</script>
");
            }
            );
            WriteLiteral(@"  </main>

<style>
        .card {
    cursor: pointer;
  display:-webkit-box;
  display:-ms-flexbox;
  display:flex;
  -webkit-box-orient:vertical;
  -webkit-box-direction:normal;
  -ms-flex-direction:column;
  flex-direction:column;
  position:relative;
  -webkit-transition:all 0.4s cubic-bezier(0.645, 0.045, 0.355, 1);
  -o-transition:all 0.4s cubic-bezier(0.645, 0.045, 0.355, 1);
  transition:all 0.4s cubic-bezier(0.645, 0.045, 0.355, 1);
  border-radius:16px;
  overflow:hidden;
  -webkit-box-shadow:  15px 15px 27px #e1e1e3, -15px -15px 27px #ffffff;
  box-shadow:  15px 15px 27px #e1e1e3, -15px -15px 27px #ffffff;
}

.card:hover {
  box-shadow: 5px 5px 30px 15px rgba(0,0,0,0.25);
    border-radius: 15px;
}
    </style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserModel> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectApplication.Models.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
