#pragma checksum "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f98982b00f878ef728a4ba76a287027909d8d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
#line 1 "C:\Users\charu\source\repos\UI\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\charu\source\repos\UI\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f98982b00f878ef728a4ba76a287027909d8d6", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .item{\r\n    margin-left: -140px;\r\n    margin-bottom: -105px;\r\n    }\r\n</style>\r\n<div class=\"container-fluid\">\r\n");
#nullable restore
#line 9 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
     if ((bool)TempData["Saved"])
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success text-center\" id=\"SavedId\" role=\"alert\">\r\n            Saved successfully!\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
     if ((bool)TempData["Update"])
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success text-center\" id=\"UpdateId\" role=\"alert\">\r\n            Updated successfully!\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
     if ((bool)TempData["Delete"])
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success text-center\" id=\"DeleteId\" role=\"alert\">\r\n            Deleted successfully!\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
     if ((bool)TempData["Cannot"])
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger text-center\" id=\"CannotId\" role=\"alert\">\r\n            cannot delete item listed under this category\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div><h3>Item</h3></div>\r\n    <div class=\"clearfix\"></div>\r\n    <div class=\"col-6 float-lg-right\">\r\n        <div>\r\n\r\n            <a class=\"btn btn-success float-lg-left\" style=\"margin-left: 290px;margin-top: 24px;\"");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1168, 1);
#nullable restore
#line 42 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
WriteAttributeValue("", 1133, Url.Action("Index","ItemCategory"), 1133, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Item-Category</a>\r\n        </div>\r\n        &nbsp;&nbsp;\r\n        <div>\r\n            <a class=\"btn btn-danger float-lg-right\"");
            BeginWriteAttribute("href", " href=\"", 1294, "\"", 1344, 1);
#nullable restore
#line 46 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
WriteAttributeValue("", 1301, Url.Action("ApplicationUserLogin","Login"), 1301, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Logout</a>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"clearfix\"></div>\r\n    <div class=\"clearfix\"></div>\r\n    <div>\r\n        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1501, "\"", 1536, 1);
#nullable restore
#line 53 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
WriteAttributeValue("", 1508, Url.Action("Create","Item"), 1508, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Create</a>
    </div>
    <br />

    <table class=""table"">
        <thead>
            <tr>

                <th scope=""col"">Item-Category</th>
                <th scope=""col"">Item</th>
                <th scope=""col"">Stock</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 68 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
             if (Model != null)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 73 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
                                   Write(item.ItemCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
#nullable restore
#line 74 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
#nullable restore
#line 75 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
                                   Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
#nullable restore
#line 76 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"
                                   Write(Html.ActionLink("Transaction", "Edit", new { id = @item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 80 "C:\Users\charu\source\repos\UI\UI\Views\Item\Index.cshtml"

                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            setTimeout(Message, 3000);
        });
        function Message() {
            $(""#SavedId"").hide()
            $(""#UpdateId"").hide()
            $(""#DeleteId"").hide()
            $(""#CannotId"").hide()
        }

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
