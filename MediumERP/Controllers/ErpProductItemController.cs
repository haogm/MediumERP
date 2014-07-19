using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediumERP.Models;

namespace MediumERP.Controllers
{
    public class ErpProductItemController : Controller
    {
        //
        // GET: /ErpProductItem/
        public ActionResult Index()
        {
            ProductItem product = new ProductItem{
                ProductID = "7000-6788"
            };
            ViewBag.mymessage = "动态生成的消息"; ;
            return View(product);
        }

        //
        // GET: /ErpProductItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ErpProductItem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ErpProductItem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ErpProductItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ErpProductItem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ErpProductItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ErpProductItem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
