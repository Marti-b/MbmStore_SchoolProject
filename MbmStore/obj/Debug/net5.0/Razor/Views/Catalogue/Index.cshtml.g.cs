#pragma checksum "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f612af08dddb01b1b48595453be7f934d481d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_Index), @"mvc.1.0.view", @"/Views/Catalogue/Index.cshtml")]
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
#line 3 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\_ViewImports.cshtml"
using MbmStore.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
using MbmStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f612af08dddb01b1b48595453be7f934d481d0", @"/Views/Catalogue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f52962527013bec81c0ca3d849f083b97b3cd3", @"/_ViewImports.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"nav\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f612af08dddb01b1b48595453be7f934d481d04339", async() => {
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
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"padding: 25px\">\r\n");
#nullable restore
#line 14 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
     if (Model.Products.OfType<Book>().ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>The Books</h2>\r\n        <table>\r\n");
#nullable restore
#line 18 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (Book book in Model.Products.OfType<Book>().ToList())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
           Write(await Html.PartialAsync("_ProductSummaryBook", book));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
                                                                     ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 23 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
     if (Model.Products.OfType<Movie>().ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>The Movies</h2>\r\n        <table>\r\n");
#nullable restore
#line 29 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (Movie movie in Model.Products.OfType<Movie>().ToList())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
           Write(await Html.PartialAsync("_ProductSummaryMovie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
                                                                       ;

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 35 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
     if (Model.Products.OfType<MusicCd>().ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>The Music Cds</h2>\r\n        <table>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
             foreach (MusicCd musicCd in Model.Products.OfType<MusicCd>().ToList())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
           Write(await Html.PartialAsync("_ProductSummaryMusicCd", musicCd));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
                                                                           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 47 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("page-model", " page-model=\"", 1308, "\"", 1338, 1);
#nullable restore
#line 48 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1321, Model.PagingInfo, 1321, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-action=\"Index\"\r\n         page-classes-enabled=\"true\"\r\n         page-class=\"btn\" page-class-normal=\"btn-secondary\"\r\n         page-class-selected=\"btn-primary\"");
            BeginWriteAttribute("page-url-category", " page-url-category=\"", 1502, "\"", 1544, 1);
#nullable restore
#line 51 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1522, Model.CurrentCategory, 1522, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n         class=\"btn-group pull-right m-1\">></div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
