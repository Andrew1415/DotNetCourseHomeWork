using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public float Weight { get; set; }
        public string WeightUnitMeasureCode { get; set; }

        public string DaysToManufacture { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public decimal TotalCost
        {
            get
            {
                return StandardCost * ListPrice;
            }
        }
    }

