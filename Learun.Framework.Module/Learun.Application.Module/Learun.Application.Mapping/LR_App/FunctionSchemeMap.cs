﻿using Learun.Application.AppMagager;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping.LR_App
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2018.03.16
    /// 描 述：工作流模板
    /// </summary>
    public class FunctionSchemeMap : EntityTypeConfiguration<FunctionSchemeEntity>
    {
        public FunctionSchemeMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_APP_FNSCHEME");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
