/*
 * 版 本V2.3 辰星软件开发框架
 * Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
 * 创建人：辰星软件开发组
 * 日 期：2017.11.11
 * 描 述：日程管理
 */
var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";
    var page = {
        init: function () {
            page.bind();
            page.initData();
        },
        bind: function () {
            //开始时间
            $('#F_StartTime').lrselect({
                maxHeight: 150
            });
            //结束时间
            $('#F_EndTime').lrselect({
                maxHeight: 150
            });
        },
        initData: function () {
            $("#F_StartDate").val(request('startDate'));
            $("#F_StartTime").lrselectSet(request('startTime'));
        }
    };
    acceptClick = function () {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData("");
        $.lrSaveForm(top.$.rootUrl + '/LR_OAModule/Schedule/SaveForm?keyValue=', postData, function (res) {
            learun.frameTab.currentIframe().location.reload();
        });
    }
    page.init();
}


