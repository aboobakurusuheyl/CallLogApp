using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouncelorNew.Models
{
    public class DashboardViewModel
    {
        public int Total { get; set; }
        public int Today { get; set; }
        public int Resolved { get; set; }
        public int Pending { get; set; }
    }
}