#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Compliance/DocViewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a57864de7d788373859e0c1532dcc7af71875f9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace trustlaneweb.Pages.Compliance
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
#line 11 "/Users/trust1/GitHub/Trustlane/trustlaneweb/_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Compliance/DocViewer.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Compliance/DocViewer.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
    public partial class DocViewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/Compliance/DocViewer.razor"
      
    Type models = typeof(RevisionData);
    public class RevisionData
    {
        public DateTime ChangeDate { get; set; }
        public Double Changes { get; set; }
        public string Editor { get; set; }
        public string EmployeeID { get; set; }
        public string Designation { get; set; }
        public string Country { get; set; }
    }
    List<RevisionData> Data = new List<RevisionData>
{
        new RevisionData() { ChangeDate = new DateTime(2018, 8, 8), Changes  = 0.7,  Editor = "Andrew Fuller", EmployeeID = "1", Designation = "Team Lead", Country = "England"  },
        new RevisionData() { ChangeDate = new DateTime(2019, 4, 10), Changes  = 0.2,Editor = "Anne Dodsworth", EmployeeID = "2", Designation = "Developer", Country = "USA" },
        new RevisionData() { ChangeDate = new DateTime(2020, 12, 7), Changes  = 0.1,Editor = "Janet Leverling", EmployeeID = "3", Designation = "HR", Country = "USA" },
        new RevisionData() { ChangeDate = new DateTime(2018, 2, 8), Changes  = 0.2,Editor = "Laura Callahan", EmployeeID = "4", Designation = "Product Manager", Country = "USA" },
        new RevisionData() { ChangeDate = new DateTime(2015, 4, 9), Changes  = 1,Editor = "Margaret Peacock", EmployeeID = "5", Designation = "Developer", Country = "USA" },
    };

    // Document markdown tools
    private object[] Tools = new object[] {
        "Bold", "Italic", "StrikeThrough", "|",
        "Formats", "OrderedList", "UnorderedList", "|",
        "CreateLink", "Image", "CreateTable", "|", "Undo", "Redo"
    };
    private string Format = "new sf.richtexteditor.MarkdownFormatter({ 'listTags': { 'OL': '1., 2., 3.' } })";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591