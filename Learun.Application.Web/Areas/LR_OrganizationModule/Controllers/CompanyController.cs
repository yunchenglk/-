﻿using Learun.Application.Organization;
using Learun.Util;
using Learun.Util.Operat;
using System.Web.Mvc;

namespace Learun.Application.Web.Areas.LR_OrganizationModule.Controllers
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2018.10.01
    /// 描 述：公司管理
    /// </summary>
    public class CompanyController : MvcControllerBase
    {
        private CompanyIBLL companyIBLL = new CompanyBLL();

        #region 获取视图
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Form() {
            return View();
        }
        #endregion

        #region 获取数据
        /// <summary>
        /// 获取公司列表信息
        /// </summary>
        /// <param name="keyword">查询关键字</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetList(string keyword) {
            var data = companyIBLL.GetList(keyword);
            return Success(data);
        }
        /// <summary>
        /// 获取树形数据
        /// </summary>
        /// <param name="parentId">父级id</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetTree(string parentId)
        {
            var data = companyIBLL.GetTree(parentId);
            return Success(data);
        }
        /// <summary>
        /// 获取映射数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetMap(string ver)
        {
            var data = companyIBLL.GetModelMap();
            string md5 = Md5Helper.Encrypt(data.ToJson(), 32);
            if (md5 == ver)
            {
                return Success("no update");
            }
            else {
                var jsondata = new {
                    data = data,
                    ver = md5
                };
                return Success(jsondata);
            }
        } 
        /// <summary>
        /// 获取部门实体数据
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetEntity(string F_CompanyId)
        {
            var data = companyIBLL.GetEntity(F_CompanyId);
            return Success(data);
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 保存表单数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AjaxOnly]
        public ActionResult SaveForm(string keyValue, CompanyEntity entity)
        {
            companyIBLL.SaveEntity(keyValue, entity);
            return Success("保存成功！", "公司信息", string.IsNullOrEmpty(keyValue) ? OperationType.Create : OperationType.Update, entity.F_CompanyId, entity.ToJson());
        }
        /// <summary>
        /// 删除表单数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [AjaxOnly]
        public ActionResult DeleteForm(string keyValue)
        {
            companyIBLL.VirtualDelete(keyValue);
            return Success("删除成功！", "公司信息", OperationType.Delete, keyValue, "");
        }
        #endregion
    }
}