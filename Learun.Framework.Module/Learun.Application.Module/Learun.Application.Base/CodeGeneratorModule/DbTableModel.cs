
namespace Learun.Application.BaseModule.CodeGeneratorModule
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：数据表配置信息
    /// </summary>
    public class DbTableModel
    {
        /// <summary>
        /// 数据表名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 数据表字段
        /// </summary>
        public string field { get; set; }
        /// <summary>
        /// 被关联表
        /// </summary>
        public string relationName { get; set; }
        /// <summary>
        /// 被关联表字段
        /// </summary>
        public string relationField { get; set; }
        /// <summary>
        /// 数据表主键
        /// </summary>
        public string pk { get; set; }
    }
}
