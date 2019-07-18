using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsDomain.Entities
{
    public class ExpenseGroupStatus
    {
        public ExpenseGroupStatus()
        {
            ExpenseGroups = new List<ExpenseGroup>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        //Reverse Navigation to Expense Group
        public virtual ICollection<ExpenseGroup> ExpenseGroups { get; set; }
    }
}
