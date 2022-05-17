using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebNewAPI.Model;

namespace WebNewAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private static List<CartModel> CartObjs;
        public CartController()
        {
            CartObjs = new List<CartModel>();
        }

        [HttpPost]
        [Route("Addcart")]
        public string SaveCart([FromBody]CartModel cartModel)
        {
            
            string fileName = "json.json";


            string jsonStringr = System.IO.File.ReadAllText(fileName);
            List<CartModel> weatherForecast = JsonSerializer.Deserialize<List<CartModel>>(jsonStringr)!;
            weatherForecast.Add(cartModel);
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            System.IO.File.WriteAllText(fileName, jsonString);


            return "Saved";

        }

        [HttpGet]
        [Route("Showcart")]
        public List<CartModel> ShowCart()
        {
            string fileName = "json.json";


            string jsonStringr = System.IO.File.ReadAllText(fileName);
            List<CartModel> weatherForecast = JsonSerializer.Deserialize<List<CartModel>>(jsonStringr)!;
            return weatherForecast;
        }
    }
}
