<<<<<<< HEAD
#pragma checksum "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4985b79fe3d57b2802817cc0bc1cf0f7b29ee47d"
=======
#pragma checksum "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8adb11f58620dbd5049273c14b8d59f26e3d379a"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_ViewGame), @"mvc.1.0.view", @"/Views/Game/ViewGame.cshtml")]
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
<<<<<<< HEAD
#line 1 "/Users/javanogden/Desktop/GameNews/Views/_ViewImports.cshtml"
=======
#line 1 "C:\Users\Myles\Desktop\GameNews\Views\_ViewImports.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
using GameStock;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "/Users/javanogden/Desktop/GameNews/Views/_ViewImports.cshtml"
=======
#line 2 "C:\Users\Myles\Desktop\GameNews\Views\_ViewImports.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
using GameStock.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "/Users/javanogden/Desktop/GameNews/Views/_ViewImports.cshtml"
=======
#line 4 "C:\Users\Myles\Desktop\GameNews\Views\_ViewImports.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4985b79fe3d57b2802817cc0bc1cf0f7b29ee47d", @"/Views/Game/ViewGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b36130c5bc9d1413c79fa1dbed9bc98bd10747", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_ViewGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-warning ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<div class=\"card mt-5 p-3\" style=\"width: 48rem;\">\n  <img class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 102, "\"", 121, 1);
#nullable restore
<<<<<<< HEAD
#line 6 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
WriteAttributeValue("", 108, Model.ImgUrl, 108, 13, false);
=======
#line 6 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
WriteAttributeValue("", 113, Model.ImgUrl, 113, 13, false);
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Post\">\n  <div class=\"card-body\">\n    <h5 class=\"card-title h3 text-center\">");
#nullable restore
<<<<<<< HEAD
#line 8 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 8 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <p class=\"card-text h5 text-center\">");
#nullable restore
<<<<<<< HEAD
#line 9 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 9 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
                                   Write(Model.CurrentRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p class=\"card-text h4 text-center\">");
#nullable restore
<<<<<<< HEAD
#line 10 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 10 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
                                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
<<<<<<< HEAD
#line 11 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 11 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
     if (Model.UserId == Context.Session.GetInt32("UserId"))
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row justify-content-center p-3\">\n");
            WriteLiteral("      ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4985b79fe3d57b2802817cc0bc1cf0f7b29ee47d6589", async() => {
                WriteLiteral("\n        <button class=\"btn btn-outline-danger btn-sm\">Delete</button>\n      ");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8adb11f58620dbd5049273c14b8d59f26e3d379a6697", async() => {
                WriteLiteral("\r\n        <button class=\"btn btn-outline-danger btn-sm\">Delete</button>\r\n      ");
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 15 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 15 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
                                                            WriteLiteral(Model.GameId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
            WriteLiteral("\n\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4985b79fe3d57b2802817cc0bc1cf0f7b29ee47d9480", async() => {
                WriteLiteral("\n        Edit\n      ");
=======
            WriteLiteral("\r\n\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8adb11f58620dbd5049273c14b8d59f26e3d379a9630", async() => {
                WriteLiteral("\r\n        Edit\r\n      ");
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 19 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 19 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
                                                       WriteLiteral(Model.GameId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
<<<<<<< HEAD
#line 24 "/Users/javanogden/Desktop/GameNews/Views/Game/ViewGame.cshtml"
=======
#line 24 "C:\Users\Myles\Desktop\GameNews\Views\Game\ViewGame.cshtml"
>>>>>>> bdcdc379f69ddfac345ef2a55c26a78ab7bcff3e
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
