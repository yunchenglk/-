
using System.Collections.Generic;
namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：流程引擎返回结果数据
    /// </summary>
    public class WfResult
    {
        /// <summary>
        /// 状态:1-成功，2-失败
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string desc { get; set; }
    }
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：流程引擎返回结果数据
    /// </summary>
    public class WfResult<T> where T : class
    {
        /// <summary>
        /// 状态:1-成功，2-失败
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T data { get; set; }
    }

    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：流程引擎返回的数据内容
    /// </summary>
    public class WfContent {
        /// <summary>
        /// 当前节点信息
        /// </summary>
        public WfNodeInfo currentNode { get; set; }
        /// <summary>
        /// 当前正在执行的任务节点ID数据
        /// </summary>
        public List<string> currentNodeIds { get; set; }
        /// <summary>
        /// 流程模板信息
        /// </summary>
        public string scheme { get; set; }
        /// <summary>
        /// 审核记录
        /// </summary>
        public List<WfTaskHistoryEntity> history { get; set; } 
    }
}
