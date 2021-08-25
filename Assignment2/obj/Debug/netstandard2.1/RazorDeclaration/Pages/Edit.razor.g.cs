// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit/{bcitId}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\ASP.NET\Assignment2\Assignment2\Pages\Edit.razor"
           

        private async void HandleUpdate()
        {
            int emailFormatLength=(student.FirstName.Substring(0, 1).ToLower() + char.ToLower(student.LastName[0]) + student.LastName.Substring(1)).Length;
            if (!(student.FirstName.Substring(0, 1).ToLower() + char.ToLower(student.LastName[0]) + student.LastName.Substring(1)).Equals(student.EmailAddress.Substring(0, emailFormatLength))) {
                student.EmailAddress = generateEmail(student.FirstName, student.LastName);
            }
            student.FirstName = capitalizeFirstLetter(student.FirstName.Trim());
            student.LastName = capitalizeFirstLetter(student.LastName.Trim());
            student.City = capitalizeFirstLetter(student.City.Trim());
            student.Specialization = capitalizeFirstLetter(student.Specialization.Trim());

            string endpoint = $"{baseUrl}api/students/{student.BcitId}";

            await httpClient.PutAsJsonAsync(endpoint, student);

            //await load();
            Navigation.NavigateTo("/", true);
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ASP.NET\Assignment2\Assignment2\Pages\Edit.razor"
       
    [Parameter]
    public string BcitId { get; set; }

    Student student;
    Student[] students;
    string baseUrl = "http://localhost:5000/";

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        students = await httpClient.GetFromJsonAsync<Student[]>($"{baseUrl}api/students");
        student = await httpClient.GetFromJsonAsync<Student>($"{baseUrl}api/students/{BcitId}");
    }

    protected string capitalizeFirstLetter(string input)
    {
        return char.ToUpper(input[0]) + input.Substring(1);
    }

    protected String generateEmail(string firstName, string lastName)
    {
        string email = firstName.Substring(0, 1).ToLower() + char.ToLower(lastName[0]) + lastName.Substring(1) + "@bcit.ca";
        while (emailExist(email))
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 1000);
            email = firstName.Substring(0, 1).ToLower() + char.ToLower(lastName[0]) + lastName.Substring(1)+ randomNumber + "@bcit.ca";         
        }
        return email;
    }

    protected bool emailExist(string email)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].EmailAddress.Equals(email))
            {
                return true;
            }
        }
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591