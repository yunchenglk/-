﻿/*
 * 版 本V2.3 辰星软件开发框架
 * Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
 * 创建人：辰星软件开发组
 * 日 期：2017.04.05
 * 描 述：工作流模板预览	
 */
var schemeId = request('schemeId');

var currentNode;
var currentLine;
var bootstrap = function ($, learun) {
    "use strict";

    var page = {
        init: function () {
            // 设计页面初始化
            $('#flow').lrworkflow({
                isPreview:true,
                openNode: function (node) {
                    currentNode = node;
                    if (node.type != 'endround') {
                        learun.layerForm({
                            id: 'NodeForm',
                            title: '节点信息设置【' + node.name + '】',
                            url: top.$.rootUrl + '/LR_WorkFlowModule/WfScheme/NodeForm?layerId=layer_PreviewForm&isPreview=1',
                            width: 700,
                            height: 500,
                            btn: null
                        });
                    }
                }
            });
            
            if (!!schemeId) {
                $.lrSetForm(top.$.rootUrl + '/LR_WorkFlowModule/WfScheme/GetScheme?schemeId=' + schemeId, function (res) {
                    var shceme = JSON.parse(res.F_Scheme);
                    $('#flow').lrworkflowSet('set', { data: shceme });
                });
            }
        }
    };

    page.init();
}