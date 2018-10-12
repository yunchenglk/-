using System.Collections.Generic;

namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.04.17
    /// 描 述：工作流模板模型
    /// </summary>
    public class WfSchemeModel
    {
        #region 原始属性
        /// <summary>
        /// 节点数据
        /// </summary>
        public List<WfNodeInfo> nodes { get; set; }
        /// <summary>
        /// 线条数据
        /// </summary>
        public List<WfLineInfo> lines { get; set; }
        #endregion
    }
}
