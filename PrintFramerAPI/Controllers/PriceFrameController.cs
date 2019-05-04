using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PrintFramerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceFrameController : ControllerBase
    {
        [HttpGet("{Height}/{Width}")]
        public string GetPrice(string Height, string Width)
        {
            string result;
            result = CalculatePrice(Double.Parse(Height), Double.Parse(Width));
            return $"The cost of a {Height}x{Width} frame is ${result}";
        }

        private string CalculatePrice(double height,double width)
        {
            double perimeter;
            perimeter = (2*height) + (2*width);

            if ((perimeter > 20.00 ) &&  (perimeter <= 50.00))
            {
                return "20.00";
            }
            if ((perimeter > 50.00) && (perimeter <= 100.00))
            {
                return "50.00";
            }
            if ((perimeter > 100.00) && (perimeter <= 1000.00))
            {
                return "100.00";
            }
            return  "not valid";
        }
    }
}
