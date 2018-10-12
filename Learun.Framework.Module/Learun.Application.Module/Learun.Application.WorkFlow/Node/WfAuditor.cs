
namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.04.17
    /// 描 述：工作流审核者
    /// </summary>
    public class WfAuditor
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 审核者主键
        /// </summary>
        public string auditorId { get; set; }
        /// <summary>
        /// 审核者名称
        /// </summary>
        public string auditorName { get; set; }
        /// <summary>
        /// 审核者类型1.岗位2.角色3.用户
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 限制条件1.同一个部门2.同一个公司
        /// </summary>
        public int? condition { get; set; }
    }
}
