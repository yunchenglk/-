using Learun.Application.TwoDevelopment.MY_SystemCode;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-10-08 23:31
    /// 描 述：sdfg
    /// </summary>
    public class c_ChargecategoryMap : EntityTypeConfiguration<c_ChargecategoryEntity>
    {
        public c_ChargecategoryMap()
        {
            #region 表、主键
            //表
            this.ToTable("C_CHARGECATEGORY");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

