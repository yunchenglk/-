﻿
using Learun.Util;
using System.Collections.Generic;
namespace Learun.Application.TwoDevelopment.SystemDemo
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：系统表单-请假单
    /// </summary>
    public interface DemoleaveIBLL
    {
        #region 获取数据
         /// <summary>
        /// 获取请假数据列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        IEnumerable<DemoleaveEntity> GetPageList(Pagination pagination);
        /// <summary>
        /// 根据流程实例获取表单数据
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        DemoleaveEntity GetEntity(string processId);
        #endregion

        #region 提交数据
        /// <summary>
        /// 保存更新数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="entity">实体对象</param>
        void SaveEntity(string keyValue, DemoleaveEntity entity);
        #endregion
    }
}
