using Learun.Application.CRM;
using Nancy;

namespace Learun.Application.WebApi
{
    /// <summary>
    /// 版 本 V2.3 辰星软件开发框架
    /// Copyright (c) 2013-2020 山西辰星软件科技有限公司
    /// 创建人：System
    /// 日 期：2018.03.22
    /// 描 述：开票信息
    /// </summary>
    public class Invoice: BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public Invoice()
            : base("/learun/adms/crm/invoice")
        {
            Get["/list"] = GetList;// 获取开票信息列表

            Post["save"] = Save;
        }
        private CrmInvoiceIBLL crmInvoiceIBLL = new CrmInvoiceBLL();

        /// <summary>
        /// 获取客户端数据
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response GetList(dynamic _)
        {
            ReqPageParam parameter = this.GetReqData<ReqPageParam>();

            var list = crmInvoiceIBLL.GetPageList(parameter.pagination, parameter.queryJson);
            var jsonData = new
            {
                rows = list,
                total = parameter.pagination.total,
                page = parameter.pagination.page,
                records = parameter.pagination.records,
            };
            return Success(jsonData);
        }

        /// <summary>
        /// 获取客户端数据
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response Save(dynamic _)
        {
            ReqEntity<CrmInvoiceEntity> parameter = this.GetReqData<ReqEntity<CrmInvoiceEntity>>();
            crmInvoiceIBLL.SaveEntity(parameter.keyValue, parameter.entity);
            return Success("保存成功");
        }
    }
}