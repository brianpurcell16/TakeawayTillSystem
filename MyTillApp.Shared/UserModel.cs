using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTillApp.Shared
{

    [Table("Employees")]
    public class UserModel
    {
        [Key]
        [Column("EmpID")]
        public int EmpID { get; set; }
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        [Column("EmpRank")]
        public String? Rank { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
    }
}
