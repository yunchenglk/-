using Learun.Application.OA;
using Learun.Application.OA.Schedule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：新闻公告
    /// </summary>
    public class ScheduleMap : EntityTypeConfiguration<ScheduleEntity>
    {
        public ScheduleMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_OA_SCHEDULE");
            //主键
            this.HasKey(t => t.F_ScheduleId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
