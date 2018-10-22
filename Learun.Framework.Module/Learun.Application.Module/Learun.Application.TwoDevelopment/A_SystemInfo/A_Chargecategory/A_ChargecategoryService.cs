using Dapper;
using Learun.DataBase.Repository;
using Learun.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Learun.Application.TwoDevelopment.A_SystemInfo
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-10-19 08:37
    /// 描 述：A_Chargecategory
    /// </summary>
    public class A_ChargecategoryService : RepositoryFactory
    {
        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<A_ChargecategoryEntity> GetPageList(Pagination pagination,string companyId, string queryJson)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(@"
                t.ID,
                t.NAME,
                t.BM,
                t.SRM,
                t.F_EnabledMark,
                t.F_DeleteMark
                ");
                strSql.Append("  FROM A_Chargecategory t ");
                strSql.Append("  WHERE 1=1 AND F_CompanyID = @companyId ");
                var queryParam = queryJson.ToJObject();
                // 虚拟参数
                var dp = new DynamicParameters(new { companyId });
                if (!queryParam["NAME"].IsEmpty())
                {
                    dp.Add("NAME", "%" + queryParam["NAME"].ToString() + "%", DbType.String);
                    strSql.Append(" AND t.NAME Like @NAME ");
                }
                if (!queryParam["BM"].IsEmpty())
                {
                    dp.Add("BM", "%" + queryParam["BM"].ToString() + "%", DbType.String);
                    strSql.Append(" AND t.BM Like @BM ");
                }
                if (!queryParam["F_CreateUserId"].IsEmpty())
                {
                    dp.Add("F_CreateUserId",queryParam["F_CreateUserId"].ToString(), DbType.String);
                    strSql.Append(" AND t.F_CreateUserId = @F_CreateUserId ");
                }
                return this.BaseRepository().FindList<A_ChargecategoryEntity>(strSql.ToString(),dp, pagination);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 获取A_Chargecategory表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public A_ChargecategoryEntity GetA_ChargecategoryEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<A_ChargecategoryEntity>(keyValue);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
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
                this.BaseRepository().Delete<A_ChargecategoryEntity>(t=>t.ID == keyValue);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void SaveEntity(string keyValue, A_ChargecategoryEntity entity)
        {
            try
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    entity.Modify(keyValue);
                    this.BaseRepository().Update(entity);
                }
                else
                {
                    entity.Create();
                    this.BaseRepository().Insert(entity);
                }
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        #endregion

    }
}
