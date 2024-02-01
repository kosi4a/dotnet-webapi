using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class OrganizationsController : ControllerBase
    {
        public Task<int> GetTask(int id)
        {
            return Task.FromResult(0);
        }
    }
}
