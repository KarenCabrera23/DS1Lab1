﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DeleteVideo()
        {
            return View();
        }

        public ActionResult AddVideo()
        {
            return View();
        }

        public ActionResult UpdateVideo()
        {
            return View();
        }

        public ActionResult DeleteReproduccionesVideo()
        {
            return View();
        }
       
    }
}
