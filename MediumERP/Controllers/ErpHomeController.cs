﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediumERP.Models;

namespace MediumERP.Controllers
{
    public class ErpHomeController : Controller
    {
        //
        // GET: /ErpHome/
        public ActionResult Index()
        {
            ProductItem product = new ProductItem { ProductID="7000-6788", ProductName="复印纸 A4 70g" };
            List<ProductItem> productList = new List<ProductItem>();
            productList.Add(product);

            SuggestedBigCategoryItems suggestedBigCategoryItems = new SuggestedBigCategoryItems();
            suggestedBigCategoryItems.bigCategory = new BigCategory { BigCategoryID="20", BigCategoryName="复印纸" };
            suggestedBigCategoryItems.suggestedProducts = productList;

            HomepageModel homepage = new HomepageModel();
            homepage.suggestedBigCategoryItems = suggestedBigCategoryItems;
            return View(homepage);
        }

        //
        // GET: /ErpHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ErpHome/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ErpHome/Create
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
        // GET: /ErpHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ErpHome/Edit/5
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
        // GET: /ErpHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ErpHome/Delete/5
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
