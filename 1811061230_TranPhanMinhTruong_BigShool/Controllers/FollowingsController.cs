using _1811061230_TranPhanMinhTruong_BigShool.DTOs;
using _1811061230_TranPhanMinhTruong_BigShool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811061230_TranPhanMinhTruong_BigShool.Controllers
{
    public class FollowingsController : ApiController
    {

        private ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDTO)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(a => a.FollowerId == userId && a.FolloweeId == followingDTO.FolloweeId))
            {
                return BadRequest("The Attendance already exits");
            }

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDTO.FolloweeId
            };

            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();



            return Ok();
        }
    }
}
