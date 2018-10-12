/* * 版 本V2.3 辰星软件开发框架
 * Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
 * 创建人：超级管理员
 * 日  期：2018-10-09 16:28
 * 描  述：医院信息管理
 */
var acceptClick;
var keyValue = request('keyValue');
var bootstrap = function ($, learun) {
    "use strict";
    var page = {
        init: function () {
            $('.lr-form-wrap').lrscroll();
            page.bind();
            page.initData();
        },
        bind: function () {
            learun.httpAsync('GET', top.$.rootUrl + '/LR_SystemModule/CodeRule/GetEnCode', { code: '1008' }, function (data) {
                if (!$('#EnCode').val()) {
                    $('#EnCode').val(data);
                }
            });
            $('#Category').lrDataItemSelect({ code: 'c_his_type' });
            $('#Nature').lrDataItemSelect({ code: 'c_his_Nature' });
            $('#F_DeleteMark').lrRadioCheckbox({
                type: 'radio',
                code: 'YesOrNo',
            });
            $('#F_EnabledMark').lrRadioCheckbox({
                type: 'radio',
                code: 'YesOrNo',
            });
            $('#F_CreateUserId')[0].lrvalue = learun.clientdata.get(['userinfo']).userId;
            $('#F_CreateUserId').val(learun.clientdata.get(['userinfo']).realName);
            $('#F_CreateDate').val(learun.formatDate(new Date(), 'yyyy-MM-dd hh:mm:ss'));
        },
        initData: function () {
            if (!!keyValue) {
                $.lrSetForm(top.$.rootUrl + '/A_SystemInfo/c_Hospital_info/GetFormData?keyValue=' + keyValue, function (data) {
                    for (var id in data) {
                        if (!!data[id].length && data[id].length > 0) {
                            $('#' + id).jfGridSet('refreshdata', data[id]);
                        }
                        else {
                            $('[data-table="' + id + '"]').lrSetFormData(data[id]);
                        }
                    }
                });
            }
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('body').lrValidform()) {
            return false;
        }
        var postData = {
            strEntity: JSON.stringify($('body').lrGetFormData())
        };
        $.lrSaveForm(top.$.rootUrl + '/A_SystemInfo/c_Hospital_info/SaveForm?keyValue=' + keyValue, postData, function (res) {
            // 保存成功后才回调
            if (!!callBack) {
                callBack();
            }
        });
    };
    page.init();
    var keyitems = $("input");
    var keyitem = null;
    for (var i = 0; i < keyitems.length; i++) {
        keyitem = keyitems[i]; (function () {
            var next = (i + 1) < keyitems.length ? i + 1 : 0;
            keyitem.onkeydown = function (event) {
                var eve = event ? event : window.event;
                if (eve.keyCode == 13) {
                    keyitems[next].focus();
                }
            }
        })();
    }
}
