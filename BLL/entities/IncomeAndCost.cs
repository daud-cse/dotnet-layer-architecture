using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.entities
{
    [Table("IncomeAndCost")]
    public class IncomeAndCost
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int HeadTypeId { get; set; }
        public string Description { get; set; }
   
    }
}
