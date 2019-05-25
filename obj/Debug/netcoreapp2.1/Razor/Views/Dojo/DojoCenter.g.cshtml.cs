#pragma checksum "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa3280599e51d3efd231dd9eba71ae24615af9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dojo_DojoCenter), @"mvc.1.0.view", @"/Views/Dojo/DojoCenter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dojo/DojoCenter.cshtml", typeof(AspNetCore.Views_Dojo_DojoCenter))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\_ViewImports.cshtml"
using DojoActivities;

#line default
#line hidden
#line 2 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\_ViewImports.cshtml"
using DojoActivities.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa3280599e51d3efd231dd9eba71ae24615af9a", @"/Views/Dojo/DojoCenter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caae22f2c2413f09a4a2872d9b844de96628f66f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dojo_DojoCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoActivity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 333, true);
            WriteLiteral(@"
<nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-primary"">
    <h1 class=""navbar-brand"" style=""font-size: 2.5em; padding-left: 2.5%;"">Dojo Activity Center</h1>
    <div class=""form-inline my-2 my-lg-0"" style=""padding-right: 2.5%; display: flex; justify-content: flex-end;"">
        <h2 class=""navbar-brand"">Welcome, ");
            EndContext();
            BeginContext(355, 17, false);
#line 6 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                                     Write(ViewBag.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(372, 431, true);
            WriteLiteral(@"</h2>
        <a href=""/logout"" style=""margin-top: 3%;""><button class=""btn btn-info"">Logout</button></a>
    </div>
</nav>
<hr style=""height: 2px; background-color: #337ab7; border: none;"">

<table class=""table table-striped"">
    <tr>
        <th>Activity</th>
        <th>Date & Time</th>
        <th>Duration</th>
        <th>Coordinator</th>
        <th># of Participants</th>
        <th>Actions</th>
    </tr>
");
            EndContext();
#line 21 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
     foreach (var a in ViewBag.Activities)
    {
        if(a.Date >= DateTime.Now)
        {

#line default
#line hidden
            BeginContext(901, 32, true);
            WriteLiteral("        <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 933, "\"", 967, 2);
            WriteAttributeValue("", 940, "/activityInfo/", 940, 14, true);
#line 26 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
WriteAttributeValue("", 954, a.ActivityId, 954, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(968, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(970, 7, false);
#line 26 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                                                 Write(a.Title);

#line default
#line hidden
            EndContext();
            BeginContext(977, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(1005, 26, false);
#line 27 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
           Write(a.Date.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1033, 25, false);
#line 27 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                                       Write(a.Time.ToString("@HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1082, 10, false);
#line 28 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
           Write(a.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1094, 14, false);
#line 28 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                       Write(a.DurationUnit);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1132, 18, false);
#line 29 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
           Write(a.Coordinator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1174, 25, false);
#line 30 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
           Write(a.UserParticipating.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 32 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                  
                    bool isGoing = false;
                    foreach(var p in a.UserParticipating)
                    {
                        if(p.UserId == ViewBag.User.UserId)
                        {
                            isGoing = true;
                            break;
                        }
                    }
                    if(a.CoordinatorId == ViewBag.User.UserId)
                    {

#line default
#line hidden
            BeginContext(1675, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1701, "\"", 1729, 2);
            WriteAttributeValue("", 1708, "/delete/", 1708, 8, true);
#line 44 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
WriteAttributeValue("", 1716, a.ActivityId, 1716, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1730, 43, true);
            WriteLiteral(" class=\"btn btn-danger btn-xs\">Delete</a>\r\n");
            EndContext();
#line 45 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                    }
                    else if(isGoing)
                    {

#line default
#line hidden
            BeginContext(1857, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1883, "\"", 1910, 2);
            WriteAttributeValue("", 1890, "/leave/", 1890, 7, true);
#line 48 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
WriteAttributeValue("", 1897, a.ActivityId, 1897, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1911, 44, true);
            WriteLiteral(" class=\"btn btn-warning btn-xs\">Leave</a> \r\n");
            EndContext();
#line 49 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2027, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2053, "\"", 2079, 2);
            WriteAttributeValue("", 2060, "/join/", 2060, 6, true);
#line 52 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
WriteAttributeValue("", 2066, a.ActivityId, 2066, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2080, 45, true);
            WriteLiteral(" class=\"btn btn-primary btn-xs\">Join</a>   \r\n");
            EndContext();
#line 53 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2167, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Zheng\Onedrive\Desktop\Coding_Dojo\CSharp_DotNet\AspDotnet\CSharpBeltExam\DojoActivities\Views\Dojo\DojoCenter.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2219, 82, true);
            WriteLiteral("</table>\r\n\r\n\r\n<a href=\"/activity/new\" class=\"btn btn-info\">Create an Activitiy</a>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoActivity> Html { get; private set; }
    }
}
#pragma warning restore 1591