
namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：工作流字段权限信息
    /// </summary>
    public class WfAuthorizeField
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string fieldName { get; set; }
        /// <summary>
        /// 字段Id
        /// </summary>
        public string fieldId { get; set; }
        /// <summary>
        /// 是否可编辑1是0不是
        /// </summary>
        public int isEdit { get; set; }
        /// <summary>
        /// 是否可查看1是0不是
        /// </summary>
        public int isLook { get; set; }
    }
}
