﻿using Learun.DataBase.Repository;
using Learun.Util;
using System;
using System.Collections.Generic;

namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：会签记录操作
    /// </summary>
    public class WfConfluenceService : RepositoryFactory
    {
        #region 获取数据
        /// <summary>
        /// 获取会签记录
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        /// <param name="nodeId">节点主键</param>
        /// <returns></returns>
        public IEnumerable<WfConfluenceEntity> GetList(string processId, string nodeId)
        {
            try
            {
                return  this.BaseRepository().FindList<WfConfluenceEntity>(t => t.F_ProcessId == processId && t.F_NodeId == nodeId);
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
        /// 保存成功的会前记录
        /// </summary>
        /// <param name="entity">实体</param>
        public void SaveEntity(WfConfluenceEntity entity)
        {
            try
            {
                string processId = entity.F_ProcessId;
                string nodeId = entity.F_NodeId;
                string formNodeId = entity.F_FormNodeId;
                WfConfluenceEntity oldEntity = this.BaseRepository().FindEntity<WfConfluenceEntity>(t => t.F_ProcessId == processId && t.F_NodeId == nodeId && t.F_FormNodeId == formNodeId);
                if (oldEntity == null)
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
        /// <summary>
        /// 删除会签节点数据
        /// </summary>
        /// <param name="processId">实例主键</param>
        /// <param name="nodeId">节点主键</param>
        public void DeleteEntity(string processId, string nodeId)
        {
            try
            {
                this.BaseRepository().Delete<WfConfluenceEntity>(t => t.F_ProcessId == processId && t.F_NodeId == nodeId);
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
