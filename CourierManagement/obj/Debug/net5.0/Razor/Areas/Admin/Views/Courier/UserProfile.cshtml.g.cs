#pragma checksum "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d6d77be0aaa588cbce06472134e149787d9af11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Courier_UserProfile), @"mvc.1.0.view", @"/Areas/Admin/Views/Courier/UserProfile.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6d77be0aaa588cbce06472134e149787d9af11", @"/Areas/Admin/Views/Courier/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9327946bd9dfbc3a19ab6a70eab9177d7f52de", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Courier_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourierManagement.Areas.Admin.Models.TrackingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Tracking Id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("account"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
  
    ViewData["Title"] = "User Profile";
    Layout = "~/Areas/Admin/Views/Shared/_Layout3.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"hero-area bg-primary\" id=\"parallax\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-11 mx-auto\">\r\n                <h1 class=\"text-white font-tertiary\">\r\n                    Hi! I’m <br> ");
#nullable restore
#line 13 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
                            Write(Html.ViewData["username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ID :\r\n                    ");
#nullable restore
#line 14 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
               Write(Html.ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 15 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
               Write(Accessor.HttpContext.Session.GetString("emailid"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h1>
            </div>
        </div>
    </div>
    <div class=""layer-bg w-100"">
        <img class=""img-fluid w-100"" src=""/User/images/illustrations/leaf-bg.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l2"">
        <img src=""/User/images/illustrations/dots-cyan.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l3"">
        <img src=""/User/images/illustrations/leaf-orange.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l4"">
        <img src=""/User/images/illustrations/dots-orange.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l5"">
        <img src=""/User/images/illustrations/leaf-yellow.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l6"">
        <img src=""/User/images/illustrations/leaf-cyan.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l7"">
        <img src=""/User/images/illustrations/dots-group-orange.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l8"">
        <img src=""/User/ima");
            WriteLiteral(@"ges/illustrations/leaf-pink-round.png"" alt=""bg-shape"">
    </div>
    <div class=""layer"" id=""l9"">
        <img src=""/User/images/illustrations/leaf-cyan-2.png"" alt=""bg-shape"">
    </div>
    <!-- social icon -->
    <ul class=""list-unstyled ml-5 mt-3 position-relative zindex-1"">
        <li class=""mb-3""><a class=""text-white"" href=""https://themefisher.com/""><i class=""ti-facebook""></i></a></li>
        <li class=""mb-3""><a class=""text-white"" href=""https://themefisher.com/""><i class=""ti-instagram""></i></a></li>
        <li class=""mb-3""><a class=""text-white"" href=""https://themefisher.com/""><i class=""ti-dribbble""></i></a></li>
        <li class=""mb-3""><a class=""text-white"" href=""https://themefisher.com/""><i class=""ti-twitter""></i></a></li>
    </ul>
    <!-- /social icon -->
</section>
<section class=""section section-on-footer"" data-background=""images/backgrounds/bg-dots.png"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 text-center"">
                <h2 cla");
            WriteLiteral("ss=\"section-title\">Tracking Parcel</h2>\r\n            </div>\r\n            <div class=\"col-lg-8 mx-auto\">\r\n                <div class=\"bg-white rounded text-center p-5 shadow-down\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d6d77be0aaa588cbce06472134e149787d9af1110501", async() => {
                WriteLiteral("\r\n                        <hr />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d6d77be0aaa588cbce06472134e149787d9af1110818", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 66 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d6d77be0aaa588cbce06472134e149787d9af1112603", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 68 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div><br />
                        <div class=""col-lg-6 col-10 mx-auto"">
                            <button class=""btn btn-primary w-100"">Search</button>
                        </div>
                        <h5 >
                            Status of your parcel: <br> ");
#nullable restore
#line 74 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\UserProfile.cshtml"
                                                   Write(Html.ViewData["status"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </h5>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourierManagement.Areas.Admin.Models.TrackingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591