#pragma checksum "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "875650796a2306c5c7854c059298c55fe185d64f5edd6cbb66f9c7457a7439ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SpecialTag_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SpecialTag/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SpecialTag_Index))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop

    ;
#line 1 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
 using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"875650796a2306c5c7854c059298c55fe185d64f5edd6cbb66f9c7457a7439ae", @"/Areas/Admin/Views/SpecialTag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a874db409d8a73e2ac1fdbeb6779cdf1c4c62cc22f2012edef9e5226e66e5e66", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SpecialTag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpecialTag>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TagPageButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
      
        ViewData["Title"] = "Index";
    

#line default
#line hidden

            BeginContext(107, 190, true);
            WriteLiteral("\n    <br /><br />\n    <div class=\"row\">\n        <div class=\"col-6\">\n            <h2 class=\"text-info\">Special Tag List</h2>\n        </div>\n        <div class=\"col-6 text-right\">\n            ");
            EndContext();
            BeginContext(297, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "875650796a2306c5c7854c059298c55fe185d64f5edd6cbb66f9c7457a7439ae4995", async() => {
                BeginContext(341, 46, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Tag Name");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(391, 176, true);
            WriteLiteral("\n        </div>\n    </div>\n    <br />\n    <div>\n        <table class=\"table table-striped border\">\n            <tr class=\"table-info\">\n                <th>\n                    ");
            EndContext();
            BeginContext(568, 32, false);
            Write(
#line 21 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                     Html.DisplayNameFor(c => c.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(600, 93, true);
            WriteLiteral("\n                </th>\n                <th></th>\n                <th></th>\n            </tr>\n");
            EndContext();
#line 26 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden

            BeginContext(748, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(794, 9, false);
            Write(
#line 29 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                         item.Name

#line default
#line hidden
            );
            EndContext();
            BeginContext(803, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(858, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "875650796a2306c5c7854c059298c55fe185d64f5edd6cbb66f9c7457a7439ae7995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#line 31 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
                                                                      item.Id

#line default
#line hidden
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(915, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 34 "C:\Users\Rasel Ahmed\Downloads\onlineshop-master\OnlineShop\Areas\Admin\Views\SpecialTag\Index.cshtml"
            }

#line default
#line hidden

            BeginContext(978, 28, true);
            WriteLiteral("        </table>\n    </div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpecialTag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
