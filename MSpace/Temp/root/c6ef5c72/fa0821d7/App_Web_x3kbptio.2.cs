﻿#pragma checksum "E:\VS2012\MSpace\MSpace\Views\Message\Publish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ECCACB6420E92E2EEDFD822F7CFEACB8097A9C3"
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
    
    
    public class _Page_Views_Message_Publish_cshtml : System.Web.Mvc.WebViewPage<MSpace.Models.Message> {
        
#line hidden

        
        public _Page_Views_Message_Publish_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

WriteLiteral("\r\n");



WriteLiteral(@"

<form id=""messageForm"">
    <fieldset>
        <legend>新留言</legend>
        <label>昵称</label>
        <input name=""Name"" type=""text"" placeholder=""这里输入您的昵称"" required>
        <span class=""help-block"">(必填)</span>
        <label>邮箱</label>
        <input name=""Email"" type=""text"" placeholder=""这里输入您的邮箱"">
        <span class=""help-block"">(选填，支持Gravatar)</span>
        <label>内容</label>
        <textarea name=""Content"" placeholder=""这里输入您的内容"" rows=""3"" required></textarea>
        <span class=""help-block"">(必填)</span>
        <label class=""checkbox"">
            <input id=""sendAsPrivate"" type=""checkbox"" />作为私信发送
        </label>
        <button id=""publishMessage"" type=""button"" class=""btn btn-inverse"">发表</button>
    </fieldset>
</form>


");


        }
    }
}
