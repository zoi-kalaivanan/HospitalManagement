#pragma checksum "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bff2cfee608b8cd0f548579540d9409c4f91b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HospitalManagement_Home), @"mvc.1.0.view", @"/Views/HospitalManagement/Home.cshtml")]
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
#line 1 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\_ViewImports.cshtml"
using HospitalManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\_ViewImports.cshtml"
using HospitalManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bff2cfee608b8cd0f548579540d9409c4f91b29", @"/Views/HospitalManagement/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef1c247d703720d44e6420e2347a06863765dad", @"/Views/_ViewImports.cshtml")]
    public class Views_HospitalManagement_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HospitalManagement.Models.HospitalMgmtViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
  
    ViewData["Title"] = "Summary";  
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bff2cfee608b8cd0f548579540d9409c4f91b294879", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bff2cfee608b8cd0f548579540d9409c4f91b295141", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bff2cfee608b8cd0f548579540d9409c4f91b297023", async() => {
                WriteLiteral(@"
    <div class=""my-auto mt-4"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row d-flex justify-content-between"">
                        <div class=""col-4"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <div id=""div_male"">
                                                <h4>Doctors Count</h4>
                                            </div>
                                        </div>
                                        <div class=""col"">
                                            <div id=""div_doctor_count"" class=""text-primary"">
                                                <h1>");
#nullable restore
#line 26 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                               Write(Model.Count.DoctorsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-4"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <div id=""div_female"">
                                                <h4>Hospitals Count</h4>
                                            </div>
                                        </div>
                                        <div class=""col"">
                                            <div id=""div_hospital_count"" class=""text-success"">
                                                <h1>");
#nullable restore
#line 44 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                               Write(Model.Count.HospitalsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-4"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <div id=""div_female"">
                                                <h4>Patients Count</h4>
                                            </div>
                                        </div>
                                        <div class=""col"">
                                            <div id=""div_patient_count"" class=""text-success"">
                                                <h1>");
#nullable restore
#line 62 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                               Write(Model.Count.PatientsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""card mt-3"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <div");
                BeginWriteAttribute("id", " id=\"", 3785, "\"", 3790, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <h5>Top 10 Doctor List</h5>
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <div class=""card-body"">
                                                <div id=""div_doctor_list"" class=""text-warning"">
");
#nullable restore
#line 83 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                     foreach (var item in @Model.DoctorsList)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <div>\r\n                                                            ");
#nullable restore
#line 86 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                       Write(item.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            <hr />\r\n                                                        </div>\r\n");
#nullable restore
#line 89 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                    }                                                  

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col"">
                            <div class=""card mt-3"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <div");
                BeginWriteAttribute("id", " id=\"", 5353, "\"", 5358, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <h5>Top 10 Hospital List</h5>
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <div class=""card-body"">
                                                <div id=""div_hospital_list"" class=""text-warning"">
");
#nullable restore
#line 109 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                     foreach (var item in @Model.HospitalsList)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <div>\r\n                                                            ");
#nullable restore
#line 112 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                       Write(item.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            <hr />\r\n                                                        </div>\r\n");
#nullable restore
#line 115 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                    }                                                  

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col"">
                            <div class=""card mt-3"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <div");
                BeginWriteAttribute("id", " id=\"", 6927, "\"", 6932, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <h5>Top 10 Patients List</h5>
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <div class=""card-body"">
                                                <div id=""div_patient_list"" class=""text-warning"">
");
#nullable restore
#line 135 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                     foreach (var item in @Model.PatientsList)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <div>\r\n                                                            ");
#nullable restore
#line 138 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                       Write(item.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            <hr />\r\n                                                        </div>\r\n");
#nullable restore
#line 141 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
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
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bff2cfee608b8cd0f548579540d9409c4f91b2919585", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 157 "D:\Kalaivanan\Test\HospitalManagement\HospitalManagement\Views\HospitalManagement\Home.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalManagement.Models.HospitalMgmtViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591