/*
Copyright 2013, KISSY UI Library v1.40dev
MIT Licensed
build time: Feb 17 17:28
*/
KISSY.add("editor/plugin/italic/cmd",function(d,a,b){var c=new a.Style({element:"em",overrides:[{element:"i"},{element:"span",attributes:{style:"font-style: italic;"}}]});return{init:function(a){b.addButtonCmd(a,"italic",c)}}},{requires:["editor","../font/cmd"]});
