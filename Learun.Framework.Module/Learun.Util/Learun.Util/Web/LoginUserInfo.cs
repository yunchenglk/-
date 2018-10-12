using System.Web;

namespace Learun.Util
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2017.03.08
    /// 描 述：当前上下文执行用户信息获取
    /// </summary>
    public static class LoginUserInfo
    {
        /// <summary>
        /// 获取当前上下文执行用户信息
        /// </summary>
        /// <returns></returns>
        public static UserInfo Get()
        {
            return (UserInfo)HttpContext.Current.Items["LoginUserInfo"];
        }
    }
}
