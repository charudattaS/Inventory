#pragma checksum "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3fb8c53dc5964f824c38adab425e930d4c4d08c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemCategory_Create), @"mvc.1.0.view", @"/Views/ItemCategory/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3fb8c53dc5964f824c38adab425e930d4c4d08c", @"/Views/ItemCategory/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemCategory_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.ItemCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<div class=\"container-fluid\">\r\n    <div>\r\n        <h5>Item</h5>\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
     using (Html.BeginForm())
    {


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-success btn-sm float-right\"");
            BeginWriteAttribute("formaction", " formaction=\"", 308, "\"", 358, 1);
#nullable restore
#line 17 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
WriteAttributeValue("", 321, Url.Action("Create", "ItemCategory"), 321, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" type=\"submit\">Save</button>\r\n");
#nullable restore
#line 18 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
       Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
       Write(Html.HiddenFor(x => x.ShopId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <button class=\"btn btn-success btn-sm float-left\" style=\"margin-left: 950px;\"");
            BeginWriteAttribute("formaction", " formaction=\"", 631, "\"", 679, 1);
#nullable restore
#line 24 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
WriteAttributeValue("", 644, Url.Action("Edit", "ItemCategory"), 644, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" type=\"submit\">Update</button>\r\n            <button class=\"btn btn-danger btn-sm float-right\"");
            BeginWriteAttribute("formaction", " formaction=\"", 791, "\"", 841, 1);
#nullable restore
#line 25 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
WriteAttributeValue("", 804, Url.Action("Delete", "ItemCategory"), 804, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" formmethod=\"post\" type=\"submit\">Delete</button>\r\n        </div>\r\n");
#nullable restore
#line 27 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix\"></div>\r\n        <br />\r\n");
#nullable restore
#line 31 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
   Write(Html.Label("Category Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
   Write(Html.TextBoxFor(x => x.Name, "", new { @minlength = "1", @maxlength = "20", @required = "@required" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
   Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
                                               

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-1\">\r\n    ");
#nullable restore
#line 37 "D:\InventoryProject\UI\UI\Views\ItemCategory\Create.cshtml"
Write(Html.ActionLink("Back", "Index", "Itemcategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n  \r\n</div>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.ItemCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
