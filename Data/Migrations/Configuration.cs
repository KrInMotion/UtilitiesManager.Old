namespace Data.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.UtilitiesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.UtilitiesContext context)
        {
            /*context.MonthSet.AddOrUpdate(GenerateMonth());
            context.BillTypeSet.AddOrUpdate(GenerateBillType());
            context.BillProviderSet.AddOrUpdate(GenerateBillProvider());*/
        }

        private Month[] GenerateMonth()
        {
            Month[] months = new Month[]
            {
                new Month {Id=1, Name="������" },
                new Month {Id=2, Name="�������" },
                new Month {Id=3, Name="����" },
                new Month {Id=4, Name="������" },
                new Month {Id=5, Name="���" },
                new Month {Id=6, Name="����" },
                new Month {Id=7, Name="����" },
                new Month {Id=8, Name="������" },
                new Month {Id=9, Name="��������" },
                new Month {Id=10, Name="�������" },
                new Month {Id=11, Name="������" },
                new Month {Id=12, Name="�������" },
             };
            return months;
        }
        private BillType[] GenerateBillType()
        {
            BillType[] billTypes = new BillType[]
            {
                new BillType {TypeName = "��������� �� ���" },
                new BillType {TypeName = "��������� �� ��������������" }
            };
            return billTypes;
        }

        private BillProvider[] GenerateBillProvider()
        {
            BillProvider[] providers = new BillProvider[]
            {
                new BillProvider {ProviderName = "��� \"�������� �������������� ��������\"" },
                new BillProvider {ProviderName = "��� \"����-�\"" },
                new BillProvider {ProviderName = "��� �����" }
            };
            return providers;
        }
    }
}
