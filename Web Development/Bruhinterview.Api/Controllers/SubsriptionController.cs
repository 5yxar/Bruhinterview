using Bruhinterview.Api.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhinterview.Api.Controllers
{
    [ApiController]
    [Route("api/subsriptions")]
    public class SubsriptionController : Controller
    {
        [HttpGet]
        [Route("query")]
        public async Task<IEnumerable<SubscriprionDocument>> GetAllSubscriptions()
        {
            throw new NotImplementedException();
        }

        
        [HttpGet]
        [Route("{id}")]
        public async Task<SubscriprionDocument> GetSubscription(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task CreateSubscription(SubscriprionDocument subscriprionDocument)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task ChangeSubscription(SubscriprionDocument subscriprionDocument)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteSubscription(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
