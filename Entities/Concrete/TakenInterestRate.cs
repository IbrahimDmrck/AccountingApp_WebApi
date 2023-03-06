using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TakenInterestRate : IEntity
    {
        public int Id { get; set; }
        public string ReceiptName { get; set; }
        public DateTime Date { get; set; }
        public int CurrentAccountId { get; set; }
        public DateTime IssueDate { get; set; }

        public string Description { get; set; }
    }
}
