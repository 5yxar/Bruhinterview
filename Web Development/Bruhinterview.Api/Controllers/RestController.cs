using Bruhinterview.Api.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhinterview.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class RestController : Controller
    {
        [HttpGet]
        [Route("query")]
        public async Task<IEnumerable<UserDocument>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<UserDocument> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task CreateUser(UserDocument userDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task ChangeUser(UserDocument userDocument)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
