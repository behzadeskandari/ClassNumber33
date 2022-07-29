using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;
using System.Security.Claims;

namespace API.Controllers
{

    public class UserController : BaseController
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            
            return _context.Users.ToList();
        }

        [HttpGet("{Id}")]
        public ActionResult<AppUser> getUserById(int Id)
        {
            //if (!HttpContext.User.IsInRole("manager"))
            //{
            //    return StatusCode(304);
            //}
            //if (Id == 5)
            //{
            //    return StatusCode(500);
            //}
            
            return _context.Users.Find(Id);
            

            //return _context.Users.First(x => x.Id == Id);
            //return _context.Users.Any(x => x.Id == Id); //Wrong
        }



    }
}
