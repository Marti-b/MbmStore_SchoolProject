using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Models.ViewModels;
using MbmStore.Data;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        private MbmStoreContext dataContext;
        public int PageSize = 4;

        public CatalogueController(MbmStoreContext dbContext)
        {
            dataContext = dbContext;
        }
        // GET: Catalogue
        public IActionResult Index(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = dataContext.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        dataContext.Products.Count() :
                        dataContext.Products.Where(e =>
                            e.Category == category).Count()
                }, 
                CurrentCategory = category
            };
            return View(model);
        }
    }
}