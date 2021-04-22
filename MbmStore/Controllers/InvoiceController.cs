using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Data;
using MbmStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private MbmStoreContext dataContext;


        public InvoiceController(MbmStoreContext dbContext)
        {
            dataContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.Invoices = dataContext.Invoices.Include(invoice => invoice.Customer);
            ViewBag.Order = dataContext.Invoices
                .Include(invoice => invoice.OrderItems)
                .ThenInclude(orderItem => orderItem.Product);

            return View();
        }
    }
}
