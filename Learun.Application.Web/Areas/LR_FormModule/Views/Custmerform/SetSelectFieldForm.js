﻿/*
 * 版 本V2.3 辰星软件开发框架
 * Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
 * 创建人：辰星软件开发组
 * 日 期：2017.04.11
 * 描 述：表格选择项字段选择	
 */
var dbId = request('dbId');
var tableName = request('tableName');

var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";
    var selectFieldData = top.layer_SetFieldForm.selectFieldData;
    var page = {
        init: function () {
            page.bind();
            page.initData();
        },
        bind: function () {
            // 绑定字段
            $('#value').lrselect({
                value: 'f_column',
                text: 'f_column',
                title: 'f_remark',
                allowSearch: true,
                maxHeight:160
            });
            learun.httpAsync('GET', top.$.rootUrl + '/LR_SystemModule/DatabaseTable/GetFieldList', { databaseLinkId: dbId, tableName: tableName }, function (data) {
                $('#value').lrselectRefresh({
                    data: data
                });
            });
            // 对齐方式
            $('#align').lrselect({ placeholder: false }).lrselectSet('left');
            // 是否隐藏
            $('#hide').lrselect({ placeholder: false }).lrselectSet('0');
        },
        initData: function () {
            if (!!selectFieldData)
            {
                $('#form').lrSetFormData(selectFieldData);
            }
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var postData = $('#form').lrGetFormData();
        callBack(postData);

        return true;
    };
    page.init();
}