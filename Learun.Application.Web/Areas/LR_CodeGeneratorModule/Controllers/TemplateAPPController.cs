using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learun.Application.Web.Areas.LR_CodeGeneratorModule.Controllers
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2018.10.01
    /// 描 述：移动端代码生成器
    /// </summary>
    public class TemplateAPPController : MvcControllerBase
    {
        #region 视图功能
        public ActionResult Index()
        {
            return View();
        }
        #endregion
    }
}