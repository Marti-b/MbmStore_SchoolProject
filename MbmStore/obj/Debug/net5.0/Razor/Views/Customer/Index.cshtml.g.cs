#pragma checksum "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0194dd778ec249527f96a56c0701a29898773188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0194dd778ec249527f96a56c0701a29898773188", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af7181267169422e276273a091f7fc1f46a98ad", @"/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customers";


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0194dd778ec249527f96a56c0701a298987731884034", async() => {
                WriteLiteral("Home");
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
            WriteLiteral("\r\n");
            WriteLiteral("    <h2>Customers</h2>\r\n");
#nullable restore
#line 9 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"

   
    foreach (Customer customer in ViewBag.Customers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 13 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
      Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
                          Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
      Write(customer.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
                    Write(customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n        <p>");
#nullable restore
#line 15 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
      Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is ");
#nullable restore
#line 15 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
                             Write(customer.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" years old</p>\r\n");
#nullable restore
#line 16 "C:\Users\marti\Dropbox\!DK_Webdev\GitHub\MbmStore_SchoolProject_Balazs Martikan\MbmStore\Views\Customer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
