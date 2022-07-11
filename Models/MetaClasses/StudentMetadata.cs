using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SchoolManagement.Models
{
    public class StudentMetadata
    {
       [StringLength(50)]
       [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Date of Enrollment")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string MiddleName { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {


    }
}