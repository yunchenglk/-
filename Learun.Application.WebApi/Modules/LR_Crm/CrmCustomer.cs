using Learun.Application.CRM;
using Nancy;

namespace Learun.Application.WebApi.Modules.LR_Crm
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.07.10
    /// 描 述：客户管理
    /// </summary>
    public class CrmCustomer: BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public CrmCustomer()
            : base("/learun/adms/crm/customer")
        {
            Get["/list"] = GetList;// 获取客户列表
        }

        private CrmCustomerIBLL crmCustomerIBLL = new CrmCustomerBLL();

        /// <summary>
        /// 获取客户列表
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response GetList(dynamic _)
        {
            var list = crmCustomerIBLL.GetList();
            return Success(list);
        }
    }
}