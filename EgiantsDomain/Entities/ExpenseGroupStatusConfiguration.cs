using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsDomain.Entities
{
    public class ExpenseGroupStatusConfiguration:EntityTypeConfiguration<ExpenseGroupStatus>
    {
        public ExpenseGroupStatusConfiguration(string schema="dbo")
        {
            ToTable(schema + ".ExpenseGroupStatus");
            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired();
            Property(x => x.Description).IsRequired();
        }
    }
}
