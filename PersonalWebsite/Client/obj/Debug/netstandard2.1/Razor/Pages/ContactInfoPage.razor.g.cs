#pragma checksum "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d22515629786e56961b32a7186d6fb8c554c794e"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonalWebsite.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using PersonalWebsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\_Imports.razor"
using PersonalWebsite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
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
            __builder.AddMarkupContent(0, "<h3 class=\"oi oi-envelope-open\">Contact Me</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<label for=\"fname\">First Name</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "fname");
            __builder.AddAttribute(8, "name", "firstname");
            __builder.AddAttribute(9, "placeholder", "Enter Your name..");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                                                                          contactInfo.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.FirstName = __value, contactInfo.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.AddMarkupContent(13, "<label for=\"lname\">Last Name</label>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "id", "lname");
            __builder.AddAttribute(17, "name", "lastname");
            __builder.AddAttribute(18, "placeholder", "Enter Your last name..");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                                                                              contactInfo.lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.lastName = __value, contactInfo.lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.AddMarkupContent(22, "<label for=\"email\">Email</label>\r\n    ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "id", "email");
            __builder.AddAttribute(26, "name", "email");
            __builder.AddAttribute(27, "placeholder", "Enter Your Email..");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                                                                       contactInfo.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.Email = __value, contactInfo.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.AddMarkupContent(31, "<label for=\"country\">Country</label>\r\n    ");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "id", "country");
            __builder.AddAttribute(34, "name", "country");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "usa");
            __builder.AddContent(38, "USA");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "australia");
            __builder.AddContent(42, "Australia");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "option");
            __builder.AddAttribute(45, "value", "canada");
            __builder.AddContent(46, "Canada");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 23 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
         foreach (var request in RequestType)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "            ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "radio");
            __builder.AddAttribute(54, "name", "RequestType");
            __builder.AddAttribute(55, "value", 
#nullable restore
#line 25 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                                           request

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                                                               OnChangeRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "label");
            __builder.AddAttribute(59, "for", 
#nullable restore
#line 26 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                         request

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, 
#nullable restore
#line 26 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                   request

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 27 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "div");
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "label");
            __builder.AddMarkupContent(67, "\r\n            Web App:\r\n            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "checkbox");
            __builder.AddAttribute(70, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                          contactInfo.IsWebApp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.IsWebApp = __value, contactInfo.IsWebApp));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "div");
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenElement(77, "label");
            __builder.AddMarkupContent(78, "\r\n            Phone App:\r\n            ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "checkbox");
            __builder.AddAttribute(81, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                         contactInfo.IsPhoneApp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.IsPhoneApp = __value, contactInfo.IsPhoneApp));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.OpenElement(86, "div");
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "label");
            __builder.AddMarkupContent(89, "\r\n            Windows App:\r\n            ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "checkbox");
            __builder.AddAttribute(92, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                         contactInfo.IsWindows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.IsWindows = __value, contactInfo.IsWindows));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.AddMarkupContent(97, "<label for=\"subject\">Subject</label>\r\n    ");
            __builder.OpenElement(98, "textarea");
            __builder.AddAttribute(99, "id", "subject");
            __builder.AddAttribute(100, "name", "subject");
            __builder.AddAttribute(101, "placeholder", "Write something..");
            __builder.AddAttribute(102, "style", "height:200px");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                                                                                                      contactInfo.Comments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contactInfo.Comments = __value, contactInfo.Comments));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n    ");
            __builder.OpenElement(106, "button");
            __builder.AddAttribute(107, "type", "submit");
            __builder.AddAttribute(108, "value", "Submit");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                        () => Submit()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(110, "\r\n        Submit\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "type", "submit");
            __builder.AddAttribute(114, "value", "Submit");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
                        () => reset()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(116, "\r\n        Reset\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n");
            __builder.AddMarkupContent(119, "<footer id=\"copyR\"> &copy; Obaidi Site 2020</footer>\r\n\r\n");
            __builder.AddMarkupContent(120, @"<style>
    input[type=radio] {
        border-radius: 4px;
    }

    input[type=text], select, textarea {
        width: 100%; /* Full width */
        padding: 12px; /* Some padding */
        border: 1px solid #ccc; /* Gray border */
        border-radius: 4px; /* Rounded borders */
        box-sizing: border-box; /* Make sure that padding and width stays in place */
        margin-top: 6px; /* Add a top margin */
        margin-bottom: 16px; /* Bottom margin */
        resize: vertical /* Allow the user to vertically resize the textarea (not horizontally) */
    }


    input[type=submit] {
        background-color: #4CAF50;
        color: white;
        padding: 12px 20px;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }


        input[type=submit]:hover {
            background-color: #45a049;
        }


    .container {
        border-radius: 5px;
        background-color: #CCCCCC;
        padding: 20px;
    }

    header {
        font-family: ""Candara"";
        font-size: 22px;
        text-align: left;
        background-color: #CDAA3A;
    }

    body {
        background-color: #ACACAC;
    }

    footer {
        position: fixed;
        bottom: 0;
        right: 0;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "D:\C#\C#_.NET II\Projects\ObaidiP6\PersonalWebsite\PersonalWebsite\Client\Pages\ContactInfoPage.razor"
       

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