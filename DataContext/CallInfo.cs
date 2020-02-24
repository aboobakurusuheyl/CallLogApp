using System;

namespace DatabaseContext
{
    public class CallInfo
    {
        public int CallInfoId { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Summary { get; set; }
        public string CallDuration { get; set; }
        public DateTime Dob { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int StaffId { get; set; }
        public int StatusId { get; set; }
        public int CallCategoryId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
