using Learun.Util;
using System;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.A_SystemInfo
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-10-13 11:18
    /// 描 述：业务对象信息字典管理
    /// </summary>
    public class F_DuixingBLL : F_DuixingIBLL
    {
        private F_DuixingService f_DuixingService = new F_DuixingService();

        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<A_DuixiangEntity> GetPageList(Pagination pagination, string queryJson)
        {
            try
            {
                return f_DuixingService.GetPageList(pagination, queryJson);
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
        /// 获取A_Duixiang表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public A_DuixiangEntity GetA_DuixiangEntity(string keyValue)
        {
            try
            {
                return f_DuixingService.GetA_DuixiangEntity(keyValue);
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
        /// 删除实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void DeleteEntity(string keyValue)
        {
            try
            {
                f_DuixingService.DeleteEntity(keyValue);
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
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void SaveEntity(string keyValue, A_DuixiangEntity entity)
        {
            try
            {
                f_DuixingService.SaveEntity(keyValue, entity);
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
