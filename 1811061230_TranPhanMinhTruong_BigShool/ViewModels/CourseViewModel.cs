using _1811061230_TranPhanMinhTruong_BigShool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _1811061230_TranPhanMinhTruong_BigShool.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Attendance> Attendances { get; set; }
        public IEnumerable<Following> Followings { get; set; }
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        public int Id { get; set; }

        [Required] public string Place { get; set; }
        [FutureDate] [Required] public string Date { get; set; }
        [ValidTime] [Required] public string Time { get; set; }
        [Required] public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0},{1}", Date, Time));
        }

        public string Heading { get; set; }

        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }

    }

}
