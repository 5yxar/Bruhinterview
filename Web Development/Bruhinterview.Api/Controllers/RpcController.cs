using Bruhinterview.Api.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhinterview.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class RpcController : Controller
    {
        [HttpPost]
        [Route("getAllUsers")]
        public async Task<IEnumerable<UserDocument>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("getUser/{id}")]
        public async Task<UserDocument> GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("createUser")]
        public async Task CreateUser(UserDocument userDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("changeUser/{id}")]
        public async Task ChangeUser(UserDocument userDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("deleteUser/{id}")]
        public async Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("getAllMagazines")]
        public async Task<IEnumerable<MagazineDocument>> GetAllMagazines()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("getMagazine/{id}")]
        public async Task<MagazineDocument> GetMagazine(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("createMagazine")]
        public async Task CreateMagazine(MagazineDocument magazineDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("changeMagazine/{id}")]
        public async Task ChangeMagazine(MagazineDocument magazineDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("deleteMagazine/{id}")]
        public async Task DeleteMagazine(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("user/{userId}/getAllSubscribtions/")]
        public async Task GetAllSubscribes(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("user/{userId}/getSubscribtion/{magazineId}")]
        public async Task GetAllSubscribes(Guid userId, Guid magazineId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/user/{userId}/subscribe/{magazineId}")]
        public async Task CreateSubscribtion(Guid userId, Guid magazineId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/user/{userId}/changeSubscribtion/{magazineId}")]
        public async Task ChangeSubscribtion(Guid userId, Guid magazineId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/user/{userId}/deletSubscribtion/{magazineId}")]
        public async Task DeleteSubscribtion(Guid userId, Guid magazineId)
        {
            throw new NotImplementedException();
        }
    }
}
