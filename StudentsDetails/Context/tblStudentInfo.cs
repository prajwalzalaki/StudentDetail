//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsDetails.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblStudentInfo
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Required")]
        [MinLength(10, ErrorMessage = "Mobile No should be 11 digit")]
        [MaxLength(10, ErrorMessage = "Mobile No should be 11 digit")]
        public string StudentMobile { get; set; }
        [Required(ErrorMessage = "Required")]
        public string StudentDept { get; set; }
        [Required(ErrorMessage = "Required")]
        public string StudentAddress { get; set; }
    }
}
