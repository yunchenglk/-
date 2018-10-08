using Learun.Application.Base.AuthorizeModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>
    /// �� �� V2.3 ��������������
    /// Copyright (c) 2013-2020 ɽ����������Ƽ����޹�˾
    /// �� ���������ܿ�����
    /// �� �ڣ�2017-06-21 16:30
    /// �� ��������Ȩ��
    /// </summary>
    public class DataAuthorizeConditionMap : EntityTypeConfiguration<DataAuthorizeConditionEntity>
    {
        public DataAuthorizeConditionMap()
        {
            #region ������
            //��
            this.ToTable("LR_BASE_DATACONDITION");
            //����
            this.HasKey(t => t.F_Id);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

