﻿
namespace EmployeeClient
{
    public class EmpViewModel
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }= string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
       
        public string City { get; set; } = string.Empty;
        public int? ReportTo { get; set; }
    }
}
