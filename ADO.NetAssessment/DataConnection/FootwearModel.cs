using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineFootWearStore.DataConnection
{
    public class FootwearModel
    {
        public int Product_Code { get; set; }
        public string Product_Name { get; set; }
        public float Cost { get; set; }
        public string Category { get; set; }
    }
}