﻿#pragma checksum "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F04A6437E389ECFF45A6E34F51723CF7AAB7B611"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using MSpace.Models;
    
    
    public class _Page_Views_Home_Gallary2_cshtml : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden

        
        public _Page_Views_Home_Gallary2_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

            
            #line 1 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
  
    ViewBag.Title = "Gallary2";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("scripts", () => {

WriteLiteral("\r\n   \r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 7 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                            Write(Url.Content("~/Content/widget/iview/iview.css"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 8 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                            Write(Url.Content("~/Content/widget/iview/skin2/style.css"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n    <script src=\"");


            
            #line 9 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
            Write(Url.Content("~/Content/widget/iview/raphael-min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 10 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
            Write(Url.Content("~/Content/widget/iview/jquery.easing.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 11 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
            Write(Url.Content("~/Content/widget/iview/iview.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\r\n\r\n\r\n    <script type=\"text/javascript\">\r\n  " +
"      $(function () {\r\n            $(\'#navList > li:not(.divider-vertical):eq(3)" +
"\').addClass(\'active\').siblings().removeClass(\'active\');\r\n            $(\'#iview\')" +
".iView({\r\n                pauseTime: 7000,\r\n                pauseOnHover: true,\r" +
"\n                directionNav: true,\r\n                directionNavHide: false,\r\n" +
"                directionNavHoverOpacity: 0,\r\n                controlNav: false," +
"\r\n                nextLabel: \"Nächste\",\r\n                previousLabel: \"Vorheri" +
"ge\",\r\n                playLabel: \"Spielen\",\r\n                pauseLabel: \"Pause\"" +
",\r\n                timer: \"360Bar\",\r\n                timerPadding: 3,\r\n         " +
"       timerColor: \"#0F0\"\r\n            });\r\n            $(\'#iview2\').iView({\r\n  " +
"              pauseTime: 7000,\r\n                pauseOnHover: true,\r\n           " +
"     directionNav: true,\r\n                directionNavHide: false,\r\n            " +
"    controlNav: true,\r\n                controlNavNextPrev: false,\r\n             " +
"   controlNavTooltip: false,\r\n                nextLabel: \"Próximo\",\r\n           " +
"     previousLabel: \"Anterior\",\r\n                playLabel: \"Jugada\",\r\n         " +
"       pauseLabel: \"Pausa\",\r\n                timer: \"360Bar\",\r\n                t" +
"imerBg: \"#EEE\",\r\n                timerColor: \"#000\",\r\n                timerDiame" +
"ter: 40,\r\n                timerPadding: 4,\r\n                timerStroke: 8,\r\n   " +
"             timerPosition: \"bottom-right\"\r\n            });\r\r\r\n        });\r\n    " +
"</script>\r\n");


});

WriteLiteral("\r\n\r\n<h2>Gallary2</h2>\r\n<div id=\"iview\">\r\n\t\t\t<div data-iview:image=\"");


            
            #line 61 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo9.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption caption1\" data-x=\"300\" data-y=\"300\" data-transi" +
"tion=\"expandLeft\">EASY TO CONFIGURE AND CUSTOMIZE + COMPLETE WITH A CUSTOM API</" +
"div>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div data-iview:image=\"");


            
            #line 65 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo8.jpg"));

            
            #line default
            #line hidden
WriteLiteral(@""">
				<div class=""iview-caption video-caption"" data-x=""50"" data-y=""50"" data-transition=""wipeUp""><iframe src=""http://player.vimeo.com/video/11475955?byline=1&amp;portrait=0"" width=""500"" height=""281"" frameborder=""0"" webkitAllowFullScreen mozallowfullscreen allowFullScreen></iframe></div>
				<div class=""iview-caption caption4"" data-x=""600"" data-y=""140"" data-transition=""wipeRight"">Video</div>
				<div class=""iview-caption caption5"" data-x=""740"" data-y=""145"" data-transition=""wipeLeft"">Support</div>
				<div class=""iview-caption caption3"" data-x=""600"" data-y=""200"" data-width=""235"" data-height=""40"" data-transition=""wipeLeft"">You can easily add <b>Vimeo</b> & <b>Youtube Videos</b> to your <b>Slides</b> & <b>Captions</b></div>
			</div>

			<div data-iview:image=""");


            
            #line 72 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo7.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption caption2\" data-x=\"300\" data-y=\"300\" data-transi" +
"tion=\"wipeRight\">OPTIONAL AUTO-HIDE CONTROLS + OPTIONAL ROLLOVER SLIDESHOW PAUSE" +
"</div>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div data-iview:image=\"");


            
            #line 76 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo9.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption\" data-x=\"100\" data-y=\"300\" data-transition=\"wip" +
"eLeft\">A SMOOTH AND SEXY CROSS-BROWSER SLIDER FOR YOUR IMAGES & VIDEOS</div>\r\n\t\t" +
"\t</div>\r\n\r\n\t\t\t<div data-iview:image=\"");


            
            #line 80 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo8.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption caption3\" data-x=\"100\" data-y=\"300\" data-transi" +
"tion=\"wipeLeft\">FEATURING ANIMATED CAPTIONS WITH MANY TRANSITION EFFECTS</div>\r\n" +
"\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div id=\"iview2\">\r\n\t\t\t<div data-iview:image=\"");


            
            #line 85 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo7.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption caption1\" data-x=\"100\" data-y=\"300\" data-transi" +
"tion=\"fade\">FINE TUNED, SLEEK & SMOOTH, THIS SLIDER WILL IMPRESS YOUR VISITORS</" +
"div>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div data-iview:image=\"");


            
            #line 89 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo9.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption caption2\" data-x=\"50\" data-y=\"320\" data-transit" +
"ion=\"wipeRight\">SUPPORTS ANIMATED CAPTIONS, VIDEO & IFRAME, SINGLE PAGE MULTI-US" +
"E</div>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div data-iview:image=\"");


            
            #line 93 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo8.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t<div class=\"iview-caption caption3\" data-x=\"350\" data-y=\"300\" data-transi" +
"tion=\"wipeLeft\">GORGEOUS ANIMATED TIMERS WITH HIGH CUSTOMIZABLE OPTIONS</div>\r\n\t" +
"\t\t</div>\r\n\r\n\t\t\t<div data-iview:image=\"");


            
            #line 97 "E:\VS2012\MSpace\MSpace\Views\Home\Gallary2.cshtml"
                     Write(Url.Content("~/Content/photos/photo7.jpg"));

            
            #line default
            #line hidden
WriteLiteral("\"></div>\r\n\t\t</div>\r");


        }
    }
}
