using Learun.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>
    /// �� �� V2.3 ��������������
    /// Copyright (c) 2013-2020 ɽ����������Ƽ����޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 11:20
    /// �� ����������¼
    /// </summary>
    public class CrmTrailRecordMap : EntityTypeConfiguration<CrmTrailRecordEntity>
    {
        public CrmTrailRecordMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_TRAILRECORD");
            //����
            this.HasKey(t => t.F_TrailId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

