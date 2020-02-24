using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseContext
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffId { get; set; }
        public string UserName { get; set; }
        public string Designation { get; set; }
        public bool IsDeleted { get; set; }
    }
}
