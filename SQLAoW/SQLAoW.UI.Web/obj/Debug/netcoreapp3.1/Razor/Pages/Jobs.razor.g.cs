#pragma checksum "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54a89ab39accc0db76c4e053b08089e60b5d2466"
// <auto-generated/>
#pragma warning disable 1591
namespace SQLAoW.UI.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using SQLAoW.UI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using SQLAoW.UI.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
using SQLAoW.Infrastructure.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
using SQLAoW.Infrastructure.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/jobs")]
    public partial class Jobs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Jobs</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
 if (jobs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Enabled</th>\r\n                <th>Description</th>\r\n                <th>DateCreated</th>\r\n                <th>DateModified</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
             foreach (var job in jobs)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "title", "JobId:" + " " + (
#nullable restore
#line 30 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                                       job.JobId

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "Jobs/" + (
#nullable restore
#line 30 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                                                                 job.JobId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                                                                             job.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenComponent<SQLAoW.UI.Web.Shared.Switch>(21);
            __builder.AddAttribute(22, "IsChecked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                                            job.Enabled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "IsReadonly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                         job.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 35 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                         job.DateCreated.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 36 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
                         job.DateModified.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 38 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 41 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Pages\Jobs.razor"
       
    private IEnumerable<Job> jobs;

    protected override async Task OnInitializedAsync()
    {
        jobs = await QS.GetAll<Job>();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQueryService QS { get; set; }
    }
}
#pragma warning restore 1591