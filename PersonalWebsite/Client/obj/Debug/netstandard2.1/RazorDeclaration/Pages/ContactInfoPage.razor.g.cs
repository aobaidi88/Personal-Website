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
#line 2 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
using PersonalWebsite.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contact")]
    public partial class ContactInfoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "I:\Git\interview\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
       

    private ContactInfo contactInfo = new ContactInfo();

    private string[] RequestType { get; set; } = new[] { "Quote", "General Message " };

    private void OnChangeRequest(ChangeEventArgs args)
    {
        contactInfo.TypeOfRequest = args.Value.ToString();
    }

    private async Task Submit()
    {
        await emailService.SendEmail(contactInfo);

        await emailService.AddEmail(contactInfo);
    }

    private void reset()
    {
        contactInfo.Comments = default;
        contactInfo.FirstName = default;
        contactInfo.lastName = default;
        RequestType = default;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmailService emailService { get; set; }
    }
}
#pragma warning restore 1591
