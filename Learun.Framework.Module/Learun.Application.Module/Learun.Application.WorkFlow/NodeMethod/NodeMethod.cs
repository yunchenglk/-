
namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：工作流引擎节点触发方法
    /// </summary>
    public class NodeMethod : INodeMethod
    {
        /// <summary>
        /// 节点审核通过执行方法
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        public void Sucess(string processId)
        {

        }
        /// <summary>
        /// 节点审核失败执行方法
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        public void Fail(string processId)
        {

        }
    }
}
