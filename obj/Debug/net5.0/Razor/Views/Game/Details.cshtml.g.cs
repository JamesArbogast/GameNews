<<<<<<< HEAD
#pragma checksum "C:\Users\Myles\Desktop\GameNews\Views\Game\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47ecc9d3d836ac83fe51729985a68a064e80cb5"
=======
#pragma checksum "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e1f23e2a73a18e023028a709103bdea74031a2"
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Details), @"mvc.1.0.view", @"/Views/Game/Details.cshtml")]
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
#line 1 "C:\Users\Myles\Desktop\GameNews\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\_ViewImports.cshtml"
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662
using GameStock;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Myles\Desktop\GameNews\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\_ViewImports.cshtml"
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662
using GameStock.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\Myles\Desktop\GameNews\Views\_ViewImports.cshtml"
=======
#line 4 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\_ViewImports.cshtml"
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47ecc9d3d836ac83fe51729985a68a064e80cb5", @"/Views/Game/Details.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e1f23e2a73a18e023028a709103bdea74031a2", @"/Views/Game/Details.cshtml")]
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa2b54636d8232d89696a39571d575133222c6d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-left w-100 ml-5\">\r\n  <h1 class=\"display-3 font-italic\">");
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\Myles\Desktop\GameNews\Views\Game\Details.cshtml"
                               Write(Model.Platforms);
=======
#line 4 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
                   Write(Model.Name);
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\Myles\Desktop\GameNews\Views\Game\Details.cshtml"
                                                 Write(Model.Name);
=======
#line 7 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
WriteAttributeValue("", 159, Model.ImgUrl, 159, 13, false);
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <p>Created by: <em>");
#nullable restore
<<<<<<< HEAD
#line 5 "C:\Users\Myles\Desktop\GameNews\Views\Game\Details.cshtml"
                Write(Model.Creator);
=======
#line 9 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
    Write(Model.CurrentRating);
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></p>\r\n  <hr>\r\n  <div class=\"d-flex align-items-center justify-content-between p-3 shadow rounded\">\r\n      <img class=\"w-25 h-50 ml-5 mr-5\"");
            BeginWriteAttribute("src", " src=\"", 301, "\"", 320, 1);
#nullable restore
<<<<<<< HEAD
#line 8 "C:\Users\Myles\Desktop\GameNews\Views\Game\Details.cshtml"
WriteAttributeValue("", 307, Model.ImgUrl, 307, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"w-75 text-left ml-5 \">\r\n    <div>");
#nullable restore
#line 10 "C:\Users\Myles\Desktop\GameNews\Views\Game\Details.cshtml"
    Write(Model.CurrentRating);
=======
#line 10 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
    Write(Model.Creator);
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662

#line default
#line hidden
#nullable disable
            WriteLiteral(":</div>\r\n    <div>\r\n      <h3>Genres</h3>\r\n      <ul>\r\n");
            WriteLiteral("      </ul>\r\n    </div>\r\n    <div>\r\n      <h3>Platforms</h3>\r\n      <ul>\r\n");
            WriteLiteral("      </ul>\r\n    </div>\r\n    <h3>Vendors and Prices</h3>\r\n    <ul>\r\n");
            WriteLiteral("    </ul>\r\n    <ul>\r\n");
<<<<<<< HEAD
            WriteLiteral(@"    </ul>
  </div>
</div>
<hr>
<div class=""d-flex align-items-center"">
    <h1 class=""display-4 font-italic mr-5"">Reviews</h1>
    <div class=""w-75 ml-5 mr-5 d-flex justify-content-between"">
      <a href=""#"">On Release</a>
      <a href=""#"">s1</a>
      <a href=""#"">s2</a>
      <a href=""#"">s3</a>
      <a href=""#"">Current</a>
    </div>
</div>
<div class=""w-75"">
  <h3>Example Review</h3>
</div>
");
=======
            WriteLiteral("    </ul>\r\n    <ul>\r\n");
#nullable restore
#line 43 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
       foreach (var review in @ViewBag.GameReviews)
      {
        if(@Model.GameId == @review.GameId)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <li>\r\n            <div class=\"card-body\">\r\n              <p>Review by ");
#nullable restore
#line 49 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
                      Write(review.CreatedBy.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <p>");
#nullable restore
#line 50 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
            Write(review.GameRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <p>");
#nullable restore
#line 51 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
            Write(review.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n          </li>\r\n");
#nullable restore
#line 54 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <p>No reviews found.</p>\r\n");
#nullable restore
#line 58 "C:\Users\james\OneDrive\Desktop\coding_dojo\CSharp\GameStock\Views\Game\Details.cshtml"
        }
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n  </div>\r\n  <div class=\"card-body\">\r\n  </div>");
>>>>>>> 651d6ca0925d4ba3944424a5d1435cc057336662
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
