//by Andrius Stulgys JNII21
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

class Program
{
    private static DatabaseManager<T> _db = new();

    static void Main()
    {
        _db.LoadData();
        Console.WriteLine("----------------------------------");
        List<Product>? Products = _db.Products;
        List<ProductHistory>? ProductsPriceHistories = _db.ProductsPriceHistories;

        while (true)
        {
            Option(Products, ProductsPriceHistories);
        }
  
    }
    public static void Option(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("----------------------------------");
        Console.ResetColor();
        Console.WriteLine("Pick wich task you want to run:");
        Console.WriteLine("1. 1 A");
        Console.WriteLine("2. 1 B");
        Console.WriteLine("3. 2 C");
        Console.WriteLine("4. 2 D");
        Console.WriteLine("5. 3 E");
        Console.WriteLine("6. 3 F");
        Console.WriteLine("7. 4 G");
        Console.WriteLine("8. 4 H");
        Console.WriteLine("9. 5 I");
        Console.WriteLine("10. 5 J");
        Console.WriteLine("11. 6");
        Console.WriteLine("12. Exit");
        Console.WriteLine("Option:");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                uzd_1_a(Products, ProductsPriceHistories);
                break;
            case 2:
                uzd_1_b(Products, ProductsPriceHistories);
                break;
            case 3:
                uzd_2_c(Products, ProductsPriceHistories);
                break;
            case 4:
                uzd_2_d(Products, ProductsPriceHistories);
                break;
            case 5:
                uzd_3_e(Products, ProductsPriceHistories);
                break;
            case 6:
                uzd_3_f(Products, ProductsPriceHistories);
                break;
            case 7:
                uzd_4_g(Products, ProductsPriceHistories);
                break;
            case 8:
                uzd_4_h(Products, ProductsPriceHistories);
                break;
            case 9:
                uzd_5_i(Products, ProductsPriceHistories);
                break;
            case 10:
                uzd_5_j(Products, ProductsPriceHistories);
                break;
            case 11:
                uzd_6(Products, ProductsPriceHistories);
                break;
            case 12:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Wrong option");
                break;
        }
    }

    public static void uzd_1_a(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("1 Uzduotis A");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result3 = from ProductHistory in ProductsPriceHistories
                      select new
                     {
                        ProductHistory.ProductID,
                        ProductHistory.StartDate,
                        ProductHistory.EndDate,
                        ProductHistory.ListPrice,
                        ProductHistory.ModifiedDate
                     };
        foreach (var item in result3)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", item.ProductID, item.StartDate, item.EndDate, item.ListPrice, item.ModifiedDate);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result4 = ProductsPriceHistories.Select(ProductHistory => new
        {
            ProductHistory.ProductID,
            ProductHistory.StartDate,
            ProductHistory.EndDate,
            ProductHistory.ListPrice,
            ProductHistory.ModifiedDate
        });
        foreach (var item in result4)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", item.ProductID, item.StartDate, item.EndDate, item.ListPrice, item.ModifiedDate);
        };
    }

    public static void uzd_1_b(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("1 Uzduotis A");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result3 = from ProductHistory in ProductsPriceHistories
                      select new
                      {
                          ProductHistory.ProductID,
                          ProductHistory.ListPrice,
                      };
        foreach (var item in result3)
        {
            Console.WriteLine("{0,10},{1,10}", item.ProductID, item.ListPrice);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result4 = ProductsPriceHistories.Select(ProductHistory => new
        {
            ProductHistory.ProductID,
            ProductHistory.ListPrice,
        });
        foreach (var item in result4)
        {
            Console.WriteLine("{0,10},{1,10}", item.ProductID, item.ListPrice);
        };
    }



    public static void uzd_2_c(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("2 Uzduotis C");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result3 = from ProductHistory in ProductsPriceHistories
                      where ProductHistory.ProductID == 739
                      select new
                      {
                          ProductHistory.ProductID,
                          ProductHistory.StartDate,
                          ProductHistory.EndDate,
                          ProductHistory.ListPrice,
                          ProductHistory.ModifiedDate
                      };
        foreach (var item in result3)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", item.ProductID, item.StartDate, item.EndDate, item.ListPrice, item.ModifiedDate);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result4 = ProductsPriceHistories.Where(ProductHistory => ProductHistory.ProductID == 739).Select(ProductHistory => new
        {
            ProductHistory.ProductID,
            ProductHistory.StartDate,
            ProductHistory.EndDate,
            ProductHistory.ListPrice,
            ProductHistory.ModifiedDate
        });
        foreach (var item in result4)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", item.ProductID, item.StartDate, item.EndDate, item.ListPrice, item.ModifiedDate);
        };  
    }
    public static void uzd_2_d(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("2 Uzduotis D");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result3 = from ProductHistory in ProductsPriceHistories
                      where ProductHistory.EndDate > DateTime.MinValue
                      select new
                      {
                          ProductHistory.ProductID,
                          ProductHistory.StartDate,
                          ProductHistory.EndDate,
                          ProductHistory.ListPrice,
                      };
        foreach (var item in result3)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10}", item.ProductID, item.StartDate, item.EndDate, item.ListPrice);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("ProductsPriceHistories.json");
        var result4 = ProductsPriceHistories.Where(ProductHistory => ProductHistory.EndDate > DateTime.MinValue).Select(ProductHistory => new
        {
            ProductHistory.ProductID,
            ProductHistory.StartDate,
            ProductHistory.EndDate,
            ProductHistory.ListPrice,
        });
        foreach (var item in result4)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10}", item.ProductID, item.StartDate, item.EndDate, item.ListPrice);
        };
    }

    public static void uzd_3_e(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {


        Console.WriteLine("3 Uzduotis E");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("Products.json");
        var result3 = from Product in Products
                      orderby Product.Name ascending
                      select new
                      {

                          Product.ProductID,
                          Product.Name,
                          Product.ProductNumber,
                          Product.StandardCost,
                          Product.ListPrice,
                          Product.DaysToManufacture,
                          Product.SellStartDate,
                          Product.ModifiedDate
                      };
        foreach (var item in result3)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10},{5,10},{6,10},{7,10}", item.ProductID, item.Name, item.ProductNumber, item.StandardCost, item.ListPrice, item.DaysToManufacture, item.SellStartDate, item.ModifiedDate);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("Products.json");
        var result4 = Products.OrderBy(Product => Product.Name).Select(product => new
        {
            product.ProductID,
            product.Name,
            product.ProductNumber,
            product.StandardCost,
            product.ListPrice,
            product.DaysToManufacture,
            product.SellStartDate,
            product.ModifiedDate
        });
        foreach (var item in result4)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10},{5,10},{6,10},{7,10}", item.ProductID, item.Name, item.ProductNumber, item.StandardCost, item.ListPrice, item.DaysToManufacture, item.SellStartDate, item.ModifiedDate);
        };
    }

    public static void uzd_3_f(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {


        Console.WriteLine("3 Uzduotis F");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("Products.json");
        var result3 = from Product in Products
                      orderby Product.Name descending
                      select new
                      {
                          Product.ProductID,
                          ProductName = Product.Name,
                          Product.ProductNumber,
                          Product.StandardCost,
                          Product.ListPrice,
                          Product.DaysToManufacture,
                          Product.SellStartDate,
                          Product.ModifiedDate
                      };
        foreach (var item in result3)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10},{5,10},{6,10},{7,10}", item.ProductID, item.ProductName, item.ProductNumber, item.StandardCost, item.ListPrice, item.DaysToManufacture, item.SellStartDate, item.ModifiedDate);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("Products.json");
        var result4 = Products.OrderByDescending(Product => Product.Name).Select(product => new
        {
            product.ProductID,
            ProductName = product.Name,
            product.ProductNumber,
            product.StandardCost,
            product.ListPrice,
            product.DaysToManufacture,
            product.SellStartDate,
            product.ModifiedDate
        });
        
        foreach (var item in result4)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10},{5,10},{6,10},{7,10}", item.ProductID, item.ProductName, item.ProductNumber, item.StandardCost, item.ListPrice, item.DaysToManufacture, item.SellStartDate, item.ModifiedDate);
        };
    }

    public static void uzd_4_g(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    { 
        Console.WriteLine("4 Uzduotis G");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("ProductPriceHistory.json");
        var result = from ProductHistory in ProductsPriceHistories
                     group ProductHistory by ProductHistory.ProductID into g
                     select new
                     {
                         ProductID = g.Key,
                         Modification_Count = g.Count(),
                         Max_Price = g.Max(pp => pp.ListPrice),
                     };
        foreach (var item in result)
        {
            Console.WriteLine("{0,10},{1,10},{2,10}", item.ProductID, item.Max_Price, item.Modification_Count);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("ProductPriceHistory.json");
        var result2 = ProductsPriceHistories.GroupBy(ProductHistory => ProductHistory.ProductID).Select(g => new
        {
            ProductID = g.Key,
            Modification_Count = g.Count(),
            Max_Price = g.Max(pp => pp.ListPrice),
        });
        foreach (var item in result2)
        {
            Console.WriteLine("{0,10},{1,10},{2,10}", item.ProductID, item.Max_Price, item.Modification_Count);
        };
    }

    public static void uzd_4_h(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("4 Uzduotis H");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        Console.WriteLine("Products.json");
        var result = from Product in Products
                     where Product.ProductNumber.StartsWith("BK-")
                     orderby Product.Name ascending
                     group Product by new { Product.Color, Product.SizeUnitMeasureCode } into g
                     select new
                     {
                         Color_Size = g.Key.Color + " (" + g.Key.SizeUnitMeasureCode + ")",
                         ListPrice_Sum = g.Sum(p => p.ListPrice),
                         ListPrice_Average = g.Average(p => p.ListPrice),
                         ListPrice_Max = g.Max(p => p.ListPrice),
                         ListPrice_Min = g.Min(p => p.ListPrice)
                     };
        foreach (var item in result)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", item.Color_Size, item.ListPrice_Sum, item.ListPrice_Average, item.ListPrice_Max, item.ListPrice_Min);
        };
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Method syntax");
        Console.WriteLine("Products.json");
        var result2 = Products.Where(Product => Product.ProductNumber.StartsWith("BK-")).OrderBy(Product => Product.Name).GroupBy(Product => new { Product.Color, Product.SizeUnitMeasureCode }).Select(g => new
        {
            Color_Size = g.Key.Color + " (" + g.Key.SizeUnitMeasureCode + ")",
            ListPrice_Sum = g.Sum(p => p.ListPrice),
            ListPrice_Average = g.Average(p => p.ListPrice),
            ListPrice_Max = g.Max(p => p.ListPrice),
            ListPrice_Min = g.Min(p => p.ListPrice)
        });
        foreach (var item in result2)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10}", item.Color_Size, item.ListPrice_Sum, item.ListPrice_Average, item.ListPrice_Max, item.ListPrice_Min);
        };
    }

    public static void uzd_5_i(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("5 Uzduotis I");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        var result = from ProductHistory in ProductsPriceHistories
                     join Product in Products on ProductHistory.ProductID  equals Product.ProductID
                     select new
                     {
                         Product.ProductID,
                         Product.Name,
                         Product.Size,
                         Product.Weight,
                         ProductHistory.StartDate,
                         ProductHistory.EndDate,
                         Product.ListPrice,
                         Product.ModifiedDate
                     };
        foreach (var item in result)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10},{4,10},{5,10},{6,10},{7,10}", item.ProductID, item.Name, item.Size, item.Weight, item.StartDate, item.EndDate, item.ListPrice, item.ModifiedDate);
        };
    }

    public static void uzd_5_j(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("5 Uzduotis J");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        var result = (from Product in Products
                      join ProductPriceHistories_1 in ProductsPriceHistories on Product.ProductID equals ProductPriceHistories_1.ProductID
                      join ProductPriceHistories_2 in ProductsPriceHistories on Product.ProductID equals ProductPriceHistories_2.ProductID
                      where ProductPriceHistories_1.StartDate == (from ProductPriceHistories_3 in ProductsPriceHistories
                                             where ProductPriceHistories_3.ProductID == Product.ProductID
                                             select ProductPriceHistories_3.StartDate).Min()
                            && ProductPriceHistories_2.StartDate == (from ProductPriceHistories_4 in ProductsPriceHistories
                                                where ProductPriceHistories_4.ProductID == Product.ProductID
                                                select ProductPriceHistories_4.StartDate).Max()
                      select new
                      {
                          Product.ProductID,
                          Product.Name,
                          FirstPrice = ProductPriceHistories_1.ListPrice,
                          LastPrice = ProductPriceHistories_2.ListPrice
                      }).Where(x => x.FirstPrice != x.LastPrice).ToList();
        int i = 0;
        foreach (var item in result)
        {
            Console.WriteLine("{0,10},{1,10},{2,10},{3,10}", item.ProductID, item.Name, item.FirstPrice, item.LastPrice);
            i++;
        };
        Console.WriteLine("Kiekis: " + i);
    }

    public static void uzd_6(List<Product>? Products, List<ProductHistory>? ProductsPriceHistories)
    {
        Console.WriteLine("6 Uzduotis");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Query syntax");
        var result = (from ProductPriceHistories in ProductsPriceHistories
                      join Product in Products on ProductPriceHistories.ProductID equals Product.ProductID
                      where ProductPriceHistories.StartDate.Year >= 2012 && ProductPriceHistories.StartDate.Year <= 2013
                      orderby Product.Name
                      select new
                      {
                          Product.ProductID,
                          Product.Name,
                          ProductPriceHistories.ListPrice,
                      })
            .Skip(3)
            .Take(5)
            .ToList();
        foreach (var item in result)
        {
            Console.WriteLine("{0,10},{1,10},{2,10}", item.ProductID, item.Name, item.ListPrice);
        };
        var json = JsonConvert.SerializeObject(result);
        File.WriteAllText(@"C:\\Users\\andri\\OneDrive - ku.lt\\Uni_HomeWork\\2_Kursas_4_Pusmetis\\dotNET\\2_praktinis\\2_praktinis\\output.json", json);
    }

}



internal class T
{
}