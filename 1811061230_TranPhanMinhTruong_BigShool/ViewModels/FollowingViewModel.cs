using _1811061230_TranPhanMinhTruong_BigShool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811061230_TranPhanMinhTruong_BigShool.ViewModels
{
    public class FollowingViewModel
    {

        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}