using EgiantsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsDomain
{
   public  class EgiantsContext:DbContext,IEgiantsContext
    {
        static EgiantsContext()
        {
            Database.SetInitializer<EgiantsContext>(null);
        }
        public EgiantsContext():base("Name=Egiants")
        {

        }
        public virtual IDbSet<Expense> Expenses { get; set; }
        public virtual IDbSet<ExpenseGroup> ExpenseGroups { get; set; }
        public virtual IDbSet<ExpenseGroupStatus> ExpenseGroupStatuses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ExpenseGroupStatusConfiguration());
        }
    }
}
