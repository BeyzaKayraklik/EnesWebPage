#pragma checksum "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c26cccf6c457d88403a05b1f439d0a7cd697588c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\_ViewImports.cshtml"
using Unfold;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\_ViewImports.cshtml"
using Unfold.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26cccf6c457d88403a05b1f439d0a7cd697588c", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b56e16536c48de442320b80d999576c7b7dbf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".site-nav-target"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
  
    var a = (DataBaseEntity.DAO.PortfolioTblDAO)ViewData["project"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c26cccf6c457d88403a05b1f439d0a7cd697588c4641", async() => {
                WriteLiteral(@"
    <div class=""cover-v1 jarallax overlay"" style=""background-image: url('images/work_1_full.jpg');"">


        <div class=""unslate_co--site-wrap"">

            <div class=""unslate_co--site-inner"">
                <div class=""container"">
                    <div class=""portfolio-single-wrap unslate_co--section"" id=""portfolio-single-section"">
                        <div class=""portfolio-single-inner"">

                            <h2 class=""heading-portfolio-single-h2""> ");
#nullable restore
#line 25 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
                                                                Write(a.Portfolio_Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>

                            <div class=""row justify-content-between align-items-stretch"">

                                <div class=""col-lg-8"">
                                    <p><a href=""images/work_3_a_full.jpg"" data-fancybox=""gal""><img");
                BeginWriteAttribute("src", " src=\"", 1041, "\"", 1065, 1);
#nullable restore
#line 30 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
WriteAttributeValue("", 1047, a.Portfolio_Image, 1047, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Image\" class=\"img-fluid\"></a></p>\r\n");
                WriteLiteral(@"                                </div>
                                <div class=""col-lg-4 pl-lg-5"">
                                    <div class=""unslate_co--sticky"">
                                        <div class=""row"">
                                            <div class=""col-md-12 mb-4"">
                                                <div class=""detail-v1"">
                                                    <span class=""detail-label""> ");
#nullable restore
#line 38 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
                                                                           Write(a.Portfolio_Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                                                    <p>");
#nullable restore
#line 39 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
                                                  Write(a.Portfolio_Content);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                                </div>
                                            </div>

                                            <div class=""col-md-12 mb-4"">
                                                <div class=""detail-v1"">
                                                    <span class=""detail-label"">Proje Tarihi</span>
                                                    <span class=""detail-val"">");
#nullable restore
#line 46 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
                                                                        Write(a.Portfolio_Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                                                </div>
                                            </div>
                                          
                                            <div class=""col-md-12 mb-4"">
                                                <div class=""detail-v1"">
                                                    <span class=""detail-label"">Müşteri</span>
                                                    <span class=""detail-val"">");
#nullable restore
#line 53 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
                                                                        Write(a.Portfolio_Client);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                </div>
                                            </div>
                                            <div class=""col-md-12 mb-4"">
                                                <div class=""detail-v1"">
                                                    <span class=""detail-label"">Proje Link</span>
                                                    <span class=""detail-val""><a href=""#"">");
#nullable restore
#line 59 "C:\Users\Beyza\source\repos\Unfold\Unfold\Views\Project\Index.cshtml"
                                                                                    Write(a.Portfolio_URL);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/</a></span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>


        </div>

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
