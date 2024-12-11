﻿using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;
using System.Xml.Linq;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "ListeAvis":
                        //TODO : code reading of the xml files provide
                        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "XlmFile", "DataAvis.xml");
                        XDocument xmlDoc = XDocument.Load(filePath);

                        ViewData["XmlData"] = xmlDoc;
                        return View(id);
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire(FormulaireModel model)
        {
            //TODO : test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "Formulaire invalide. Veuillez corriger les erreurs ci-dessous:";

                return View("~/Views/Shared/Form.cshtml", model);
            }
            else
            {
                return View(model);
            }

        }
    }
}