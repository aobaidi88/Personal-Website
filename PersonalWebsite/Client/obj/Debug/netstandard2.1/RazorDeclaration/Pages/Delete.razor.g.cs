// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonalWebsite.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using PersonalWebsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using PersonalWebsite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\Delete.razor"
using PersonalWebsite.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete/{eduID}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\Delete.razor"
       

    [Parameter]
    public string eduID { get; set; }

    Education edu = new Education();

    protected async override Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        edu = await Http.GetFromJsonAsync<Education>("api/Educations/" + eduID);
    }

    protected async Task DeleteEdu()
    {
        await Http.DeleteAsync("/api/Educations/" + eduID);
        NavigationManager.NavigateTo("resume");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("resume");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
