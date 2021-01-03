using Rachunki.Model;
using System.Data.Entity.ModelConfiguration;

namespace Rachunki.DBContext
{
    public class BillMap : EntityTypeConfiguration<Bill>
    {
        public BillMap()
        {
            ToTable("Bill");

            Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.Label).IsRequired();
            Property(p => p.Frequency).IsRequired();
            Property(p => p.IsPaid).IsRequired();
            Property(p => p.MarkedAsPaidDate).IsOptional();
            Property(p => p.PaymentDate).IsRequired();
            Property(p => p.Value).IsRequired();
        }
    }
}
