#pragma checksum "D:\InventoryProject\UI\UI\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8ccee33c6163c388bf3f7c9b45dfd19680917e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "D:\InventoryProject\UI\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\InventoryProject\UI\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8ccee33c6163c388bf3f7c9b45dfd19680917e7", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.ApplicationUser>
    {
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
            WriteLiteral("<style>\r\n\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8ccee33c6163c388bf3f7c9b45dfd19680917e73011", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""text-center"">
            <h5>ShopBridge</h5>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-9 col-md-7 col-lg-5 mx-auto"">
                    <div class=""card card-signin my-5"">
                        <div class=""card-body"">
                            <h5 class=""card-title text-center"">Login</h5>
");
#nullable restore
#line 21 "D:\InventoryProject\UI\UI\Views\Login\Login.cshtml"
                             using (Html.BeginForm())
                            {
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"form-label-group\">\r\n                                        <label>Username</label>\r\n                                        ");
#nullable restore
#line 26 "D:\InventoryProject\UI\UI\Views\Login\Login.cshtml"
                                   Write(Html.TextBoxFor(x => x.UserName, "", new { @class = "form-control", @placeholder = "Username", @required = "@required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div class=\"form-label-group\">\r\n                                        <label for=\"inputPassword\">Password</label>\r\n                                        ");
#nullable restore
#line 31 "D:\InventoryProject\UI\UI\Views\Login\Login.cshtml"
                                   Write(Html.TextBoxFor(x => x.Password, "", new { @class = "form-control", @placeholder = "Password", @required = "@required",@type="Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n");
                WriteLiteral("                                    <button class=\"btn btn-lg btn-primary btn-block text-uppercase\"");
                BeginWriteAttribute("formaction", " formaction=\"", 1563, "\"", 1620, 1);
#nullable restore
#line 35 "D:\InventoryProject\UI\UI\Views\Login\Login.cshtml"
WriteAttributeValue("", 1576, Url.Action("ApplicationUserLogin", "Login"), 1576, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" formmethod=\"post\" type=\"submit\">Login</button>\r\n                                    <hr class=\"my-4\">\r\n");
#nullable restore
#line 37 "D:\InventoryProject\UI\UI\Views\Login\Login.cshtml"

                                
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
