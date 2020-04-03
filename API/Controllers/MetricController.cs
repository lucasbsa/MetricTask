using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class MetricController : Controller
    {
        [HttpGet("getMetric")]
        public IActionResult getMetric()
        {
            return Ok();
        }
        [HttpGet("getMetricIdUser")]
        public IActionResult getMetricIdUser()
        {

            return Ok();
        }
    }
}
