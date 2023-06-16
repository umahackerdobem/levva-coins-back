using Levva.Newbies.Coins.Data.Repositories;
using Levva.Newbies.Coins.Domain.Models;
using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;
using Levva.Newbies.Coins.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(CreateUserDto user)
        {
            _service.Create(user);
            return Created("", user);
        }

        [HttpGet]
        public ActionResult<UserDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet("list")]
        public ActionResult<List<UserDto>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPut]
        public IActionResult Update(UserDto user)
        {
            _service.Update(user);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
        }
    }
