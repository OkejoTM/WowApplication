#pragma checksum "C:\Users\tikom\source\Kursovaya\WowApplication\WowApplication\Views\Faction\RatedStartLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4da29cf2389da890deb67eca206b37976c36da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faction_RatedStartLocation), @"mvc.1.0.view", @"/Views/Faction/RatedStartLocation.cshtml")]
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
#line 1 "C:\Users\tikom\source\Kursovaya\WowApplication\WowApplication\Views\_ViewImports.cshtml"
using WowApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tikom\source\Kursovaya\WowApplication\WowApplication\Views\_ViewImports.cshtml"
using WowApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4da29cf2389da890deb67eca206b37976c36da", @"/Views/Faction/RatedStartLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9afd107d416c3f936ede078b7c3369d457045ffe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Faction_RatedStartLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RaceModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Самая популярная начальная локация с названием фракции</h1>\r\n\r\n<div>\r\n    <h4>Название стартовой локации:</h4>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\tikom\source\Kursovaya\WowApplication\WowApplication\Views\Faction\RatedStartLocation.cshtml"
  Write(Model.StartLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div>\r\n    <h4>Название фракции:</h4>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\tikom\source\Kursovaya\WowApplication\WowApplication\Views\Faction\RatedStartLocation.cshtml"
  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n<a href=\"/Faction/Factions\" class=\"btn btn-secondary\">Вернуться</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RaceModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591