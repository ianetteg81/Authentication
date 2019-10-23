using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authenticate.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int HourlyRate { get; set; }

        [ForeignKey("DID")]
        public Departments DeptId { get; set; }


    }
    

}
