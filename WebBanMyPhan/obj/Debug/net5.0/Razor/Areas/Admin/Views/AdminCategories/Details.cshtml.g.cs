#pragma checksum "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62e4da007413c67ff38e1890d857ddadfc97c936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCategories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCategories/Details.cshtml")]
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
#line 1 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanMyPhan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanMyPhan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e4da007413c67ff38e1890d857ddadfc97c936", @"/Areas/Admin/Views/AdminCategories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781878525492c056e2f66052e6123f1f81c27f4f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminCategories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanMyPhan.Models.Category>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminCategories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
  
    ViewData["Title"] = "Th??ng tin Danh m???c" + Model.CatName;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e4da007413c67ff38e1890d857ddadfc97c9366242", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e4da007413c67ff38e1890d857ddadfc97c9367940", async() => {
                WriteLiteral("Danh s??ch Pages");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Th??ng tin Danh m???c : ");
#nullable restore
#line 13 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                                 Write(Model.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </nav>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Th??ng tin s???n ph???m: ");
#nullable restore
#line 20 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                              Write(Model.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <div class=""table-responsive"">
            <table class=""product-info-table m-t-20"">
                <tbody>
                    <tr>
                        <td>ID:</td>
                        <td class=""text-dark font-weight-semibold"">");
#nullable restore
#line 26 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                                                              Write(Model.CatId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>T??n Pages</td>\r\n                        <td>");
#nullable restore
#line 30 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>M?? T???:</td>\r\n                        <td>");
#nullable restore
#line 34 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    \r\n                    <tr>\r\n                        <td>Active:</td>\r\n                        <td>\r\n");
#nullable restore
#line 40 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                             if (Model.Published)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 1743, "\"", 1753, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label for=\"switch-1\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 46 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"switch m-r-10\">\r\n                                    <input type=\"checkbox\" id=\"switch-2\"");
            BeginWriteAttribute("checked", " checked=\"", 2094, "\"", 2104, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label for=\"switch-2\"></label>\r\n                                </div>\r\n");
#nullable restore
#line 53 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>                   \r\n                    <tr>\r\n                        <td>Alias:</td>\r\n                        <td>");
#nullable restore
#line 58 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>                 \r\n                    \r\n                    \r\n                    <tr>\r\n                        <td>Ti??u ?????:</td>\r\n                        <td>");
#nullable restore
#line 64 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>MetaDesc:</td>\r\n                        <td>");
#nullable restore
#line 68 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.MetaDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>MetaKey:</td>\r\n                        <td>");
#nullable restore
#line 72 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.MetaKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>                    \r\n                    <tr>\r\n                        <td>???nh ?????i di???n:</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62e4da007413c67ff38e1890d857ddadfc97c93615649", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3152, "~/images/pages/", 3152, 15, true);
#nullable restore
#line 77 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
AddHtmlAttributeValue("", 3167, Model.Thumb, 3167, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 77 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
AddHtmlAttributeValue("", 3186, Model.Title, 3186, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>M?? t???:</td>\r\n                        <td>");
#nullable restore
#line 82 "E:\HocTap\DoAnChuyenNganh\WebBanMyPhan\WebBanMyPhan\WebBanMyPhan\Areas\Admin\Views\AdminCategories\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanMyPhan.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
