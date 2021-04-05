using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Models.ViewModel;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;
        // GET: Catalogue
        public IActionResult Index(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = Repository.Products.Count()
                }, 
                CurrentCategory = category
            };
            return View(model);
        }
    }
}