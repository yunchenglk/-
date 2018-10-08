/* * 版 本 Learun-ADMS V7.0.0 力软敏捷开发框架(http://www.learun.cn)
 * Copyright (c) 2013-2018 上海力软信息技术有限公司
 * 创建人：超级管理员
 * 日  期：2018-10-08 23:31
 * 描  述：sdfg
 */
var selectedRow;
var refreshGirdData;
var bootstrap = function ($, learun) {
    "use strict";
    var page = {
        init: function () {
            page.initGird();
            page.bind();
        },
        bind: function () {
            // 查询
            $('#btn_Search').on('click', function () {
                var keyword = $('#txt_Keyword').val();
                page.search({ keyword: keyword });
            });
            // 刷新
            $('#lr_refresh').on('click', function () {
                location.reload();
            });
            // 新增
            $('#lr_add').on('click', function () {
                selectedRow = null;
                learun.layerForm({
                    id: 'form',
                    title: '新增',
                    url: top.$.rootUrl + '/MY_SystemCode/dg/Form',
                    width: 700,
                    height: 400,
                    callBack: function (id) {
                        return top[id].acceptClick(refreshGirdData);
                    }
                });
            });
            // 编辑
            $('#lr_edit').on('click', function () {
                var keyValue = $('#gridtable').jfGridValue('ID');
                selectedRow = $('#gridtable').jfGridGet('rowdata');
                if (learun.checkrow(keyValue)) {
                    learun.layerForm({
                        id: 'form',
                        title: '编辑',
                        url: top.$.rootUrl + '/MY_SystemCode/dg/Form?keyValue=' + keyValue,
                        width: 700,
                        height: 400,
                        callBack: function (id) {
                            return top[id].acceptClick(refreshGirdData);
                        }
                    });
                }
            });
            // 删除
            $('#lr_delete').on('click', function () {
                var keyValue = $('#gridtable').jfGridValue('ID');
                if (learun.checkrow(keyValue)) {
                    learun.layerConfirm('是否确认删除该项！', function (res) {
                        if (res) {
                            learun.deleteForm(top.$.rootUrl + '/MY_SystemCode/dg/DeleteForm', { keyValue: keyValue}, function () {
                            });
                        }
                    });
                }
            });
        },
        initGird: function () {
            $('#gridtable').lrAuthorizeJfGrid({
                url: top.$.rootUrl + '/MY_SystemCode/dg/GetPageList',
                headData: [
                        { label: 'ID', name: 'ID', width: 200, align: "left" },
                        { label: '编码', name: 'BM', width: 200, align: "left" },
                        { label: '名称', name: 'NAME', width: 200, align: "left" },
                        { label: '上级ID', name: 'FID', width: 200, align: "left" },
                        { label: '输入码', name: 'SRM', width: 200, align: "left" },
                        { label: '有效标志0否1是', name: 'F_EnabledMark', width: 200, align: "left" },
                        { label: '创建人ID', name: 'F_CreateUserId', width: 200, align: "left" },
                        { label: '编辑人', name: 'F_ModifyUserName', width: 200, align: "left" },
                        { label: '编辑人ID', name: 'F_ModifyUserId', width: 200, align: "left" },
                        { label: '删除标记0否1是', name: 'F_DeleteMark', width: 200, align: "left" },
                        { label: '编辑日期', name: 'F_ModifyDate', width: 200, align: "left" },
                        { label: '创建人', name: 'F_CreateUserName', width: 200, align: "left" },
                        { label: '创建时间', name: 'F_CreateDate', width: 200, align: "left" },
                        { label: '备注', name: 'F_Description', width: 200, align: "left" },
                ],
                mainId:'ID',
                isPage: true
            });
            page.search();
        },
        search: function (param) {
            param = param || {};
            $('#gridtable').jfGridSet('reload', { queryJson: JSON.stringify(param) });
        }
    };
    refreshGirdData = function () {
        page.search();
    };
    page.init();
}
