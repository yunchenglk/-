using Learun.Util;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.A_SystemInfo
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-10-12 09:41
    /// 描 述：收费类别管理
    /// </summary>
    public interface ChargecategoryIBLL
    {
        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<A_ChargecategoryEntity> GetPageList(Pagination pagination, string companyId,string queryJson);
        /// <summary>
        /// 获取A_Chargecategory表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        A_ChargecategoryEntity GetA_ChargecategoryEntity(string keyValue);
        #endregion

        #region 提交数据

        /// <summary>
        /// 删除实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void SaveEntity(string keyValue, A_ChargecategoryEntity entity);
        #endregion

    }
}
