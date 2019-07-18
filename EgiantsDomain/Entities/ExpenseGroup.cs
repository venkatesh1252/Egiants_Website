﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsDomain.Entities
{
   public class ExpenseGroup
    {
        public ExpenseGroup()
        {
            Expenses = new List<Expense>();
        }
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ExpenseGroupStatusId { get; set; }
        //Foreign Key to ExpenseGroupStatus
        public virtual ExpenseGroupStatus ExpenseGroupStatus { get; set; }
        //Reverse Navigation to Expense 
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
