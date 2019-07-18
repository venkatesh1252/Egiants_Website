using EgiantsDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsDomain
{
    public interface IEgiantsContext
    {
        IDbSet<Expense> Expenses { get; set; }
        IDbSet<ExpenseGroup> ExpenseGroups { get; set; }
        IDbSet<ExpenseGroupStatus> ExpenseGroupStatuses { get; set; }
    }
}
