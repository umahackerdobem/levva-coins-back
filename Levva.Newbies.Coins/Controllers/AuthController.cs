using AutoMapper;
using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;
using Levva.Newbies.Coins.Logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IUserService _userService;
        readonly IMapper _mapper;

        public AuthController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<LoginResponseDto> Auth([FromBody] LoginDto loginDto)
        {
            var user = _userService.GetByEmailAndPassword(loginDto.Email, loginDto.Password);
            if(user == null) throw new NullReferenceException();

            var loginResponse = _mapper.Map<LoginResponseDto>(user);
            loginResponse.Token = TokenService.GenerateToken(user);

            return loginResponse;
        }
    }
}
