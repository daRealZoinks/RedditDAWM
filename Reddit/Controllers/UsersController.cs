using Core.Dtos;
using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Reddit.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private UserService UserService { get; }

        public UsersController(UserService userService)
        {
            UserService = userService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<User>> GetAll()
        {
            var results = UserService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{userId:int}")]
        public ActionResult<User> GetById(int userId)
        {
            var result = UserService.GetById(userId);

            return Ok(result);
        }

        [HttpPatch("edit-username")]
        public ActionResult<bool> GetById([FromBody] UserUpdateDto userUpdateDto)
        {
            var result = UserService.EditUsername(userUpdateDto);

            if (!result)
            {
                return BadRequest("User could not be updated");
            }

            return result;
        }

        [HttpPost("add")]
        public ActionResult<bool> Add([FromBody] User user)
        {
            UserService.Add(user);

            return Ok();
        }

        [HttpDelete("delete/{userId:int}")]
        public ActionResult<bool> Delete(int userId)
        {
            UserService.Delete(userId);

            return Ok();
        }
    }
}