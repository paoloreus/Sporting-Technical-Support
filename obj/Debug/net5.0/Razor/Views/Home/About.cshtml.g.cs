#pragma checksum "D:\WebDev\GBCSporting2021_TheDevelopers\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67df2c47099167dbe0b74eb094f665742326fd1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "D:\WebDev\GBCSporting2021_TheDevelopers\Views\_ViewImports.cshtml"
using GBCSporting2021_TheDevelopers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebDev\GBCSporting2021_TheDevelopers\Views\_ViewImports.cshtml"
using GBCSporting2021_TheDevelopers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67df2c47099167dbe0b74eb094f665742326fd1e", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61e4678161dafe4c34e24b53fc75ed45f686cebe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\WebDev\GBCSporting2021_TheDevelopers\Views\Home\About.cshtml"
  
    ViewBag.Title = "About";
    ViewBag.Heading = "About Our Team at SportsPro";
    ViewBag.Desc = "What do we do?";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67df2c47099167dbe0b74eb094f665742326fd1e3384", async() => {
                WriteLiteral(@"
    <div class=""wrap"">
        <main>

            <div class=""mainContents"">
                <div class=""container"">
                    <h2 class=""subHeading"">SportsPro Technical Support</h2>
                    <p class=""aboutText"">
                        SportsPro Technical Support thrives in providing excellent maintenance and customer
                        support for all your sport's related system. We are not only here to fix any software
                        or hardware related issues, but to provide exceptional customer service.
                    </p>
                    <br>
                    <p class=""aboutText""><b>We are here to ensure your technical support needs are met in an efficent and user-friendly way.</b></p>
                </div>
            </div>



            <div class=""container"">
                <div class=""row"">



                    <br />



                    <div class=""gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6 filter hdpe"">");
                WriteLiteral(@"
                        <img src=""img/new1.jpeg"" class=""img-responsive"">
                    </div>

                    <div class=""gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6 filter sprinkle"">
                        <img src=""img/new2.jpeg"" class=""img-responsive"">
                    </div>

                    <div class=""gallery_product col-lg-4 col-md-4 col-sm-4 col-xs-6 filter hdpe"">
                        <img src=""img/new3.jpeg"" class=""img-responsive"">
                    </div>


                </div>
            </div>
            </section>




        </main>
    </div>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
