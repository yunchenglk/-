﻿
namespace Learun.Application.Base.SystemModule
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.04.01
    /// 描 述：编号规则
    /// </summary>
    public class CodeRuleFormatModel
    {
        #region 实体成员
        /// <summary>
        /// 项目类型
        /// </summary>		
        public int? itemType { get; set; }
        /// <summary>
        /// 项目类型名称
        /// </summary>		
        public string itemTypeName { get; set; }
        /// <summary>
        /// 格式化字符串
        /// </summary>		
        public string formatStr { get; set; }
        /// <summary>
        /// 步长
        /// </summary>		
        public int? stepValue { get; set; }
        /// <summary>
        /// 初始值
        /// </summary>		
        public int? initValue { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        public string description { get; set; }
        #endregion
    }
}
