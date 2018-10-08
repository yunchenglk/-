﻿using Learun.Application.Organization;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2017.03.04
    /// 描 述：机构管理
    /// </summary>
    public class CompanyMap : EntityTypeConfiguration<CompanyEntity>
    {
        public CompanyMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_BASE_COMPANY");
            //主键
            this.HasKey(t => t.F_CompanyId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
