#pragma checksum "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec5a5d595d1937cf3b9bd4c2cd133f384ea2715b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Courier_CourierProfile), @"mvc.1.0.view", @"/Areas/Admin/Views/Courier/CourierProfile.cshtml")]
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
#line 1 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5a5d595d1937cf3b9bd4c2cd133f384ea2715b", @"/Areas/Admin/Views/Courier/CourierProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b7df09723a08ccdc55e9f97926ffad98c5aa7aa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Courier_CourierProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeletePopupPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml"
  
    ViewData["Title"] = "Courier Profile";
    Layout = "~/Areas/Admin/Views/Shared/_Layout3.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css\">\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/admin/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>

    <script>
        $(function () {
            $('#orders').DataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""ajax"": ""/Admin/Courier/GetOrderData"",

                ""columnDefs"": [
                    {
                        ""orderable"": false,
                        ""targets"": 8,
                        ""render"": function (data, type, row) {

                            return `<button type=""submit"" class=""btn btn-info btn-sm"" onclick=""window.location.href='/admin/Courier/EditOrderByCourier/${data}'"" value='${data}'>
                                                <i class=""fas fa-pencil-alt"">
                                                </i>
                                                Edit
                                            </button>`;
                        }
       ");
                WriteLiteral("             }\n                ]\n\n            });\n\n            \n        });\n    </script>\n");
            }
            );
            WriteLiteral(@"
<header class=""navigation fixed-top"">
    <nav class=""navbar navbar-expand-lg navbar-dark"">
        <a class=""navbar-brand font-tertiary h3"" href=""UserProfile"">Door2Door</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation""
                aria-controls=""navigation"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse text-center"" id=""navigation"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item "">
                    <a class=""nav-link"" href=""CourierProfile"">Home</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 2230, "\"", 2271, 2);
            WriteAttributeValue("", 2237, "CourierUpdate/", 2237, 14, true);
#nullable restore
#line 62 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml"
WriteAttributeValue("", 2251, Html.ViewData["id"], 2251, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Edit Profile</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""Index"">Logout</a>
                </li>
            </ul>
        </div>
    </nav>
</header>
<section class=""hero-area bg-primary"" id=""parallax"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-11 mx-auto"">
                <h1 class=""text-white font-tertiary"">
                    Hi! I’m <br> ");
#nullable restore
#line 76 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml"
                            Write(Html.ViewData["username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> ID :\n                    ");
#nullable restore
#line 77 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml"
               Write(Html.ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n                    ");
#nullable restore
#line 78 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\CourierProfile.cshtml"
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
        <img src=""/User/images/illustrations/leaf-pink");
            WriteLiteral(@"-round.png"" alt=""bg-shape"">
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
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""car");
            WriteLiteral(@"d-title"">All Orders</h4>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <table id=""orders"" class=""table table-bordered table-hover"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Customer Id</th>
                                    <th>From</th>
                                    <th>To</th>
                                    <th>Transaction Id</th>
                                    <th>Payment</th>
                                    <th>SourceToOffice</th>
                                    <th>OfficeToDestinatioin</th>
                                    <th>Action</th>
                                </tr>
                            </thead>

                            <tfoot>
                                <tr>
                                    <th>Id</th>
                                    ");
            WriteLiteral(@"<th>Customer Id</th>
                                    <th>From</th>
                                    <th>To</th>
                                    <th>Transaction Id</th>
                                    <th>Payment</th>
                                    <th>SourceToOffice</th>
                                    <th>OfficeToDestinatioin</th>
                                    <th>Action</th>
                                </tr>
                            </tfoot>
                        </table>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec5a5d595d1937cf3b9bd4c2cd133f384ea2715b12560", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
<!-- /.content -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
