#pragma checksum "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6eac86d6bc12398b801a52b7866565e42bc4a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Projects\OnSale2020\OnSale.Web\Views\_ViewImports.cshtml"
using OnSale.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\OnSale2020\OnSale.Web\Views\_ViewImports.cshtml"
using OnSale.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6eac86d6bc12398b801a52b7866565e42bc4a03", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4543f7639545bb76a76fc2b76f886a1f9bf42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnSale.Web.Data.Entities.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteDialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\n<h2>Details</h2>\n\n<div>\n    <h4>Product</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 15 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 18 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 21 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 24 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            Category\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 30 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 33 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 36 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 39 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 42 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 45 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsStarred));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 48 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsStarred));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 51 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 54 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 57 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductImagesNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 60 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductImagesNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 63 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductQualifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 66 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductQualifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6eac86d6bc12398b801a52b7866565e42bc4a0310732", async() => {
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> Image");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6eac86d6bc12398b801a52b7866565e42bc4a0312986", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6eac86d6bc12398b801a52b7866565e42bc4a0315192", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<br />

<div class=""row"">
    <div class=""col-md-5"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Product Images</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTableImages"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 88 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.ProductImages.FirstOrDefault().ImageFullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </th>\n                            <th></th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 94 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                         foreach (var item in Model.ProductImages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 3007, "\"", 3032, 1);
#nullable restore
#line 98 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 3013, item.ImageFullPath, 3013, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px;max-width: 100%; height: auto;\" />\n                                </td>\n                                <td>\n                                    <button data-id=\"");
#nullable restore
#line 101 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger deleteItem\" data-toggle=\"modal\" data-target=\"#deleteDialog\"><i class=\"glyphicon glyphicon-trash\"></i></button>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 104 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class=""col-md-7"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Qualifications</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTableQualifications"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 120 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().DateLocal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 123 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 126 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 129 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 134 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                         foreach (var item in Model.Qualifications)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line 138 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DateLocal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 141 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 144 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 147 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                            </tr>\n");
#nullable restore
#line 150 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6eac86d6bc12398b801a52b7866565e42bc4a0323313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 161 "C:\Projects\OnSale2020\OnSale.Web\Views\Products\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
    <script src=""/js/deleteDialog.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#MyTableImages').DataTable();
            $('#MyTableQualifications').DataTable();

            // Delete item
            sc_deleteDialog.openModal('deleteItem', true, 'btnYesDelete', '/Products/DeleteImage/', false);
        });
    </script>
");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnSale.Web.Data.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
