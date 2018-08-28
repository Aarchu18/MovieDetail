#pragma checksum "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8ab3dde2f8c02b15861e09ed9778df7fa5a43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie__MovieDetailPartial), @"mvc.1.0.view", @"/Views/Movie/_MovieDetailPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/_MovieDetailPartial.cshtml", typeof(AspNetCore.Views_Movie__MovieDetailPartial))]
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
#line 1 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\_ViewImports.cshtml"
using MovieDetail;

#line default
#line hidden
#line 2 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\_ViewImports.cshtml"
using MovieDetail.Models;

#line default
#line hidden
#line 1 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
using MovieDetail.Models.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8ab3dde2f8c02b15861e09ed9778df7fa5a43a", @"/Views/Movie/_MovieDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c172e4188d540b5c3ade64a63987d87d0de259", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie__MovieDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieList>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
  
    ViewData["Title"] = "MovieDetailPartial";

#line default
#line hidden
            BeginContext(237, 36, true);
            WriteLiteral("<h2>Movie Details</h2>\r\n\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(273, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9d3128b457140da8b6b6b2ad789a4ae", async() => {
                BeginContext(279, 82, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"movies\" />\r\n    <title>Movie Detail</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(368, 185, true);
            WriteLiteral("\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-success\" onclick=\"redirectOnClick()\">\r\n        <span class=\"glyphicon glyphicon-plus\"></span>\r\n        New Movie\r\n    </button>\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(553, 548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b984aa0a93a54337a8a95de09ddf2a3c", async() => {
                BeginContext(559, 229, true);
                WriteLiteral("\r\n    <table class=\"table table-bordered table-responsive table hover\">\r\n        <tr>\r\n            <th>MovieData</th>\r\n            <th>MovieName</th>\r\n            <th>ReleaseYear</th>\r\n            <th>Genere</th>\r\n        </tr>\r\n");
                EndContext();
#line 34 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
        foreach (var movieData in Model)
        {



#line default
#line hidden
                BeginContext(845, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(884, 17, false);
#line 39 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
               Write(movieData.MovieId);

#line default
#line hidden
                EndContext();
                BeginContext(901, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(929, 19, false);
#line 40 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
               Write(movieData.MovieName);

#line default
#line hidden
                EndContext();
                BeginContext(948, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(976, 21, false);
#line 41 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
               Write(movieData.ReleaseYear);

#line default
#line hidden
                EndContext();
                BeginContext(997, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1025, 16, false);
#line 42 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
               Write(movieData.Genere);

#line default
#line hidden
                EndContext();
                BeginContext(1041, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 44 "C:\Users\archana.kumari\Documents\Visual Studio 2017\Projects\MovieDetail\MovieDetail\Views\Movie\_MovieDetailPartial.cshtml"
        }

#line default
#line hidden
                BeginContext(1078, 16, true);
                WriteLiteral("\r\n    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1101, 19, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
