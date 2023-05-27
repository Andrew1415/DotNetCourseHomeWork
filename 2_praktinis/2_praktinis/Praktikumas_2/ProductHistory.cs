using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProductHistory : History
{
    public int ProductID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public float ListPrice { get; set; }
    public DateTime ModifiedDate { get; set; }

    public Product? Product { get; set; }

    public ProductHistory()
    {
        PrintExpirationDate = DateTime.Now.AddDays(30);
    }
}