using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsDomain.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int ExpenseGroupId { get; set; }
        //Foreign Key to ExpenseGroup
        public virtual ExpenseGroup ExpenseGroup { get; set; }

    }
}
