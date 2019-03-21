using System.Web.Http;

namespace WebApiSegura.Controllers
{
    /// <summary>
    /// customer controller class for testing security token 
    /// </summary>
    [Authorize]
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "customer-fake: " + id;
            return Ok(customerFake);
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            var customersFake = new string[] { "customer-1", "customer-2", "customer-3" };
            return Ok(customersFake);
        }
    }
}
