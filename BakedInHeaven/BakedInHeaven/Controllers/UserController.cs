using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BakedInHeaven.API.Model;
using BakedInHeaven.API.Context;
using BakedInHeaven.Model;


namespace BakedInHeaven.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("Users")]
        [HttpGet]
        public List<User> GetAllUsers()
        {
            using var dbContext = new BakeryDbContext();
            return dbContext.Users.ToList();
        }

        [Route("user")]
        [HttpPost]
        public bool CreateUsers(User user)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            return true;


        }
    }
}