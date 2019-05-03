using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace stringReverse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // Method to reverse array.
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //  Declaration of string array
        public static string[] arr1 = new string[2];

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // Output
            return Ok("Your input: " + arr1[0] + ". Your reversed input: " + arr1[1] + ".");
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // The input is stored in an array.
            arr1[0] = value;
            arr1[1] = Reverse(value);
        }

        }
    }
