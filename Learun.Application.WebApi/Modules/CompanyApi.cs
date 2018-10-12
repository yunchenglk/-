﻿using Learun.Application.Organization;
using Learun.Util;
using Nancy;

namespace Learun.Application.WebApi.Modules
{
    /// <summary>
    /// 版 本V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2018 山西辰星昇软件科技有限公司
    /// 创建人：辰星科技 软件开发部
    /// 日 期：2018.01.04
    /// 描 述：公司管理
    /// </summary>
    public class CompanyApi: BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public CompanyApi()
            : base("/learun/adms/company")
        {
            Get["/list"] = GetList;// 获取公司数据列表

            Get["/map"] = GetMap;// 获取公司数据列表
        }
        private CompanyIBLL companyIBLL = new CompanyBLL();

        /// <summary>
        /// 获取公司数据列表
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response GetList(dynamic _)
        {
            string req = this.GetReqData();// 获取模板请求数据
            var data = companyIBLL.GetList();
            return Success(data);
        }
        /// <summary>
        /// 获取公司映射表
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        public Response GetMap(dynamic _)
        {
            string ver = this.GetReqData();// 获取模板请求数据
            var data = companyIBLL.GetModelMap();
            string md5 = Md5Helper.Encrypt(data.ToJson(), 32);
            if (md5 == ver)
            {
                return Success("no update");
            }
            else
            {
                var jsondata = new
                {
                    data = data,
                    ver = md5
                };
                return Success(jsondata);
            }
        }

    }
}