namespace Learun.Application.Organization
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.03.27
    /// 描 述：部门数据模型
    /// </summary>
    public class DepartmentModel
    {
        /// <summary>
        /// 部门上级id
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyId { get; set; }
        /// <summary>
        /// 公司名字
        /// </summary>
        public string name { get; set; }
    }
}
