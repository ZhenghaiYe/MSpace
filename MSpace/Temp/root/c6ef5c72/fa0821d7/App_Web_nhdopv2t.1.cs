﻿#pragma checksum "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C7A7C7D574802F9B37D28B18A779C67EB0C2E5AC"
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
    
    
    public class _Page_Areas_Admin_Views_PrivateMessage_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden

        
        public _Page_Areas_Admin_Views_PrivateMessage_Index_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

            
            #line 1 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
  
    ViewBag.Title = "Index";


            
            #line default
            #line hidden
WriteLiteral(@"
<div class=""metro span12"">
<div class=""metro-sections"">
    <div id=""section1"" class=""metro-section tile-span-1"">
        
    </div>
    <div id=""section2"" class=""metro-section tile-span-6 well"">
        <table id=""messageList"" class=""table table-condensed table-hover"">
            <caption><h3>私信列表</h3></caption>
            <thead>
                <tr>
                    <th class=""span1 align-center"">#</th>
                    <th class=""span3 align-center"">作者</th>
                    <th class=""span4 align-center"">内容</th>
                    <th class=""span4 align-center"">日期</th>
                    <th class=""span3 align-center"">状态</th>
                    <th class=""span3 align-center"">操作</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
            ");



WriteLiteral("\r\n        </table>\r\n        <div id=\"pro\" class=\"progress progress-indeterminate\"" +
">\r\n            <div class=\"bar\"></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</di" +
"v>\r\n\r\n");


DefineSection("Scripts", () => {

WriteLiteral(@"
    <script type=""text/x-jsrender"" id=""messageListTemplate"">
        {{for messages}}
            <tr>
                <td>{{:id}}</td>
                <td>{{:name}}</td>
                <td>{{:content}}</td>
                <td>{{:publishDate}}</td>
                <td>{{:status}}</td>
                <td>
                    <a href=""");


            
            #line 44 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
                        Write(Url.Action("Read"));

            
            #line default
            #line hidden
WriteLiteral("/{{:id}}\" title=\"阅读\"><i class=\"icon-eye\"></i></a>&ensp;\r\n                    <a h" +
"ref=\"");


            
            #line 45 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
                        Write(Url.Action("List", "PrivateMessageReply"));

            
            #line default
            #line hidden
WriteLiteral("/{{:id}}\" title=\"回复\"><i class=\"icon-reply-2\"></i></a>&ensp;\r\n                    " +
"<a href=\"");


            
            #line 46 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
                        Write(Url.Action("Delete"));

            
            #line default
            #line hidden
WriteLiteral("/{{:id}}\" title=\"删除\"><i class=\"icon-remove\"></i></a></td>\r\n            </tr>\r\n   " +
"     {{/for}}\r\n    </script>\r\n\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 51 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
                                   Write(Url.Content("~/Scripts/jquery.meerkat.1.3.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\" src=\"");


            
            #line 52 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
                                   Write(Url.Content("~/Scripts/jsrender.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n      " +
"      loadMessages();\r\n        });\r\n\r\n\r\n        function loadMessages() {\r\n     " +
"       $.getJSON(\'");


            
            #line 60 "E:\VS2012\MSpace\MSpace\Areas\Admin\Views\PrivateMessage\Index.cshtml"
                  Write(Url.Action("List"));

            
            #line default
            #line hidden
WriteLiteral(@"', {})
                .success(function (data) {
                    $(""#messageListTemplate tbody"").empty();
                    //JsRender渲染、渲染结果（字符串）插入容器                
                    $(""#messageList tbody"").append($(""#messageListTemplate"").render(data));
                    $('#pro').hide();
                })
                .error(function (textStatus) {
                    alert(""msg:"" + textStatus.statusText);
                })
                .complete(function (jqXHQ) {
                    jqXHQ = null;
                });
        }

    </script>
");


});

WriteLiteral("\r\n\r\n");


DefineSection("LeftFooter", () => {

WriteLiteral("\r\n    ");



WriteLiteral("\r\n");


});

WriteLiteral("\r\n");


DefineSection("RightFooter", () => {

WriteLiteral("\r\n    ");



WriteLiteral("\r\n");


});

WriteLiteral("\r\n");


        }
    }
}