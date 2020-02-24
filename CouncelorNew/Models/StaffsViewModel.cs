using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouncelorNew.Models
{
    public class StaffsViewModel
    {
        public int StaffId { get; set; }
        public string UserName { get; set; }
        public string Designation { get; set; }
        public bool IsDeleted { get; set; }
    }
}