﻿/*
 * 版 本V2.3 辰星软件开发框架
 * Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
 * 创建人：辰星软件开发组
 * 日 期：2017.04.18
 * 描 述：流程线条设置	
 */
var layerId = request('layerId');
var acceptClick;
var bootstrap = function ($, learun) {
    "use strict";
    var currentLine = top[layerId].currentLine;
    var page = {
        init: function () {
            page.bind();
            page.initData();
        },
        bind: function () {
            $('#wftype').lrselect({// 1.是 2.否 6.是否 --3.超时 4.超时或是 5超时或否 预留
                placeholder: false,
                data: [{ id: '1', text: '是' }, { id: '2', text: '否' }, { id: '6', text: '正常流转' }]
            }).lrselectSet('1');
        },
        initData: function () {
            $('#form').lrSetFormData(currentLine);
        }
    };
    // 保存数据
    acceptClick = function (callBack) {
        if (!$('#form').lrValidform()) {
            return false;
        }
        var formData = $('#form').lrGetFormData();
        currentLine.name = formData.name;
        currentLine.wftype = formData.wftype;

        callBack();
        return true;
    };
    page.init();
}