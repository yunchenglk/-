﻿using Learun.Util;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learun.Application.Base.AuthorizeModule
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：用户关联对象
    /// </summary>
    public class UserRelationEntity
    {
        #region 实体成员
        /// <summary>
        /// 用户关系主键
        /// </summary>
        /// <returns></returns>
        [Column("F_USERRELATIONID")]
        public string F_UserRelationId { get; set; }
        /// <summary>
        /// 用户主键
        /// </summary>
        /// <returns></returns>
        [Column("F_USERID")]
        public string F_UserId { get; set; }
        /// <summary>
        /// 分类:1-角色2-岗位
        /// </summary>
        /// <returns></returns>
        [Column("F_CATEGORY")]
        public int? F_Category { get; set; }
        /// <summary>
        /// 对象主键
        /// </summary>
        /// <returns></returns>
        [Column("F_OBJECTID")]
        public string F_ObjectId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <returns></returns>
        [Column("F_CREATEDATE")]
        public DateTime? F_CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        /// <returns></returns>
        [Column("F_CREATEUSERID")]
        public string F_CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        [Column("F_CREATEUSERNAME")]
        public string F_CreateUserName { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            UserInfo userInfo = LoginUserInfo.Get();
            this.F_CreateUserId = userInfo.userId;
            this.F_CreateUserName = userInfo.realName;

            this.F_UserRelationId = Guid.NewGuid().ToString();
            this.F_CreateDate = DateTime.Now;
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void Modify(string keyValue)
        {

        }
        #endregion
    }
}
