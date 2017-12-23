using System;
using System.Collections.Generic;
using System.Linq                                           ;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Models;
using Microsoft.EntityFrameworkCore;

namespace NewsBack.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        //[Route("user/all")]
        public Task<List<Users>> GetAll()
        {
            return _userService.Get();
        }

        [Route("user/{email}")]
        public Task<List<Users>> GetEmail(string email)
        {
            return _userService.GetByEmailID(email);
        }

        [HttpPost]
        //[Route("user/add")]
        public void PostNew([FromBody] Users item)
        {
            
            _userService.Post(item);
        }
    }
}
/* 






        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    } */