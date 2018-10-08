
namespace Learun.Application.BaseModule.CodeGeneratorModule
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.10.10
    /// 描 述：基础设置
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// 创建人员
        /// </summary>
        public string createUser { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 功能描述
        /// </summary>
        public string describe { get; set; }
        /// <summary>
        /// 输出区域
        /// </summary>
        public string outputArea { get; set; }

        /// <summary>
        /// 映射类输出目录
        /// </summary>
        public string mappingDirectory { get; set; }
        /// <summary>
        /// 后端类输出目录
        /// </summary>
        public string serviceDirectory { get; set; }
        /// <summary>
        /// 前端项输出目录
        /// </summary>
        public string webDirectory { get; set; }
        /// <summary>
        /// 接口输出目录
        /// </summary>
        public string apiDirectory { get; set; }
        /// <summary>
        /// 移动端输出目录
        /// </summary>
        public string appDirectory { get; set; }
    }
}
