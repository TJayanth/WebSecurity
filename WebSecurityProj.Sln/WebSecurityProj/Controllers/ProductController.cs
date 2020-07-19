using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSecurityProj.Models;
using WebSecurityProj.DAL;
using Microsoft.AspNetCore.Authorization;

namespace WebSecurityProj.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TrackDelivery()
        {
            TrackDeliveryVM DeliveriesList = new TrackDeliveryVM()
            {
                DeliveriesList = new List<DeliveriesDTO>()
            };
            return View(DeliveriesList);
        }

        [HttpPost]
        public IActionResult TrackDelivery(TrackDeliveryVM trackDeliveryVM)
        {
            ProductDAL ProductDAL = new ProductDAL();

            List<DeliveriesDTO> DeliveriesList = ProductDAL.GetAllDeliveries(trackDeliveryVM.WayBillNo);
            trackDeliveryVM.DeliveriesList = DeliveriesList;
            return View(trackDeliveryVM);
        }


        [HttpGet]
        public IActionResult TrackDeliverySingle(string wayBillNo)
        {
            ProductDAL ProductDAL = new ProductDAL();

            List<DeliveriesDTO> DeliveriesList = ProductDAL.GetAllDeliveries(wayBillNo);
            TrackDeliveryVM trackDeliveryVM = new TrackDeliveryVM();
            trackDeliveryVM.DeliveriesList = DeliveriesList;
            return View(trackDeliveryVM.DeliveriesList.FirstOrDefault());
        }

        [HttpGet]
        [Authorize]
        public IActionResult ProductListing()
        {
            ProductDAL ProductDAL = new ProductDAL();
            List<ProductsDTO> productList = ProductDAL.GetAllProducts();
            ProductsDTO trackDeliveryVM = new ProductsDTO();
            return View(productList);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(ProductsDTO productsDTO)
        {
            ProductDAL ProductDAL = new ProductDAL();
            ProductDAL.SaveProduct(productsDTO);
            return RedirectToAction("ProductListing");
        }

        [HttpPost]
        [Authorize]
        public bool Delete(string productId)
        {
            ProductDAL ProductDAL = new ProductDAL();
            ProductDAL.DeleteProduct(productId);
            return true;
        }
    }
}