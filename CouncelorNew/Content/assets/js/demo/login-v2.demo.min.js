/*
Template Name: Color Admin - Responsive Admin Dashboard Template build with Twitter Bootstrap 3 & 4
Version: 4.0.0
Author: Sean Ngu
Website: http://www.seantheme.com/color-admin-v4.0/admin/
*/var handleLoginPageChangeBackground=function(){$(document).on("click",'[data-click="change-bg"]',function(a){a.preventDefault();var n="url("+$(this).attr("data-img")+")";$('[data-id="login-cover-image"]').css("background-image",n),$('[data-click="change-bg"]').closest("li").removeClass("active"),$(this).closest("li").addClass("active")})},LoginV2=function(){"use strict";return{init:function(){handleLoginPageChangeBackground()}}}();