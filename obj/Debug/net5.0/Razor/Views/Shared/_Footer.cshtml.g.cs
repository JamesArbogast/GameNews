#pragma checksum "E:\Coding Dojo\C#\Asp\GameNews\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "577e7077e4a7eae355b176c77d91febb0c6bde9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "E:\Coding Dojo\C#\Asp\GameNews\Views\_ViewImports.cshtml"
using GameStock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Coding Dojo\C#\Asp\GameNews\Views\_ViewImports.cshtml"
using GameStock.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Coding Dojo\C#\Asp\GameNews\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"577e7077e4a7eae355b176c77d91febb0c6bde9c", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa2b54636d8232d89696a39571d575133222c6d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""py-5"">
    <div class=""row"">
      <div class=""col-2"">
        <h5>Section</h5>
        <ul class=""nav flex-column"">
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Dashboard</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Register</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Add Rating</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">About</a></li>
        </ul>
      </div>

      <div class=""col-2"">
        <h5>Section</h5>
        <ul class=""nav flex-column"">
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Dashboard</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Register</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Add Rating</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 t");
            WriteLiteral(@"ext-muted"">About</a></li>
        </ul>
      </div>

      <div class=""col-2"">
        <h5>Section</h5>
        <ul class=""nav flex-column"">
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Dashboard</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Register</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Add Rating</a></li>
          <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">About</a></li>
        </ul>
      </div>

      <div class=""col-4 offset-1"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "577e7077e4a7eae355b176c77d91febb0c6bde9c5094", async() => {
                WriteLiteral(@"
          <h5>Subscribe to our newsletter</h5>
          <p>Monthly digest of whats new and exciting from us.</p>
          <div class=""d-flex w-100 gap-2"">
            <label for=""newsletter1"" class=""visually-hidden"">Email address</label>
            <input id=""newsletter1"" type=""text"" class=""form-control"" placeholder=""Email address"">
            <button class=""btn btn-primary pl-2"" type=""button"">Subscribe</button>
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
    </div>

    <div class=""d-flex justify-content-between py-4 my-4 border-top"">
      <p>© 2021 Company, Inc. All rights reserved.</p>
      <ul class=""list-unstyled d-flex"">
        <li class=""ms-3""><a class=""link-dark"" href=""#""><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#twitter""></use></svg></a></li>
        <li class=""ms-3""><a class=""link-dark"" href=""#""><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#instagram""></use></svg></a></li>
        <li class=""ms-3""><a class=""link-dark"" href=""#""><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#facebook""></use></svg></a></li>
      </ul>
    </div>
  </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591