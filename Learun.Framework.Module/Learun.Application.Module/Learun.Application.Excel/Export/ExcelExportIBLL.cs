﻿using Learun.Util;
using System.Collections.Generic;

namespace Learun.Application.Excel
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.04.01
    /// 描 述：Excel数据导出设置
    /// </summary>
    public interface ExcelExportIBLL
    {

        #region 获取数据
        /// <summary>
        /// 获取列表分页数据
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询参数</param>
        /// <summary>
        /// <returns></returns>
        IEnumerable<ExcelExportEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取列表
        /// <param name="moduleId">功能模块主键</param>
        /// <summary>
        /// <returns></returns>
        IEnumerable<ExcelExportEntity> GetList(string moduleId);
        /// <summary>
        /// 获取实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        ExcelExportEntity GetEntity(string keyValue);
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
        /// <param name="entity">主键</param>
        /// <summary>
        /// <returns></returns>
        void SaveEntity(string keyValue, ExcelExportEntity entity);
        #endregion
    }
}
