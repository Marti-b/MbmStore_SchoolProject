#pragma checksum "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378161ec58ce4601bf92881a558a60836cdd7144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 2 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\_ViewImports.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378161ec58ce4601bf92881a558a60836cdd7144", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af7181267169422e276273a091f7fc1f46a98ad", @"/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .nav {
        background-color: #333;
        overflow: hidden;
    }

        .nav a {
            float: left;
            color: #f2f2f2;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
            font-size: 17px;
        }

            .nav a:hover {
                background-color: #ddd;
                color: black;
            }

            .nav a.active {
                background-color: #4CAF50;
                color: white;
            }
</style>
<div class=""nav"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "378161ec58ce4601bf92881a558a60836cdd71444581", async() => {
                WriteLiteral(" Back to Home page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<h2>");
#nullable restore
#line 36 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.JungleBook.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>Price: ");
#nullable restore
#line 37 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
     Write(String.Format("{0:0.00}", ViewBag.JungleBook.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><img");
            BeginWriteAttribute("src", " src=\"", 868, "\"", 915, 2);
            WriteAttributeValue("", 874, "/Images/", 874, 8, true);
#nullable restore
#line 38 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 882, ViewBag.JungleBook.ImageFileName, 882, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 916, "\"", 947, 1);
#nullable restore
#line 38 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 922, ViewBag.JungleBook.Title, 922, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n\r\n<h2>");
#nullable restore
#line 40 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.TheDarkKnight.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>Price: ");
#nullable restore
#line 41 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
     Write(String.Format("{0:0.00}", ViewBag.TheDarkKnight.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><img src=\"Images/dark-knight\" /></p>\r\n\r\n<h2>");
#nullable restore
#line 44 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
Write(ViewBag.ForrestGump.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>Price:  ");
#nullable restore
#line 45 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Movie\Index.cshtml"
      Write(String.Format("{0:0.00}", ViewBag.ForrestGump.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><img src=\"Images/forrest-gump.jpg\" /></p>");
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
