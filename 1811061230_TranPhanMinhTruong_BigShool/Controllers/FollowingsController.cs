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

            following = _dbContext.Followings
               .Where(x => x.FolloweeId == followingDTO.FolloweeId && x.FollowerId == userId)
               .Include(x => x.Followee)
               .Include(x => x.Follower).SingleOrDefault();

            var followingNotification = new FollowingNotification()
            {
                Id = 0,
                Logger = following.Follower.Name + " following " + following.Followee.Name
            };
            _dbContext.FollowingNotifications.Add(followingNotification);
            _dbContext.SaveChanges();



            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult UnFollow(string followeeId, string followerId)
        {
            var follow = _dbContext.Followings
                .Where(x => x.FolloweeId == followeeId && x.FollowerId == followerId)
                .Include(x => x.Followee)
                .Include(x => x.Follower).SingleOrDefault();

            var followingNotification = new FollowingNotification()
            {
                Id = 0,
                Logger = follow.Follower.Name + " unfollow " + follow.Followee.Name
            };

            _dbContext.FollowingNotifications.Add(followingNotification);

            _dbContext.Followings.Remove(follow);
            _dbContext.SaveChanges();
            return Ok();
        }


    }
}
