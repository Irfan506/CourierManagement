#pragma checksum "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89020fad67290f63b017fa9a659f715b5140c685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Courier_Contact), @"mvc.1.0.view", @"/Areas/Admin/Views/Courier/Contact.cshtml")]
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
#line 1 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\_ViewImports.cshtml"
using CourierManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\_ViewImports.cshtml"
using CourierManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\_ViewImports.cshtml"
using CourierManagement.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89020fad67290f63b017fa9a659f715b5140c685", @"/Areas/Admin/Views/Courier/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b7df09723a08ccdc55e9f97926ffad98c5aa7aa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Courier_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Contact.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Topbar Start -->
<div class=""container-fluid bg-dark"">
    <div class=""row py-2 px-lg-5"">
        <div class=""col-lg-6 text-center text-lg-left mb-2 mb-lg-0"">
            <div class=""d-inline-flex align-items-center text-white"">
                <small><i class=""fa fa-phone-alt mr-2""></i>+018 111 222 33</small>
                <small class=""px-3"">|</small>
                <small><i class=""fa fa-envelope mr-2""></i>Door2Door@gmail.com</small>
            </div>
        </div>
        <div class=""col-lg-6 text-center text-lg-right"">
            <div class=""d-inline-flex align-items-center"">
                <a class=""text-white px-2""");
            BeginWriteAttribute("href", " href=\"", 705, "\"", 712, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-facebook-f\"></i>\n                </a>\n                <a class=\"text-white px-2\"");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 839, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-twitter\"></i>\n                </a>\n                <a class=\"text-white px-2\"");
            BeginWriteAttribute("href", " href=\"", 956, "\"", 963, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-linkedin-in\"></i>\n                </a>\n                <a class=\"text-white px-2\"");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1091, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-instagram\"></i>\n                </a>\n                <a class=\"text-white pl-2\"");
            BeginWriteAttribute("href", " href=\"", 1210, "\"", 1217, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <i class=""fab fa-youtube""></i>
                </a>
            </div>
        </div>
    </div>
</div>
<!-- Topbar End -->
<!-- Navbar Start -->
<div class=""container-fluid p-0"">
    <nav class=""navbar navbar-expand-lg bg-light navbar-light py-3 py-lg-0 px-lg-5"">
        <a href=""Index"" class=""navbar-brand ml-lg-3"">
            <h1 class=""m-0 display-5 text-uppercase text-primary""><i class=""fa fa-truck mr-2""></i>Door2Door</h1>
        </a>
        <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse justify-content-between px-lg-3"" id=""navbarCollapse"">
            <div class=""navbar-nav m-auto py-0"">
                <a href=""Index"" class=""nav-item nav-link"">Home</a>
                <a href=""About"" class=""nav-item nav-link"">About</a>
                <a href=""Service"" class=""nav-item nav-link"">Service</a>
                <a href");
            WriteLiteral(@"=""Price"" class=""nav-item nav-link"">Price</a>
                <a href=""Contact"" class=""nav-item nav-link active"">Contact</a>
                <div class=""nav-item dropdown"">
                    <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">Account</a>
                    <div class=""dropdown-menu rounded-0 m-0"">
                        <a href=""CustomerLogin"" class=""dropdown-item"">User </a>
                        <a href=""CourierLogin"" class=""dropdown-item"">Courier</a>
                        <a href=""Login"" class=""dropdown-item"">Admin</a>
                    </div>
                </div>
            </div>
        </div>
    </nav>
</div>
<!-- Navbar End -->
<!-- Header Start -->
<div class=""jumbotron jumbotron-fluid mb-5"">
    <div class=""container text-center py-5"">
        <h1 class=""text-white display-3"">Contact</h1>
        <div class=""d-inline-flex align-items-center text-white"">
            <p class=""m-0""><a class=""text-white""");
            BeginWriteAttribute("href", " href=\"", 3211, "\"", 3218, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a></p>
            <i class=""fa fa-circle px-3""></i>
            <p class=""m-0"">Contact</p>
        </div>
    </div>
</div>
<!-- Header End -->
<!-- Contact Start -->
<div class=""container-fluid py-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-5 pb-4 pb-lg-0"">
                <div class=""bg-primary text-dark text-center p-4"">
                    <h4 class=""m-0""><i class=""fa fa-map-marker-alt text-white mr-2""></i>123 Street, JamalKhan, Chittagong</h4>
                </div>
                <iframe style=""width: 100%; height: 470px; border:0""
                        src=""https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d14761.896882298171!2d91.80466965000001!3d22.33571605!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sbd!4v1664167829698!5m2!1sen!2sbd""");
            BeginWriteAttribute("allowfullscreen", " \n                        allowfullscreen=\"", 4041, "\"", 4084, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>

                
            </div>
            <div class=""col-lg-7"">
                <h6 class=""text-primary text-uppercase font-weight-bold"">Contact Us</h6>
                <h1 class=""mb-4"">Contact For Any Queries</h1>
                <div class=""contact-form bg-secondary"" style=""padding: 30px;"">
                    <div id=""success""></div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89020fad67290f63b017fa9a659f715b5140c68510553", async() => {
                WriteLiteral(@"
                        <div class=""control-group"">
                            <h3>Hotline 123354</h3><br /><br />
                        </div>
                        <div class=""control-group"">
                            <h3>door2door@gmail.com</h3><br /><br />
                        </div>
                        <div class=""control-group"">
                            <h3>https://www.linkedin.com/door2door</h3><br /><br />
                        </div>
                        <div class=""control-group"">
                            <h3>Or visit our office</h3>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Contact End -->");
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
