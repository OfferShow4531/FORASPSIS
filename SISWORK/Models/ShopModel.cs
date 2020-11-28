using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SISWORK.Models
{
    public class ShopModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public string type { get; set; }
        [DataType(DataType.Date)]
        public DateTime Come { get; set; }
    }
}
