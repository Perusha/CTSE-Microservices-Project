using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNewAPI.Model
{
    public class CartModel
    {
        public string  itemID { get; set; }
        public string itamName { get; set; }
        public string itamCategory { get; set; }
        public string quantity { get; set; }
        public string description { get; set; }
    }
}
