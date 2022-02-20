using Bruhinterview.Api.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhinterview.Api.Controllers
{
    [ApiController]
    public class RestController : Controller
    {
        [HttpGet]
        [Route("api/users/query")]
        public async Task<IEnumerable<UserDocument>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/users/{id}")]
        public async Task<UserDocument> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/users")]
        public async Task CreateUser(UserDocument userDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/users/{id}")]
        public async Task ChangeUser(UserDocument userDocument)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/users/{id}")]
        public async Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/magazines/query")]
        public async Task<IEnumerable<MagazineDocument>> GetAllMagazines()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/magazines/{id}")]
        public async Task<MagazineDocument> GetMagazine(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/magazines")]
        public async Task CreateMagazine(MagazineDocument magazineDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/magazines/{id}")]
        public async Task ChangeMagazine(MagazineDocument magazineDocument)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/magazines/{id}")]
        public async Task DeleteMagazine(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/subsriptions/query")]
        public async Task<IEnumerable<SubscriprionDocument>> GetAllSubscriptions()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/subsriptions/{id}")]
        public async Task<SubscriprionDocument> GetSubscription(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("api/subsriptions")]
        public async Task CreateSubscription(SubscriprionDocument subscriprionDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/subsriptions/{id}")]
        public async Task ChangeSubscription(SubscriprionDocument subscriprionDocument)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/subsriptions/{id}")]
        public async Task DeleteSubscription(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
