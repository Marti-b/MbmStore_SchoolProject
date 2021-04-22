using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Data;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MbmStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private MbmStoreContext dataContext;

        public NavigationMenuViewComponent(MbmStoreContext dbContext)
        {
            dataContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(dataContext.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
