using AutoMapper;
using Core.Models;
using Infrastructure.Abstractions;
using Infrastructure.DataTransferObjects;
using LogServices.Abstraction;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogImplementations _logImplementations;

        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;

        private readonly IAuthenticationManager _authenticationManager;

        public AuthenticationController(ILogImplementations logImplementations,
            UserManager<User> userManager,
            IMapper mapper,
            IAuthenticationManager authenticationManager)
        {
            _logImplementations = logImplementations;

            _userManager = userManager;

            _mapper = mapper;

            _authenticationManager = authenticationManager;
        }

        // GET: api/<AuthenticationController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // POST api/<AuthenticationController>/5
        [HttpPost("Sign Up")]
        public async Task<IActionResult> CreateUser([FromBody] UserForRegistrationDTO userForRegistrationDTO)
        {
            if (userForRegistrationDTO == null)
            {
                _logImplementations.ErrorMessage($"User object passed by the client is null");

                return BadRequest();
            }
            else
            {
                var user = _mapper.Map<User>(userForRegistrationDTO);

                var result = await _userManager.CreateAsync(user, userForRegistrationDTO.Password);

                if (!result.Succeeded)
                {
                    foreach(var errors in result.Errors)
                    {
                        ModelState.TryAddModelError(errors.Code, errors.Description);
                    }

                    return BadRequest(ModelState);
                }

                await _userManager.AddToRolesAsync(user, userForRegistrationDTO.Roles);

                return StatusCode(201);
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDTO userForAuthentication)
        {
            if (userForAuthentication == null)
            {
                _logImplementations.ErrorMessage("User object passed by the client is null");

                return Unauthorized();
            }
            else
            {
                if (!await _authenticationManager.ValidateUser(userForAuthentication))
                {
                    _logImplementations.WarningMessage($"{nameof(Login)}: Authentication Failed. Wrong Username or Password.");

                    return Unauthorized("Wrong Username or Password.");
                }

                return Ok(new { Token = await _authenticationManager.CreateToken() });
            }
        }

        // Get api/<AuthenticationController>
        //ttpGet("{id}")]
        //public void Get(int id)
        //{
        //}

        // PUT api/<AuthenticationController>/5
       //HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<AuthenticationController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
