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
        [Route("magazine/{magazineId}/subscribe/{userId}")]
        public async Task DeleteMagazine(Guid magazineId, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
