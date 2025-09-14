using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions;

internal class ProductInfoSmall
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public override string ToString() => $"Name={Name}, Description={Description}";

    static void GetNamesAndDescriptionsTyped(ProductInfo[] products)
    {
        Console.WriteLine("Names and Descriptions:");
        IEnumerable<ProductInfoSmall> nameDesc = from p in products
                                                 select new ProductInfoSmall
                                                 { Description = p.Description, Name = p.Name };

        foreach (var item in nameDesc)
            Console.WriteLine(item.ToString());
    }

    static void GetCountFromQuery()
    {
        string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

        int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();
        Console.WriteLine($"{numb} items honor the LINQ query");
    }

    static void ReverseEverything(ProductInfo[] products)
    {
        Console.WriteLine("Product in reverse:");
        var allProducts = from p in products select p;
        foreach (var prod in allProducts.Reverse())
        {
            Console.WriteLine(prod.ToString());
        }
    }

    static void AlphabetizeProductNames(ProductInfo[] products)
    {
        var subset = from p in products orderby p.Name select p;
        Console.WriteLine("Ordered by Name:");
        foreach (var item in subset)
            Console.WriteLine(item.ToString());
    }
}
