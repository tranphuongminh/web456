using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web456.Models;

namespace web456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}