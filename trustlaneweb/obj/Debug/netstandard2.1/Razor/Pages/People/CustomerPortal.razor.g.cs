#pragma checksum "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/CustomerPortal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427b30648609c437cdd1f92a325e28cd51517b8e"
// <auto-generated/>
#pragma warning disable 1591
namespace trustlaneweb.Pages.People
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
#line 1 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/CustomerPortal.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
    public partial class CustomerPortal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Component1</h3>\r\n\r\n");
            __Blazor.trustlaneweb.Pages.People.CustomerPortal.TypeInference.CreateSfListView_0(__builder, 1, 2, "nestedlist", 3, 
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/CustomerPortal.razor"
                                               ListData

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/CustomerPortal.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            , 5, "Folder", 6, 
#nullable restore
#line 5 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/CustomerPortal.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Lists.ListViewFieldSettings>(9);
                __builder2.AddAttribute(10, "Id", "Id");
                __builder2.AddAttribute(11, "Text", "Text");
                __builder2.AddAttribute(12, "Child", "Child");
                __builder2.AddAttribute(13, "IconCss", "Icon");
                __builder2.AddAttribute(14, "Tooltip", "Text");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n");
            }
            );
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.AddMarkupContent(17, @"<style>

    .e-listview .e-list-icon {
        height: 24px;
        width: 30px;
    }

    .folder {
        background-repeat: no-repeat;
        background-image: url(""css/listview/images/file_icons.png"");
        background-position: -5px -466px;
        background-size: 302%;
    }

    .file {
        background-repeat: no-repeat;
        background-image: url(""css/listview/images/file_icons.png"");
        background-position: -5px -151px;
        background-size: 302%;
    }

    .nestedlist {
        max-width: 500px;
        margin: auto;
        border: 1px solid #dddddd;
        border-radius: 3px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Users/trust1/GitHub/Trustlane/trustlaneweb/Pages/People/CustomerPortal.razor"
       
            List<DataModel> ListData = new List<DataModel>();
            class DataModel
            {
                public string Id { get; set; }
                public string Text { get; set; }
                public string Icon { get; set; }
                public List<DataModel> Child { get; set; }
            }
            protected override void OnInitialized()
        {
            base.OnInitialized();
            ListData.Add(new DataModel
            {
                Id = "01",
                Text = "Classroom1",
                Icon = "folder",
                Child = new List<DataModel>() { 
                        new DataModel { Id= "01-01", Text= "Field Trip Parent Signature", Icon= "file" },
                        new DataModel { Id= "01-02", Text= "Current Grade", Icon= "file" },
                        new DataModel { Id= "01-03", Text= "Parental Notes", Icon= "file" },
                        new DataModel { Id= "01-04", Text= "Allergies", Icon= "file" },
                        new DataModel { Id= "01-05", Text= "Emergency Contact", Icon= "file" },
                        }
                });
        ListData.Add(new DataModel
        {
            Id = "02",
            Text = "Classroom2",
            Icon = "folder",
            Child = new List<DataModel>() {
                    new DataModel { Id= "02-01", Text= "Field Trip Parent Signature", Icon= "file" },
                    new DataModel { Id= "02-02", Text= "Current Grade", Icon= "file" },
                    new DataModel { Id= "02-03", Text= "Parental Notes", Icon= "file" },
                    new DataModel { Id= "02-04", Text= "Allergies", Icon= "file" },
                    new DataModel { Id= "02-05", Text= "Emergency Contact", Icon= "file" },
                }
        });
        ListData.Add(new DataModel
        {
            Id = "03",
            Text = "Sports Club",
            Icon = "folder",
            Child = new List<DataModel>() {
                   new DataModel { Id= "03-01", Text= "Checklist items", Icon= "file" },
                   new DataModel { Id= "03-02", Text= "Team Roster Notes", Icon= "file" },
                   new DataModel { Id= "03-03", Text= "Signed Waver", Icon= "file" },
                   new DataModel { Id= "03-04", Text= "Contact Info - Emergency", Icon= "file" },
                   new DataModel { Id= "03-05", Text= "Contact Info - General", Icon= "file" }
                }
        });
        ListData.Add(
            new DataModel
            {
                Id = "04",
                Text = "Family",
                Icon = "folder",
                Child = new List<DataModel>() {
                new DataModel { Id= "04-01", Text= "Joe Smith", Icon= "folder", Child= new List<DataModel>() {
                    new DataModel { Id= "04-01-01", Text= "Medical Card", Icon= "file" },
                    new DataModel { Id= "04-01-02", Text= "Allergies", Icon= "file" },
                    new DataModel { Id= "04-01-03", Text= "", Icon= "file" } }
                },

                new DataModel { Id= "04-02", Text= "Person2", Icon= "folder", Child= new List<DataModel>() {
                    new DataModel { Id= "04-02-01", Text= "WIN_20160726_094117.JPG", Icon= "file" },
                    new DataModel { Id= "04-02-02", Text= "WIN_20160726_094118.JPG", Icon= "file" },
                    new DataModel { Id= "04-02-03", Text= "WIN_20160726_094119.JPG", Icon= "file" } }
                },

                new DataModel { Id= "04-03", Text= "Person3", Icon= "folder", Child= new List<DataModel>() {
                    new DataModel { Id= "04-03-01", Text= "WIN_20160726_094117.JPG", Icon= "file" },
                    new DataModel { Id= "04-03-02", Text= "WIN_20160726_094118.JPG", Icon= "file" },
                    new DataModel { Id= "04-03-03", Text= "WIN_20160726_094119.JPG", Icon= "file" } }
                },

                new DataModel { Id= "04-04", Text= "Person4", Icon= "folder", Child= new List<DataModel>() {
                    new DataModel { Id= "04-04-01", Text= "WIN_20160726_094117.JPG", Icon= "file" },
                    new DataModel { Id= "04-04-02", Text= "WIN_20160726_094118.JPG", Icon= "file" },
                    new DataModel { Id= "04-04-03", Text= "WIN_20160726_094119.JPG", Icon= "file" } }
                },


       }
            });

        ListData.Add(
            new DataModel
            {
                Id = "05",
                Text = "Neighbors",
                Icon = "folder",
                Child = new List<DataModel>() {
                new DataModel { Id= "05-01", Text= "UI-Guide.pdf", Icon= "file" },
                new DataModel { Id= "05-02", Text= "Tutorials.zip", Icon= "file" },
                new DataModel { Id= "05-03", Text= "Game.exe", Icon= "file" },
                new DataModel { Id= "05-04", Text= "TypeScript.7z", Icon= "file" }, }
            });
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.trustlaneweb.Pages.People.CustomerPortal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfListView_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Lists.SfListView<TValue>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "ShowHeader", __arg2);
        __builder.AddAttribute(__seq3, "HeaderTitle", __arg3);
        __builder.AddAttribute(__seq4, "ShowIcon", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591