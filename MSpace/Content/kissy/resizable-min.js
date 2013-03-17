/*
Copyright 2013, KISSY UI Library v1.40dev
MIT Licensed
build time: Feb 26 11:49
*/
KISSY.add("resizable",function(s,f,g,i,t){function u(a){var b=a.dds,l=a.get("node"),h=a.get("handlers"),m,n=a.get("prefixCls")+v;for(d=0;d<h.length;d++){var c=h[d],e=p("<div class='"+n+" "+n+"-"+c+"'></div>").prependTo(l,t),e=b[c]=new w({node:e,cursor:null,groups:!1});(function(b,c){var e;c.on("drag",function(c){var h=c.target,n=a._width,f=a._height,j=a.get("minWidth"),g=a.get("maxWidth"),i=a.get("minHeight"),p=a.get("maxHeight"),c=o[b](j,g,i,p,a._top,a._left,n,f,c.pageY-e.top,c.pageX-e.left,m);for(d=
0;d<q.length;d++)c[d]&&l.css(q[d],c[d]);a.fire("resize",{handler:b,dd:h})});c.on("dragstart",function(){e=c.get("startMousePos");m=a.get("preserveRatio");a._width=l.width();a._top=parseInt(l.css("top"));a._left=parseInt(l.css("left"));a._height=l.height();a.fire("resizeStart",{handler:b,dd:c})});c.on("dragend",function(){a.fire("resizeEnd",{handler:b,dd:c})})})(c,e)}}var p=f.all,d,w=i.Draggable,v="resizable-handler",i=["l","r"],r=["t","b"],q=["width","height","top","left"],o={t:function(a,b,d,h,m,
n,c,e,f,j,k){a=Math.min(Math.max(d,e-f),h);b=0;k&&(b=a/e*c);return[b,a,m+e-a,0]},b:function(a,b,d,h,m,f,c,e,g,j,k){a=Math.min(Math.max(d,e+g),h);b=0;k&&(b=a/e*c);return[b,a,0,0]},r:function(a,b,d,h,f,g,c,e,i,j,k){a=Math.min(Math.max(a,c+j),b);b=0;k&&(b=a/c*e);return[a,b,0,0]},l:function(a,b,d,h,f,g,c,e,i,j,k){a=Math.min(Math.max(a,c-j),b);b=0;k&&(b=a/c*e);return[a,b,0,g+c-a]}};for(d=0;d<i.length;d++)for(f=0;f<r.length;f++)(function(a,b){o[a+b]=o[b+a]=function(){var f=o[a].apply(this,arguments),h=
o[b].apply(this,arguments),g=[];for(d=0;d<f.length;d++)g[d]=f[d]||h[d];return g}})(i[d],r[f]);g=g.extend({initializer:function(){this.dds={}},_onSetNode:function(){u(this)},_onSetDisabled:function(a){s.each(this.dds,function(b){b.set("disabled",a)})},destructor:function(){var a,b=this.dds;for(a in b)b[a].destroy(),b[a].get("node").remove(),delete b[a]}},{ATTRS:{node:{setter:function(a){return p(a)}},prefixCls:{value:"ks-"},disabled:{},minWidth:{value:0},minHeight:{value:0},maxWidth:{value:Number.MAX_VALUE},
maxHeight:{value:Number.MAX_VALUE},preserveRatio:{value:!1},handlers:{value:[]}}});g.Handler={B:"b",T:"t",L:"l",R:"r",BL:"bl",TL:"tl",BR:"br",TR:"tr"};return g},{requires:["node","rich-base","dd/base"]});