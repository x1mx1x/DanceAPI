using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DanceAPIServices.Services;
using DanceAPIServices.Services.Interfaces;

namespace DanceAPI.Controllers
{
    public class CompetitionController : Controller
    {


        #region Private members

        private readonly ICompetitionService competitionService;

        #endregion

        public CompetitionController()
        {
        }

        public CompetitionController(ICompetitionService competitionService)
        {
            this.competitionService = competitionService;
        }

        [HttpGet]
        public ActionResult GetCompetitionList()
        {
            return Json(competitionService.GetAll(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetCompetitionPage()
        {
            return View("Competition");
        }
        public ActionResult CompetitionList()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}