﻿using Learun.Util;
using System.Data;
using Learun.Application.TwoDevelopment.A_SystemInfo;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Learun.Application.Web.Areas.A_SystemInfo.Controllers
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-10-19 08:37
    /// 描 述：A_Chargecategory
    /// </summary>
    public class A_ChargecategoryController : MvcControllerBase
    {
        private A_ChargecategoryIBLL a_ChargecategoryIBLL = new A_ChargecategoryBLL();

        #region 视图功能

        /// <summary>
        /// 主页面
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
             return View();
        }
        /// <summary>
        /// 表单页
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Form()
        {
             return View();
        }
        #endregion

        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetPageList(string pagination,string companyId, string queryJson)
        {
            Pagination paginationobj = pagination.ToObject<Pagination>();
            var data = a_ChargecategoryIBLL.GetPageList(paginationobj, companyId, queryJson);
            var jsonData = new
            {
                rows = data,
                total = paginationobj.total,
                page = paginationobj.page,
                records = paginationobj.records
            };
            return Success(jsonData);
        }
        /// <summary>
        /// 获取表单数据
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetFormData(string keyValue)
        {
            var A_ChargecategoryData = a_ChargecategoryIBLL.GetA_ChargecategoryEntity( keyValue );
            var jsonData = new {
                A_Chargecategory = A_ChargecategoryData,
            };
            return Success(jsonData);
        }
        #endregion

        #region 提交数据

        /// <summary>
        /// 删除实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        [HttpPost]
        [AjaxOnly]
        public ActionResult DeleteForm(string keyValue)
        {
            a_ChargecategoryIBLL.DeleteEntity(keyValue);
            return Success("删除成功！");
        }
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AjaxOnly]
        public ActionResult SaveForm(string keyValue, string strEntity)
        {
            A_ChargecategoryEntity entity = strEntity.ToObject<A_ChargecategoryEntity>();
            a_ChargecategoryIBLL.SaveEntity(keyValue,entity);
            return Success("保存成功！");
        }
        #endregion

    }
}
