using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.API.Controllers
{
    [ApiController]
    [Route("[Controller]/v1")] // TODO: Custom Annotation para Versioning
    [Authorize] // TODO: Custom Annotation to validate Federated Identities
    public class InventoryController : Controller
    {
        [HttpPost]
        [Authorize] // TODO: Custom Annotation to grant access to the operation
        public Task Create()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Authorize] // TODO: Custom Annotation to grant access to the operation
        public Task Update(Guid Id) 
        {
            throw new NotImplementedException(); 
        }

        [HttpDelete]
        [Authorize] // TODO: Custom Annotation to grant access to the operation
        public Task Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Authorize] // TODO: Custom Annotation to grant access to the operation
        public Task<object> Get(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
