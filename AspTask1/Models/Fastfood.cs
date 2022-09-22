using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask1.Models
{
    public class Fastfood : BaseModel
    {
        public string Size { get; set; }

        public bool Beef { get; set; }

        public bool Chicken { get; set; }
    }
}
