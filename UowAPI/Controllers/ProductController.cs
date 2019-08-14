using Business;
using Business.Interface;
using System.Web.Http;

namespace UowAPI.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {

        private readonly IProductBusiness _productService;

        public ProductController(IProductBusiness productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IHttpActionResult Index() {
            var productList = _productService.GetAllProducts();
            return Ok(productList);
        }
    }
}
