/// <reference path="jquery-1.7.2.js" />

(function ($) {
    $.fn.inverse = function (options) {
        var defaults = {};
        var opts = $.extend({}, defaults, options);
        var $obj = $(this);
    };

    //遮罩
    $.fn.mask = function (options) {
        var defaults = {
            msg:'Doing something now . . .' ,
            cssName:'mask span4'
        };
        var opts = $.extend({}, defaults, options);
        var $obj = $(this);
        var $maskDiv = $('<div class="' + opts.cssName + '">' + opts.msg + '</div>');
        var offset = $obj.offset();
        $maskDiv.offset({ left: offset.left, top: offset.top });
       
        $('document,body').append($maskDiv);
    };

})(jQuery);