#pragma checksum "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a9a22f228f4136df47f7a2aa8604f8ddf0551e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContactManager.Pages
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
#line 1 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\_ViewImports.cshtml"
using ContactManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\_ViewImports.cshtml"
using ContactManager.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\_ViewImports.cshtml"
using ContactManager.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\_ViewImports.cshtml"
using ContactManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a9a22f228f4136df47f7a2aa8604f8ddf0551e5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633203b8c7f7895d264087e8e2a472a566765785", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
