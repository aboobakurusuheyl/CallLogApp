/*
Template Name: Color Admin - Responsive Admin Dashboard Template build with Twitter Bootstrap 3 & 4
Version: 4.0.0
Author: Sean Ngu
Website: http://www.seantheme.com/color-admin-v4.0/admin/
*/

var handleDataTableRowReorder = function() {
	"use strict";
    
    if ($('#data-table-rowreorder').length !== 0) {
        $('#data-table-rowreorder').DataTable({
            responsive: true,
            rowReorder: true
        });
    }
};

var TableManageRowReorder = function () {
	"use strict";
    return {
        //main function
        init: function () {
            handleDataTableRowReorder();
        }
    };
}();