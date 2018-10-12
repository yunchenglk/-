﻿using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.04.01
    /// 描 述：数据库连接
    /// </summary>
    public class DataBaseLinkMap : EntityTypeConfiguration<DatabaseLinkEntity>
    {
        public DataBaseLinkMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_BASE_DATABASELINK");
            //主键
            this.HasKey(t => t.F_DatabaseLinkId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
