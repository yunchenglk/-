﻿using Learun.Util;
using System;
using System.Collections.Generic;

namespace Learun.Application.Base.SystemModule
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.03.21
    /// 描 述：系统日志
    /// </summary>
    public static class LogBLL
    {
        private static LogService service = new LogService();

        #region 获取数据
         /// <summary>
        /// 日志列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public static IEnumerable<LogEntity> GetPageList(Pagination pagination, string queryJson,string userId)
        {
            try
            {
                return service.GetPageList(pagination, queryJson, userId);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 清空日志
        /// </summary>
        /// <param name="categoryId">日志分类Id</param>
        /// <param name="keepTime">保留时间段内</param>
        public static void RemoveLog(int categoryId, string keepTime)
        {
            try
            {
                service.RemoveLog(categoryId, keepTime);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="logEntity">对象</param>
        public static void WriteLog(this LogEntity logEntity)
        {
            try
            {
                service.WriteLog(logEntity);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        #endregion
    }
}
