﻿using Learun.Util;
using System.Collections.Generic;

namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：工作流委托规则
    /// </summary>
    public interface WfDelegateRuleIBLL
    {
        #region 获取数据
        /// <summary>
        /// 获取分页列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="keyword">关键字(被委托人)</param>
        /// <param name="userInfo">用户信息</param>
        /// <returns></returns>
        IEnumerable<WfDelegateRuleEntity> GetPageList(Pagination pagination, string keyword, UserInfo userInfo);
        /// <summary>
        /// 根据委托人获取委托记录
        /// </summary>
        /// <returns></returns>
        IEnumerable<WfDelegateRuleEntity> GetList(UserInfo userInfo);
        /// <summary>
        /// 获取关联的模板数据
        /// </summary>
        /// <returns></returns>
        IEnumerable<WfDelegateRuleRelationEntity> GetRelationList(string keyValue);
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存实体
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="wfDelegateRuleEntity">实体数据</param>
        /// <param name="schemeInfoList">关联模板主键</param>
        void SaveEntity(string keyValue, WfDelegateRuleEntity wfDelegateRuleEntity, string[] schemeInfoList);
        /// <summary>
        /// 更新委托规则状态信息
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="state"></param>
        void UpdateState(string keyValue, int state);
        #endregion
    }
}
