#pragma checksum "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa4ff0dd69f857457531d4cd03c8aac8dd2b9cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Courier_Price), @"mvc.1.0.view", @"/Areas/Admin/Views/Courier/Price.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fa4ff0dd69f857457531d4cd03c8aac8dd2b9cc", @"/Areas/Admin/Views/Courier/Price.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b7df09723a08ccdc55e9f97926ffad98c5aa7aa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Courier_Price : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PriceCalculationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 734, "\"", 741, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-facebook-f\"></i>\n                </a>\n                <a class=\"text-white px-2\"");
            BeginWriteAttribute("href", " href=\"", 861, "\"", 868, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-twitter\"></i>\n                </a>\n                <a class=\"text-white px-2\"");
            BeginWriteAttribute("href", " href=\"", 985, "\"", 992, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-linkedin-in\"></i>\n                </a>\n                <a class=\"text-white px-2\"");
            BeginWriteAttribute("href", " href=\"", 1113, "\"", 1120, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <i class=\"fab fa-instagram\"></i>\n                </a>\n                <a class=\"text-white pl-2\"");
            BeginWriteAttribute("href", " href=\"", 1239, "\"", 1246, 0);
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
            WriteLiteral(@"=""Price"" class=""nav-item nav-link active"">Price</a>
                <a href=""Contact"" class=""nav-item nav-link"">Contact</a>
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
        <h1 class=""text-white display-3"">Price</h1>
        <div class=""d-inline-flex align-items-center text-white"">
            <p class=""m-0""><a class=""text-white""");
            BeginWriteAttribute("href", " href=\"", 3238, "\"", 3245, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a></p>
            <i class=""fa fa-circle px-3""></i>
            <p class=""m-0"">Price</p>
        </div>
    </div>
</div>
<!-- Header End -->
<!-- Pricing Plan Start -->
<div class=""container-fluid pt-5"">
    <div class=""container"">
        <div class=""text-center pb-2"">
            <h6 class=""text-primary text-uppercase font-weight-bold"">Pricing Plan</h6>
            <h1 class=""mb-4"">Affordable Pricing Packages</h1>
        </div>
        <div class=""row"">
            <div class=""col-md-4 mb-5"">
                <div class=""bg-secondary"">
                    <div class=""text-center p-4"">
                        <h1 class=""display-4 mb-0"">
                            <small class=""align-top text-muted font-weight-medium"" style=""font-size: 22px; line-height: 45px;"">BDT</small>49<small class=""align-bottom text-muted font-weight-medium"" style=""font-size: 16px; line-height: 40px;"">/Kg</small>
                        </h1>
                    </div>
                    <div class=""bg-primary text-center p-4");
            WriteLiteral(@""">
                        <h3 class=""m-0"">By Air</h3>
                    </div>
                    <div class=""d-flex flex-column align-items-center py-4"">
                        <p>Cloth</p>
                        <p>Paper</p>
                        <p>Mobile</p>
                        <p>Dry Food</p>
                        <a href=""UserLogin"" class=""btn btn-primary py-2 px-4 my-2"">Order Now</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 mb-5"">
                <div class=""bg-secondary"">
                    <div class=""text-center p-4"">
                        <h1 class=""display-4 mb-0"">
                            <small class=""align-top text-muted font-weight-medium"" style=""font-size: 22px; line-height: 45px;"">BDT</small>39<small class=""align-bottom text-muted font-weight-medium"" style=""font-size: 16px; line-height: 40px;"">/Kg</small>
                        </h1>
                    </div>
                    <div class=""bg-primary text-cen");
            WriteLiteral(@"ter p-4"">
                        <h3 class=""m-0"">By Ocean</h3>
                    </div>
                    <div class=""d-flex flex-column align-items-center py-4"">
                        <p>Wet Food</p>
                        <p>Vehicle Parts</p>
                        <p>Froozen Items</p>
                        <p>Industrial Products</p>
                        <a href=""UserLogin"" class=""btn btn-primary py-2 px-4 my-2"">Order Now</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 mb-5"">
                <div class=""bg-secondary"">
                    <div class=""text-center p-4"">
                        <h1 class=""display-4 mb-0"">
                            <small class=""align-top text-muted font-weight-medium"" style=""font-size: 22px; line-height: 45px;"">BDT</small>.59<small class=""align-bottom text-muted font-weight-medium"" style=""font-size: 16px; line-height: 40px;"">/Kg</small>
                        </h1>
                    </div>
            ");
            WriteLiteral(@"        <div class=""bg-primary text-center p-4"">
                        <h3 class=""m-0"">Land Trasport</h3>
                    </div>
                    <div class=""d-flex flex-column align-items-center py-4"">
                        <p>Bike</p>
                        <p>Food</p>
                        <p>Cloth</p>
                        <p>All types of Legal Products</p>
                        <a href=""UserLogin"" class=""btn btn-primary py-2 px-4 my-2"">Order Now</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Pricing Plan End -->


<div align=""center"" >
    <div class=""col-md-5"">
        <!-- Form Element sizes -->
        <div class=""card card-success"">
            <div class=""card-header"">
                <h3 class=""card-title"">Total Cost</h3>
            </div>
            <div class=""card-body"">
");
#nullable restore
#line 157 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
                 using (Html.BeginForm("Price", "Courier", FormMethod.Post, new { id = "submitForm" }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <fieldset>\n                        <h4>Quantity(kg): </h4>");
#nullable restore
#line 160 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
                                          Write(Html.EditorFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\n                        <h4>Distance(km): </h4>");
#nullable restore
#line 161 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
                                          Write(Html.EditorFor(x => x.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br /><br />
                        <input class=""btn btn-primary py-2 px-4 my-2"" type=""submit"" value=""By_Air"" name=""command"" />
                        <input class=""btn btn-primary py-2 px-4 my-2"" type=""submit"" value=""By_Ocean"" name=""command"" />
                        <input class=""btn btn-primary py-2 px-4 my-2"" type=""submit"" value=""Land_Transport"" name=""command"" /><br /><br />
                        ");
#nullable restore
#line 165 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
                   Write(Html.Label("Total Cost is :BDT"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 165 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
                                                     Write(Html.DisplayFor(x => x.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </fieldset>\n");
#nullable restore
#line 167 "C:\Users\User\Desktop\CourierManagement\CourierManagement\CourierManagement\Areas\Admin\Views\Courier\Price.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <!-- /.card-body -->\n        </div>\n        <!-- /.card -->\n\n    </div>\n</div>\n\n    \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PriceCalculationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
