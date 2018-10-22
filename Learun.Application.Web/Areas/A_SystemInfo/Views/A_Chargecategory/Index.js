/* * 版 本V2.3 辰星软件开发框架
 * Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
 * 创建人：超级管理员
 * 日  期：2018-10-19 08:37
 * 描  述：A_Chargecategory
 */
var refreshGirdData;
var bootstrap = function ($, learun) {
    "use strict";
    var companyId = $("#keyid").val();
    var page = {
        init: function () {
             if (companyId.length == 0) {
                 page.inittree();
             }
            page.initGird();
            page.bind();
            page.search();        },
        bind: function () {
            $('#multiple_condition_query').lrMultipleQuery(function (queryJson) {
                page.search(queryJson);
            }, 220, 400);
            $('#F_CreateUserId').lrUserSelect(0);
            // 刷新
            $('#lr_refresh').on('click', function () {
                location.reload();
            });
            // 新增
            $('#lr_add').on('click', function () {
                learun.layerForm({
                    id: 'form',
                    title: '新增',
                    url: top.$.rootUrl + '/A_SystemInfo/A_Chargecategory/Form?companyId=' + companyId',
                    width: 600,
                    height: 400,
                    callBack: function (id) {
                        return top[id].acceptClick(refreshGirdData);
                    }
                });
            });
            // 编辑
            $('#lr_edit').on('click', function () {
                var keyValue = $('#gridtable').jfGridValue('ID');
                if (learun.checkrow(keyValue)) {
                    learun.layerForm({
                        id: 'form',
                        title: '编辑',
                        url: top.$.rootUrl + '/A_SystemInfo/A_Chargecategory/Form?keyValue=' + keyValue,
                        width: 600,
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
                            learun.deleteForm(top.$.rootUrl + '/A_SystemInfo/A_Chargecategory/DeleteForm', { keyValue: keyValue}, function () {
                                refreshGirdData();
                            });
                        }
                    });
                }
            });
            // 打印
            $('#lr_print').on('click', function () {
                $('#gridtable').jqprintTable();
            });
        },
        inittree: function () {
            $('#companyTree').lrtree({
                url: top.$.rootUrl + '/LR_OrganizationModule/Company/GetTree',
                param: { parentId: $("#keyid").val() },
                nodeClick: page.treeNodeClick
            });
            //$('#companyTree').lrtreeSet('setValue', '4cdd86d6-9aff-446b-abd1-37ad7d18bc6c');
        },
        treeNodeClick: function (item) {
            companyId = item.id;
            $('#titleinfo').text(item.text);
            page.search();
        },
        // 初始化列表
        initGird: function () {
            $('#gridtable').lrAuthorizeJfGrid({
                url: top.$.rootUrl + '/A_SystemInfo/A_Chargecategory/GetPageList',
                headData: [
                    { label: "类别名称", name: "NAME", width: 100, align: "left"},
                    { label: "编 码", name: "BM", width: 100, align: "left"},
                    { label: "输入码", name: "SRM", width: 100, align: "left"},
                    { label: "是否生效", name: "F_EnabledMark", width: 100, align: "left",
                        formatterAsync: function (callback, value, row, op,$cell) {
                             learun.clientdata.getAsync('dataItem', {
                                 key: value,
                                 code: 'YesOrNo',
                                 callback: function (_data) {
                                     callback(_data.text);
                                 }
                             });
                        }},
                    { label: "是否删除", name: "F_DeleteMark", width: 100, align: "left",
                        formatterAsync: function (callback, value, row, op,$cell) {
                             learun.clientdata.getAsync('dataItem', {
                                 key: value,
                                 code: 'YesOrNo',
                                 callback: function (_data) {
                                     callback(_data.text);
                                 }
                             });
                        }},
                ],
                mainId:'ID',
                isPage: true
            });
            page.search();
        },
        search: function (param) {
            param = param || {};
            $('#gridtable').jfGridSet('reload',{ queryJson: JSON.stringify(param) });
        }
    };
    refreshGirdData = function () {
        page.search();
    };
    page.init();
}
