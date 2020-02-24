using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CouncelorNew.Models
{
    public class CallInfoView
    {
        public int CallInfoId { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name Required")]
        public string FullName { get; set; }
        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Contact Number Required")]
        public string Contact { get; set; }
        public string Address { get; set; }
        [Display(Name = "Call Summary")]
        [Required(ErrorMessage = "Call Summary Required")]
        public string Summary { get; set; }
        public string CallDuration { get; set; }
        public DateTime Dob { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int StaffId { get; set; }
        public int StatusId { get; set; }
        public int CallCategoryId { get; set; }
        public bool IsDeleted { get; set; }

        public List<CategoriesViewModel> CategoriesList { get; set; }
        public List<StaffsViewModel> StaffsList { get; set; }

    }
}