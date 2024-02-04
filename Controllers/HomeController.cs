// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace AppOwnsData.Controllers
{
    using AppOwnsData.Models;
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
        public IActionResult GetReporteRDL(string reportId, string parameters = "")
        {
            string[] parameterArray = parameters?.Split('&') ?? new string[0];
            List<ParametroRDL> parametrosRDL = new List<ParametroRDL>();
            foreach (string parameter in parameterArray)
            {
                if (string.IsNullOrEmpty(parameter))
                {
                    continue;
                }
                string[] pamArray = parameter.Split('=');
                parametrosRDL.Add(new ParametroRDL(pamArray[0], pamArray[1]));
            }

            ViewBag.ReportId = reportId;

            return View(parametrosRDL);
        }
    }
}
