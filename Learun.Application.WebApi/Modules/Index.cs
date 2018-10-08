using Nancy;

namespace Learun.Application.WebApi
{
    /// <summary>  
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2017.05.12
    /// 描 述：默认页面
    /// </summary>
    public class Index : BaseApi
    {
        public Index()
            : base()
        {
            Get["/"] = MainIndex;
            Get["/bgimg"] = BgImg;
        }
        /// <summary>
        /// 默认开始页面
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response MainIndex(dynamic _)
        {
            return Response.AsFile("index.html");
        }
        /// <summary>
        /// 默认开始页面图片
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response BgImg(dynamic _)
        {
            return Response.AsImage("port.png");
        }
    }
}