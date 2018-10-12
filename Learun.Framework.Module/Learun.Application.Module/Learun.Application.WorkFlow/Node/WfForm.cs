﻿namespace Learun.Application.WorkFlow
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.08.03
    /// 描 述：工作流关联表单
    /// </summary>
    public class WfForm
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 自定义表单主键
        /// </summary>
        public string formId { get; set; }
        /// <summary>
        /// 表单名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 表单地址
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 自定义表单关联的字段
        /// </summary>
        public string field { get; set; }
    }
}
