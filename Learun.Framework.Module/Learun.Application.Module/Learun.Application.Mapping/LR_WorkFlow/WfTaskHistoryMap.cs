using Learun.Application.WorkFlow;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：任务实例处理记录
    /// </summary>
    public class WfTaskHistoryMap : EntityTypeConfiguration<WfTaskHistoryEntity>
    {
        public WfTaskHistoryMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_WF_TASKHISTORY");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
