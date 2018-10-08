using Learun.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// �� �� V2.3 ��������������
    /// Copyright (c) 2013-2020 ɽ����������Ƽ����޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 14:20
    /// �� �����ֽ����
    /// </summary>
    public class CrmCashBalanceMap : EntityTypeConfiguration<CrmCashBalanceEntity>
    {
        public CrmCashBalanceMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_CASHBALANCE");
            //����
            this.HasKey(t => t.F_CashBalanceId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

