using Learun.Application.TwoDevelopment.A_SystemInfo;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-10-09 16:28
    /// 描 述：医院信息管理
    /// </summary>
    public class c_Hospital_infoMap : EntityTypeConfiguration<c_Hospital_infoEntity>
    {
        public c_Hospital_infoMap()
        {
            #region 表、主键
            //表
            this.ToTable("C_HOSPITAL_INFO");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

