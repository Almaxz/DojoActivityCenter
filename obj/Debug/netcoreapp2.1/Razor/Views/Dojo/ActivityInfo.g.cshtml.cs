#pragma checksum "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c38f5cc2b1c537b8486a40f0f0501dc24800b76e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dojo_ActivityInfo), @"mvc.1.0.view", @"/Views/Dojo/ActivityInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dojo/ActivityInfo.cshtml", typeof(AspNetCore.Views_Dojo_ActivityInfo))]
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
#line 1 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\_ViewImports.cshtml"
using DojoActivities;

#line default
#line hidden
#line 2 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\_ViewImports.cshtml"
using DojoActivities.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c38f5cc2b1c537b8486a40f0f0501dc24800b76e", @"/Views/Dojo/ActivityInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caae22f2c2413f09a4a2872d9b844de96628f66f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dojo_ActivityInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoActivity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 652, true);
            WriteLiteral(@"
<nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-primary"">
    <h1 class=""navbar-brand"" style=""font-size: 2.5em; padding-left: 2.5%;"">Dojo Activity Center</h1>
    <div class=""form-inline my-2 my-lg-0"" style=""margin-top: 2.5%; padding-right: 2.5%; display: flex; justify-content: flex-end;"">
        <a href=""/dojocenter"" style=""margin-right: 2%;""><button class=""btn btn-info"">DojoCenter</button></a>
        <a href=""/logout""><button class=""btn btn-info"">Logout</button></a>
    </div>
</nav>
<hr style=""height: 2px; background-color: #337ab7; border: none;"">
<div style=""display: flex; justify-content: space-evenly;"">
    <h1>");
            EndContext();
            BeginContext(674, 24, false);
#line 12 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
   Write(ViewBag.Activities.Title);

#line default
#line hidden
            EndContext();
            BeginContext(698, 44, true);
            WriteLiteral("</h1>\r\n    <div style=\"margin-top: 2.5%;\">\r\n");
            EndContext();
#line 14 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
          
            bool isGoing = false;
            foreach(var p in ViewBag.Activities.UserParticipating)
            {
                if(p.UserId == ViewBag.Users)
                {
                    isGoing = true;
                    break;
                } 
            }
            if(ViewBag.Activities.CoordinatorId == ViewBag.Users)
            {

#line default
#line hidden
            BeginContext(1120, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1138, "\"", 1183, 2);
            WriteAttributeValue("", 1145, "/delete/", 1145, 8, true);
#line 26 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
WriteAttributeValue("", 1153, ViewBag.Activities.ActivityId, 1153, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1184, 43, true);
            WriteLiteral(" class=\"btn btn-danger btn-xs\">Delete</a>\r\n");
            EndContext();
#line 27 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
            }
            else if(isGoing)
            {

#line default
#line hidden
            BeginContext(1287, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1305, "\"", 1349, 2);
            WriteAttributeValue("", 1312, "/leave/", 1312, 7, true);
#line 30 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
WriteAttributeValue("", 1319, ViewBag.Activities.ActivityId, 1319, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1350, 44, true);
            WriteLiteral(" class=\"btn btn-warning btn-xs\">Leave</a> \r\n");
            EndContext();
#line 31 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1442, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1460, "\"", 1503, 2);
            WriteAttributeValue("", 1467, "/join/", 1467, 6, true);
#line 34 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
WriteAttributeValue("", 1473, ViewBag.Activities.ActivityId, 1473, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1504, 45, true);
            WriteLiteral(" class=\"btn btn-primary btn-xs\">Join</a>   \r\n");
            EndContext();
#line 35 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1575, 99, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div style=\"border: 1px solid #337ab;\">\r\n    <div>\r\n        <h3>Coordinator: ");
            EndContext();
            BeginContext(1675, 35, false);
#line 42 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
                    Write(ViewBag.Activities.Coordinator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1710, 72, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div>\r\n        <h3>Description:</h3>\r\n        <p>");
            EndContext();
            BeginContext(1783, 30, false);
#line 46 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
      Write(ViewBag.Activities.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1813, 76, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h3>Participants:</h3> \r\n        <ol>\r\n");
            EndContext();
#line 51 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
                 foreach(var part in ViewBag.Activities.UserParticipating)
                {

#line default
#line hidden
            BeginContext(1984, 54, true);
            WriteLiteral("                    <h4>\r\n                        <li>");
            EndContext();
            BeginContext(2039, 15, false);
#line 54 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
                       Write(part.Ninja.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 34, true);
            WriteLiteral("</li>\r\n                    </h4>\r\n");
            EndContext();
#line 56 "C:\Users\Zheng\OneDrive\desktop\DojoActivities\Views\Dojo\ActivityInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(2107, 37, true);
            WriteLiteral("        </ol>\r\n    </div>\r\n</div>\r\n\r\n");
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
