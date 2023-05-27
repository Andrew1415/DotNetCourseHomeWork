using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DatabaseManager<T> : ICrudRepository<T>
{
    private readonly string _directoryPath = @"C:\Users\andri\OneDrive - ku.lt\Uni_HomeWork\2_Kursas_4_Pusmetis\dotNET\2_praktinis\2_praktinis";
    private readonly string _productsFileName = "Products.json";
    private readonly string _historiesFileName = "ProductsPriceHistory.json";

    public List<Product> Products { get; set; }
    public List<ProductHistory> ProductsPriceHistories { get; set; }

    public void LoadData()
    {
        string json = File.ReadAllText(_directoryPath + '\\' + _productsFileName);
        Products = JsonConvert.DeserializeObject<List<Product>>(json);

        string json2 = File.ReadAllText(_directoryPath + '\\' + _historiesFileName);
        ProductsPriceHistories = JsonConvert.DeserializeObject<List<ProductHistory>>(json2);
    }
    public void InsertRecord(T record)
    {
        Product product = new Product();
        product.ProductID = Products.Max(p => p.ProductID) + 1;

        // Add the new product to the list
        Products.Add(product);

        // Serialize the updated list of products into JSON and write it back to the file
        string json = JsonConvert.SerializeObject(Products, Formatting.Indented);
        File.WriteAllText(_directoryPath + '\\' + _productsFileName, json);
    }
    public void UpdateRecord(T record)
    {
        Console.WriteLine("Insert an ID of which record you want to update");
        Console.Write("Your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        var productsToUpdate = Products.Where(p => p.ProductID == choice);

        // Update the necessary properties of the product(s)
        foreach (var product in productsToUpdate)
        {
            Console.WriteLine("Insert new cost:");
            product.ListPrice = Convert.ToDecimal(Console.ReadLine());
        }

        // Serialize the updated collection back into JSON format and write it back to the file
        var json = JsonConvert.SerializeObject(Products);
        File.WriteAllText(_directoryPath + '\\' + _productsFileName, json);
    }
    public void DeleteRecord(T record)
    {
        Console.WriteLine("Insert an ID of which record you want to delete");
        Console.Write("Your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        int id = Convert.ToInt32(Console.ReadLine());
        Products.RemoveAll(x => x.ProductID == id);
        ProductsPriceHistories.RemoveAll(x => x.ProductID == id);

        
    }
}