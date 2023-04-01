using ChauGiaChan_2011068805.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChauGiaChan_2011068805.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}