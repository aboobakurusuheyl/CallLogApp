/*
Template Name: Color Admin - Responsive Admin Dashboard Template build with Twitter Bootstrap 3 & 4
Version: 4.0.0
Author: Sean Ngu
Website: http://www.seantheme.com/color-admin-v4.0/admin/
*/

var handleEmailActionButtonStatus = function() {
    if ($('[data-checked=email-checkbox]:checked').length !== 0) {
        $('[data-email-action]').removeClass('hide');
    } else {
        $('[data-email-action]').addClass('hide');
    }
};

var handleEmailCheckboxChecked = function() {
    $(document).on('change', '[data-checked=email-checkbox]', function() {
        var targetLabel = $(this).closest('label');
        var targetEmailList = $(this).closest('li');
        if ($(this).prop('checked')) {
            $(targetLabel).addClass('active');
            $(targetEmailList).addClass('selected');
        } else {
            $(targetLabel).removeClass('active');
            $(targetEmailList).removeClass('selected');
        }
        handleEmailActionButtonStatus();
    });
};

var handleEmailAction = function() {
    $(document).on('click', '[data-email-action]', function() {
        var targetEmailList = '[data-checked=email-checkbox]:checked';
        if ($(targetEmailList).length !== 0) {
            $(targetEmailList).closest('li').slideToggle(function() {
                $(this).remove();
                handleEmailActionButtonStatus();
                if ($('.list-email > li').length === 0) {
                	$('.list-email').html('<li class="p-15 text-center"><div class="p-20"><i class="fa fa-trash fa-5x text-silver"></i></div> This folder is empty</li>');
                }
            });
        }
    });
};

var handleEmailSelectAll = function () {
	"use strict";
    $('[data-click=email-select-all]').click(function(e) {
        e.preventDefault();
        
        var targetIcon = $(this).find('i');
        if ($(targetIcon).hasClass('fa-check-square')) {
        	$(targetIcon).removeClass('fa-check-square text-inverse').addClass('fa-square text-muted');
        	$('.list-email .email-checkbox input[type="checkbox"]').prop('checked', false);
        } else {
        	$(targetIcon).addClass('fa-check-square text-inverse').removeClass('fa-square text-muted');
        	$('.list-email .email-checkbox input[type="checkbox"]').prop('checked', true);
        }
        $('.list-email .email-checkbox input[type="checkbox"]').trigger('change');
    });
};

var InboxV2 = function () {
	"use strict";
    return {
        //main function
        init: function () {
            handleEmailCheckboxChecked();
            handleEmailAction();
            handleEmailSelectAll();
        }
    };
}();