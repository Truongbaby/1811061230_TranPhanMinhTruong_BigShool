using _1811061230_TranPhanMinhTruong_BigShool.DTOs;
using _1811061230_TranPhanMinhTruong_BigShool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace _1811061230_TranPhanMinhTruong_BigShool.Controllers
{
    public class FollowingsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Followings
       

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
                return BadRequest
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