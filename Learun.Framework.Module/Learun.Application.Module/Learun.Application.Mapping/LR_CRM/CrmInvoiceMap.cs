using Learun.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// �� ��V2.3 ��������������
    /// Copyright (c) 2013-2018 ɽ�����ǕN����Ƽ����޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 14:47
    /// �� ������Ʊ��Ϣ
    /// </summary>
    public class CrmInvoiceMap : EntityTypeConfiguration<CrmInvoiceEntity>
    {
        public CrmInvoiceMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_INVOICE");
            //����
            this.HasKey(t => t.F_InvoiceId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

