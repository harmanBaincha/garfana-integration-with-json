using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test_grafana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {
        // GET: api/Json
        [HttpGet]
        public string Get()
        {
            WeightData e = new WeightData();

            WeightData e1 = new WeightData();
            e.target = "weight";
            List<long> l1 = new List<long>();
            l1.Add(20);
            l1.Add(1632836656035);
            List<long> l2 = new List<long>();
            l2.Add(30);
            l2.Add(1632837697035);
            List<List<long>> l = new List<List<long>>();
            l.Add(l1);
            l.Add(l2);
            e.datapoints = l;


            e1.target = "bmi";
            List<long> l3 = new List<long>();
            l3.Add(32);
            l3.Add(1632836656035);
            List<long> l4 = new List<long>();
            l4.Add(36);
            l4.Add(1632837697035);
            List<List<long>> l11 = new List<List<long>>();
            l11.Add(l3);
            l11.Add(l4);
            e1.datapoints = l11;

            List<WeightData> weightList = new List<WeightData>();
            weightList.Add(e);
            weightList.Add(e1);

            string jsonRes = JsonConvert.SerializeObject(weightList);
            return jsonRes;







            //WeightData e = new WeightData();

            //e.target = "weight";
            //List<long> l1 = new List<long>();
            //l1.Add(27);
            //l1.Add(1450754160000);
            //List<long> l2 = new List<long>();
            //l2.Add(27);
            //l2.Add(1450754160000);
            //List<List<long>> l = new List<List<long>>();
            //l.Add(l1);
            //l.Add(l2);
            //e.datapoints = l;
            //string jsonRes = JsonConvert.SerializeObject(e);
            //return jsonRes;
        }
              
    }
}
