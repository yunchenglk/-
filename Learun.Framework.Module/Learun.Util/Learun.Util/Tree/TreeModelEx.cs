﻿
using System.Collections.Generic;
namespace Learun.Util
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2017.03.07
    /// 描 述：树结构数据
    /// </summary>
    public class TreeModelEx<T> where T : class
    {
        /// <summary>
        /// 节点id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 父级节点ID
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T data { get; set; }
        /// <summary>
        /// 子节点列表数据
        /// </summary>
        public List<TreeModelEx<T>> ChildNodes { get; set; }
    }
}
