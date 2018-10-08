using Nancy;

namespace Learun.Application.WebApi.Modules
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2017.05.12
    /// 描 述：通用功能
    /// </summary>
    public class UtilityApi : BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public UtilityApi()
            : base("/learun/adms")
        {
            Get["/heart"] = Heart;
        }

        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response Heart(dynamic _)
        {
            return Success("成功");
        }
    }
}