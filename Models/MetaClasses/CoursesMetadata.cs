﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models.MetaClasses
{
    [authorize]
    public class CoursesMetadata
    {
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1,8)]
        public int Credits { get; set; }

    }
          [MetadataType(typeof(CoursesMetadata))]
         public partial class Course
    {


    }
}