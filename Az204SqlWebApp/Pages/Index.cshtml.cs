using Az204SqlWebApp.Models;
using Az204SqlWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Az204SqlWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<ProductModel> Products;
        public bool IsBeta;
        public void OnGet()
        {
            IsBeta = _productService.IsBeta().Result;
            Products = _productService.GetProducts();

        }
    }
}