#pragma checksum "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22fe9cfb807a4eae19c5efe4eb99a6257f45b120"
// <auto-generated/>
#pragma warning disable 1591
namespace SQLAoW.UI.Web.Shared
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
#line 10 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\_Imports.razor"
using SQLAoW.UI.Web.Extensions;

#line default
#line hidden
#nullable disable
    public partial class Switch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "custom-control custom-switch");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 2 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
     if (IsReadonly)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "checkbox");
            __builder.AddAttribute(6, "class", "custom-control-input");
            __builder.AddAttribute(7, "id", "customSwitch1");
            __builder.AddAttribute(8, "checked", 
#nullable restore
#line 4 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
                                                                                         IsChecked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "disabled", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 5 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "checkbox");
            __builder.AddAttribute(14, "class", "custom-control-input");
            __builder.AddAttribute(15, "id", "customSwitch1");
            __builder.AddAttribute(16, "checked", 
#nullable restore
#line 8 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
                                                                                         IsChecked

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 9 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 11 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
     if (ShowText)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "class", "custom-control-label");
            __builder.AddAttribute(22, "for", "customSwitch1");
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
                                                                  IsChecked?"Yes":"No"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 14 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\ooztu\source\repos\github\SQLAgentOnWings\SQLAoW\SQLAoW.UI.Web\Shared\Switch.razor"
       
    [Parameter] public bool IsChecked { get; set; } = false;
    [Parameter] public bool ShowText { get; set; } = true;
    [Parameter] public bool IsReadonly { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
