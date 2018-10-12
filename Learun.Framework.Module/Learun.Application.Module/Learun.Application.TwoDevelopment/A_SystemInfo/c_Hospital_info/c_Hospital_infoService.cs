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
    /// 日 期：2018-10-09 16:28
    /// 描 述：医院信息管理
    /// </summary>
    public class c_Hospital_infoService : RepositoryFactory
    {
        #region 获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        public IEnumerable<c_Hospital_infoEntity> GetPageList(Pagination pagination, string queryJson)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(@"
                t.ID,
                t.FullName,
                t.ShortName,
                t.EnCode,
                t.Category,
                t.Nature,
                t.F_DeleteMark,
                t.F_EnabledMark,
                t.F_CreateUserId,
                t.F_CreateDate
                ");
                strSql.Append("  FROM c_Hospital_info t ");
                strSql.Append("  WHERE 1=1 ");
                var queryParam = queryJson.ToJObject();
                // 虚拟参数
                DynamicParameters dp = null;
                //var dp = new DynamicParameters(new { });
                if (!queryParam["FullName"].IsEmpty())
                {
                    dp.Add("FullName", "%" + queryParam["FullName"].ToString() + "%", DbType.String);
                    strSql.Append(" AND t.FullName Like @FullName ");
                }
                if (!queryParam["ShortName"].IsEmpty())
                {
                    dp.Add("ShortName", "%" + queryParam["ShortName"].ToString() + "%", DbType.String);
                    strSql.Append(" AND t.ShortName Like @ShortName ");
                }
                if (!queryParam["EnCode"].IsEmpty())
                {
                    dp.Add("EnCode", "%" + queryParam["EnCode"].ToString() + "%", DbType.String);
                    strSql.Append(" AND t.EnCode Like @EnCode ");
                }
                return this.BaseRepository("cx_his_db").FindList<c_Hospital_infoEntity>(strSql.ToString(), pagination);

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
        /// 获取c_Hospital_info表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public c_Hospital_infoEntity Getc_Hospital_infoEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository("cx_his_db").FindEntity<c_Hospital_infoEntity>(keyValue);
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
                this.BaseRepository("cx_his_db").Delete<c_Hospital_infoEntity>(t => t.ID == keyValue);
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
        public void SaveEntity(string keyValue, c_Hospital_infoEntity entity)
        {
            try
            {
                if (!string.IsNullOrEmpty(keyValue))
                {

                    entity.Modify(keyValue);
                    this.BaseRepository("cx_his_db").Update(entity);
                }
                else
                {
                    entity.Create();
                    this.BaseRepository("cx_his_db").Insert(entity);
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
