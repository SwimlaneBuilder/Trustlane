#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4804e12bf9e3aa6ee6f376d0b0bef3a17f7d68c7"
// <auto-generated/>
#pragma warning disable 1591
namespace trustlaneweb.Pages.Tools.Trustlane
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using trustlaneweb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    public partial class LaneChange : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\n*Just a demo... setting up connectivity and tests. nothing of value here, CICD overwrites everything... :) *\r\n");
            __builder.AddMarkupContent(1, "<h3>Lane Change</h3>\r\n\r\ntodo: find companies and implied regulations if new at craft.co https://docs.craft.co/company-data-api/getting-started\r\n");
            __builder.AddMarkupContent(2, "<div>\r\n    Compare the standards, and (future) implementation details of two different standards and find a way to unite those needs\r\n</div>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "control_wrapper");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfMultiSelect<string[]>>(9);
            __builder.AddAttribute(10, "Placeholder", "Select countries");
            __builder.AddAttribute(11, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
                                                                                     Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "AllowCustomValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.DropDowns.VisualMode>(
#nullable restore
#line 12 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
                                                                                                                             VisualMode.Box

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.MultiSelectFieldSettings>(16);
                __builder2.AddAttribute(17, "Text", "Name");
                __builder2.AddAttribute(18, "Value", "Code");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "control_wrapper");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfMultiSelect<string[]>>(29);
            __builder.AddAttribute(30, "Placeholder", "Select standards");
            __builder.AddAttribute(31, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
                                                                                     Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "AllowCustomValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.DropDowns.VisualMode>(
#nullable restore
#line 19 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
                                                                                                                             VisualMode.Box

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.MultiSelectFieldSettings>(36);
                __builder2.AddAttribute(37, "Text", "Name");
                __builder2.AddAttribute(38, "Value", "Code");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.AddMarkupContent(43, "<style>\r\n\r\n\r\n    .control_wrapper {\r\n        width: 350px;\r\n        margin: 0 auto;\r\n        padding-top: 70px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Tools/Trustlane/LaneChange.razor"
      
    public class Countries
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
    private List<Countries> Country = new List<Countries>
{
        new Countries() { Name = "Australia", Code = "AU" },
        new Countries() { Name = "Bermuda", Code = "BM" },
        new Countries() { Name = "Canada", Code = "CA" },
        new Countries() { Name = "Cameroon", Code = "CM" },
        new Countries() { Name = "Denmark", Code = "DK" },
        new Countries() { Name = "France", Code = "FR" },
        new Countries() { Name = "Finland", Code = "FI" },
        new Countries() { Name = "Germany", Code = "DE" },
        new Countries() { Name = "Greenland", Code = "GL" },
        new Countries() { Name = "Hong Kong", Code = "HK" },
        new Countries() { Name = "India", Code = "IN" },
        new Countries() { Name = "Italy", Code = "IT" },
        new Countries() { Name = "Japan", Code = "JP" },
        new Countries() { Name = "Mexico", Code = "MX" },
        new Countries() { Name = "Norway", Code = "NO" },
        new Countries() { Name = "Poland", Code = "PL" },
        new Countries() { Name = "Switzerland", Code = "CH" },
        new Countries() { Name = "United Kingdom", Code = "GB" },
        new Countries() { Name = "United States", Code = "US" },
    };
    private List<Countries> Standards = new List<Countries>
{
        new Countries() { Name = "Cloud Standard 1", Code = "CS1" },
        new Countries() { Name = "HIPAA", Code = "HIPAA" },
        new Countries() { Name = "COPPA", Code = "COPPA" },

    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591