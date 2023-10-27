// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace AppOwnsData.Controllers
{
    using Infraestructura.Reporting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.PowerBI.Api.Models;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet("{controller}/{action}/{reportId}/{*parameters}")]
        public IActionResult GetReporteRDL(string reportId, string parameters)
        {            
            string[] parameterArray = parameters.Split('/');
            List<ParametroRDL> parametrosRDL = new List<ParametroRDL>();
            foreach (string parameter in parameterArray)
            {
                string[] pamArray = parameter.Split(':');
                parametrosRDL.Add(new ParametroRDL(pamArray[0], pamArray[1]));
            }

            ViewBag.ReportId = reportId;

            return View(parametrosRDL);
        }
    }
}
