﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace the2000s.com.vn.Areas.Admin.Controllers
{
    public class PostController : Controller
    {
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Cat()
        {
            return View();
        }
    }
}