#pragma checksum "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ac577b9df6319de1aadc8841d7aa348a393ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Contacts.Pages_Contacts_Index), @"mvc.1.0.razor-page", @"/Pages/Contacts/Index.cshtml")]
namespace ContactManager.Pages.Contacts
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ac577b9df6319de1aadc8841d7aa348a393ea1", @"/Pages/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633203b8c7f7895d264087e8e2a472a566765785", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contacts_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5ac577b9df6319de1aadc8841d7aa348a393ea16127", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 41 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
         foreach (var item in Model.Contact)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 45 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 48 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 51 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 54 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 63 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 66 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                     if ((await AuthorizationService.AuthorizeAsync(
                     User, item,
                     ContactOperations.Update)).Succeeded)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5ac577b9df6319de1aadc8841d7aa348a393ea114149", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                                               WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral(" | ");
#nullable restore
#line 71 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5ac577b9df6319de1aadc8841d7aa348a393ea116813", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                                              WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 76 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                     if ((await AuthorizationService.AuthorizeAsync(
                     User, item,
                     ContactOperations.Delete)).Succeeded)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5ac577b9df6319de1aadc8841d7aa348a393ea119631", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                                                 WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 82 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 85 "C:\Users\dotexemx\Google Drive\Semestres (trabajos, proyectos, etc)\10mo Semestre (Ultimo)\PROGRAMACION WEB II\aplicacion con autenticacion\starter3\Pages\Contacts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactManager.Pages.Contacts.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactManager.Pages.Contacts.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactManager.Pages.Contacts.IndexModel>)PageContext?.ViewData;
        public ContactManager.Pages.Contacts.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591