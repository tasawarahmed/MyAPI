using System;
using System.Collections.Generic;

namespace MyAPI.Models
{
    public partial class TblTeacherMain
    {
        public int TeacherId { get; set; }
        public string? FacultyId { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public string? Gender { get; set; }
        public string? Subjective { get; set; }
        public string? Objective { get; set; }
        public string? Possessive { get; set; }
        public DateTime? Dob { get; set; }
        public string? Cnic { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? HomeTelNo { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public string? StreetAddress { get; set; }
        public string? Town { get; set; }
        public string? PrimaryQualification { get; set; }
        public string? Institute { get; set; }
        public string? EducationalQualifications { get; set; }
        public int? PrimarySubject { get; set; }
        public int? SecondarySubject { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public long? StartingSalary { get; set; }
        public DateTime? LastIncrementDate { get; set; }
        public long? CurrentGrossSalary { get; set; }
        public string? RemarksAtJoining { get; set; }
        public int? TransactionAccountId { get; set; }
        public bool? IsTeacher { get; set; }
        public bool? IsPotentialTeacher { get; set; }
        public bool? WasStaff { get; set; }
        public DateTime? DateOfTermination { get; set; }
        public int? ReasonOfTermination { get; set; }
        public string? RemarksAtTermination { get; set; }
        public byte[]? Image { get; set; }
        public int? TFingerPrint { get; set; }
        public byte[]? Photo { get; set; }
        public int? StaffCategoryId { get; set; }
    }
}
