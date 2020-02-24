/*
Template Name: Color Admin - Responsive Admin Dashboard Template build with Twitter Bootstrap 3 & 4
Version: 4.0.0
Author: Sean Ngu
Website: http://www.seantheme.com/color-admin-v4.0/admin/
*/

var handleDataTableScroller = function() {
	"use strict";
    
    if ($('#data-table-scroller').length !== 0) {
        $('#data-table-scroller').DataTable({
            ajax:           "../assets/plugins/DataTables/json/scroller-demo.json",
            deferRender:    true,
            scrollY:        300,
            scrollCollapse: true,
            scroller:       true,
            responsive: true
        });
    }
};

var TableManageScroller = function () {
	"use strict";
    return {
        //main function
        init: function () {
            handleDataTableScroller();
        }
    };
}();