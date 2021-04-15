#pragma checksum "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f43ddc8b6707c9dfd300d7d2209f01ac25f7663"
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
using MbmStore.Models.ViewModels;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f43ddc8b6707c9dfd300d7d2209f01ac25f7663", @"/Views/Catalogue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af7181267169422e276273a091f7fc1f46a98ad", @"/_ViewImports.cshtml")]
    public class Views_Catalogue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
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
            WriteLiteral("<div class=\"products\" style=\"clear:both\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
     if (Model.Products.OfType<Book>().ToList().Count > 0)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>The Books</h2>\r\n");
#nullable restore
#line 15 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (Book book in Model.Products.OfType<Book>().ToList())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
       Write(await Html.PartialAsync("_ProductSummaryBook", book));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
                                                                 ;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
     if (Model.Products.OfType<MusicCd>().ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>The CDs</h2>\r\n");
#nullable restore
#line 24 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (MusicCd cd in Model.Products.OfType<MusicCd>().ToList())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
       Write(await Html.PartialAsync("_ProductSummaryMusicCD", cd));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
                                                                  ;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 31 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
     if (Model.Products.OfType<Movie>().ToList().Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>The Movies</h2>\r\n");
#nullable restore
#line 34 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
         foreach (Movie movie in Model.Products.OfType<Movie>().ToList())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
       Write(await Html.PartialAsync("_ProductSummaryMovie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
                                                                   ;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div");
            BeginWriteAttribute("page-model", " page-model=\"", 1051, "\"", 1081, 1);
#nullable restore
#line 42 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1064, Model.PagingInfo, 1064, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-action=\"Index\" page-classes-enabled=\"true\" page-class=\"btn\" page-class-normal=\"btn-secondary\"\r\n     page-class-selected=\"btn-primary\"");
            BeginWriteAttribute("page-url-category", " page-url-category=\"", 1221, "\"", 1263, 1);
#nullable restore
#line 43 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Catalogue\Index.cshtml"
WriteAttributeValue("", 1241, Model.CurrentCategory, 1241, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n     class=\"btn-group pull-right m-1\">\r\n</div>");
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
