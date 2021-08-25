#pragma checksum "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2d72b453cb7b234d1217ece866299c74f608f9"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using Assignment2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASP.NET\Assignment2\Assignment2\_Imports.razor"
using StudentLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Henry Wang\'s BCIT Students</h1>");
#nullable restore
#line 6 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
 if (students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<form action=\"/add\"><button class=\"btn btn-success\">Add Student</button></form>\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "<thead><tr><th>First Name</th>\r\n                <th>Last Name</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 23 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
             foreach (var item in students)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 26 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 27 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(17, "href", "/edit/" + (
#nullable restore
#line 28 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
                                                                   item.BcitId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(23, "href", "/delete/" + (
#nullable restore
#line 29 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
                                                                    item.BcitId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\ASP.NET\Assignment2\Assignment2\Pages\Index.razor"
       
    Student[] students;
    string baseUrl = "http://localhost:5000/";

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        students = await httpClient.GetFromJsonAsync<Student[]>($"{baseUrl}api/students");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
