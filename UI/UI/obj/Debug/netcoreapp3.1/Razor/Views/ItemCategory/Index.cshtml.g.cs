#pragma checksum "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eda2e837d3e72fc135461eafd95416ebe09ef72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemCategory_Index), @"mvc.1.0.view", @"/Views/ItemCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eda2e837d3e72fc135461eafd95416ebe09ef72", @"/Views/ItemCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.ItemCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <style>\r\n        .itemCategory {\r\n            margin-left: -140px;\r\n            margin-bottom: -105px;\r\n        }\r\n    </style>\r\n    <div class=\"container-fluid\">\r\n");
#nullable restore
#line 9 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
         if ((bool)TempData["Saved"])
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success text-center\" id=\"SavedId\" role=\"alert\">\r\n                Saved successfully!\r\n            </div>\r\n");
#nullable restore
#line 15 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
         if ((bool)TempData["Update"])
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success text-center\" id=\"UpdateId\" role=\"alert\">\r\n                Updated successfully!\r\n            </div>\r\n");
#nullable restore
#line 22 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
         if ((bool)TempData["Delete"])
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success text-center\" id=\"DeleteId\" role=\"alert\">\r\n                Deleted successfully!\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
         if ((bool)TempData["Cannot"])
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger text-center\" id=\"CannotId\" role=\"alert\">\r\n                cannot delete or update item listed under this category\r\n            </div>\r\n");
#nullable restore
#line 36 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h3>Item-Category</h3>\r\n        <div class=\"clearfix\"></div>\r\n        <div class=\"col-2 float-lg-right\">\r\n            <div>\r\n\r\n                <a class=\"btn btn-success float-lg-left\"");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1300, 1);
#nullable restore
#line 43 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
WriteAttributeValue("", 1273, Url.Action("Index","Item"), 1273, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-top: 24px;\">Item</a>\r\n            </div>\r\n            &nbsp;  &nbsp;\r\n            <div> \r\n\r\n                <a class=\"btn btn-danger float-lg-right\"");
            BeginWriteAttribute("href", " href=\"", 1464, "\"", 1514, 1);
#nullable restore
#line 48 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
WriteAttributeValue("", 1471, Url.Action("ApplicationUserLogin","Login"), 1471, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Logout</a>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"clearfix\"></div>\r\n        <br />\r\n        <div>\r\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1673, "\"", 1716, 1);
#nullable restore
#line 55 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
WriteAttributeValue("", 1680, Url.Action("Create","ItemCategory"), 1680, 36, false);

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

                    <th scope=""col"" class=""text-center"">Item-Category</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 69 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
                 if (Model != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 74 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th scope=\"row\">");
#nullable restore
#line 75 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"
                                       Write(Html.ActionLink("Edit", "Edit", new { id = @item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 79 "D:\InventoryProject\UI\UI\Views\ItemCategory\Index.cshtml"

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.ItemCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
