using System.Web.Http;
using BusinessContracts.Contracts;
using Domain.Models;

namespace UowAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {

        private readonly IBusinessFactory _businessFactory;

        public ProductController(IBusinessFactory businessFactory)
        {
            _businessFactory = businessFactory;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IHttpActionResult Index() {
            var productService = _businessFactory.GetBusinessClass<IProductBusiness>();
            var productList = productService.GetAllProducts();
            return Ok(productList);
        }

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create(ProductModel productModel)
        {
            var productService = _businessFactory.GetBusinessClass<IProductBusiness>();
            var resultProduct = productService.CreateProduct(productModel);
            return Ok(resultProduct);
        }
    }
}
