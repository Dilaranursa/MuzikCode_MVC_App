using MuziCodeWepApp.Areas.ManegerPanel.Data;
using MuziCodeWepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuziCodeWepApp.Areas.ManegerPanel.Controllers
{
    public class LoginController : Controller
    {
        MuzicCodeDBModel db = new MuzicCodeDBModel();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ManegerLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Manager m = db.Manager.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                if (m != null)
                {
                    Session["Manager"] = m;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mesaj("Kullanıcı hesabınız askıya alınmıştır.");
                }
            }
            else
            {
                ViewBag.mesaj("Kullanıcı Bulunamadı .");
            }
            return View(model);

        }
    }
}