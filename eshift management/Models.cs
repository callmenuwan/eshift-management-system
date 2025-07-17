using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_management
{
    public class Models
    {
        public class LoadProduct
        {
            public int ProductID { get; set; }
            public string? ProductName { get; set; }
            public decimal UnitWeight { get; set; }
            public int Quantity { get; set; }
            public decimal TotalWeight => UnitWeight * Quantity;
        }

        public class Load
        {
            public int LoadNumber { get; set; }
            public List<LoadProduct> Products { get; set; } = new List<LoadProduct>();
        }
    }
}
