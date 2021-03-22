﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public RedirectToActionResult AddToCart(int id, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductID == id);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToActionResult RemoveFromCart(int id, string returnUrl)
        {
            Product product = Repository.Products.Find(p => p.ProductID == id);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.RemoveLines(product);
            }
            return RedirectToAction("Index", new {returnUrl});
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart");
            if (cart != null)
            {
                cart = new Cart();
                HttpContext.Session.SetJson("Cart", cart);
            }

            return cart;
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

    }
}
