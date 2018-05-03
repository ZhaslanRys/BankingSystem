using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class PaymentHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Purse")]
        public int PurseId { get; set; }
        public int Count { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual User User { get; set; }
        public virtual Purse Purse { get; set; }
    }
}
