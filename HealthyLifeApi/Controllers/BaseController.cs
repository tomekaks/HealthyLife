using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [ApiController]
    
    public abstract class BaseController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;

        protected BaseController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        //protected string CurrentUserId => _contextAccessor.HttpContext?.User?.FindFirst("uid").Value;
        protected string CurrentUserId => "9ef201b2-999c-4161-8f2b-d7994971e5ee";
    }
}
