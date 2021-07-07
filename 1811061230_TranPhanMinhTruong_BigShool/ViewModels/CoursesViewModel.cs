using _1811061230_TranPhanMinhTruong_BigShool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811061230_TranPhanMinhTruong_BigShool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public IEnumerable<Following> Followings { get; set; }
        public IEnumerable<Attendance> Attendances { get; set; }
        public bool ShowAction { get; set; }
    }
}