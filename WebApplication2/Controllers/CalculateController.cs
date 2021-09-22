using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CalculatorLib;


namespace WebApplication2.Controllers
{
    public class CalculateController : ApiController
    {
        Calculator clac = new Calculator();
        
        [HttpGet]
        [Route("Calculator/Add")]
        public double Add(double value1, double value2)
        {
            return clac.Add(value1 , value2);
        }

        [HttpGet]
        [Route("Calculator/Sub")]
        public double Substract(double value1, double value2)
        {
            return clac.Subtract(value1 , value2);
        }

        [HttpGet]
        [Route("Calculator/Mul")]
        public double Multiply(double value1, double value2)
        {
            return clac.Multiply(value1 , value2);
        }

        [HttpGet]
        [Route("Calculator/Div")]
        public double Divide(double value1, double value2)
        {
            return clac.Division( value1 , value2);
        }

        [HttpGet]
        public string Get()
        {
            return "default";
        }


    }
}