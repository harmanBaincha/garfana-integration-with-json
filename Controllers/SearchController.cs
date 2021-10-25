using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_grafana.Controllers
{
    [Route("api/json/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        
        

        // POST api/Json/search
        [HttpPost]
        public string Post([FromBody] SearchPayload value)
        {
            
            
            string[] a = {"weight","bmi"};
            return JsonConvert.SerializeObject(a);
        }

       

        
    }
}
