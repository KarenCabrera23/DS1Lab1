using System;
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

       public ActionResult VerVideo()
       {
           ViewData["Video"] = BaseHelper.ejecutarConsulta("SELECT * FROM video", CommandType.Text);
           return View();
       }

         public ActionResult DeleteVideo()
       {
           
          return View();
       }
        [HttpPost]
        public ActionResult Delete(int IdVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));

            BaseHelper.ejecutarSentencia("DELETE FROM video "+ "WHERE idVideo = @idVideo", CommandType.Text, parametros);
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddVideo()
        {
          return View();
        }
         [HttpPost]
        public ActionResult AddVideo(int IdVideo,string Titulo, int Repro, string Url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@Titulo", Titulo));
            parametros.Add(new SqlParameter("@Repro", Repro));
            parametros.Add(new SqlParameter("@Url", Url));
            BaseHelper.ejecutarSentencia("INSERT INTO Video " + "VALUES(@idVideo,@titulo," + "@repro ,@url)", CommandType.Text,parametros);


            return RedirectToAction("Index", "Home");
        }
       
        public ActionResult UpdateVideo()
    {
        
        return View();
    }
     [HttpPost]
        public ActionResult UpdateVideo(int IdVideo, string Titulo, int Repro, string Url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@Titulo", Titulo));
            parametros.Add(new SqlParameter("@Repro", Repro));
            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.ejecutarSentencia("UPDATE Video SET IdVideo= @IdVideo, Titulo = @Titulo, Repro= @Repro, Url = @Url WHERE IdVideo = @IdVideo", CommandType.Text, parametros);
            return RedirectToAction("Index", "Home");
        }
    }
}
