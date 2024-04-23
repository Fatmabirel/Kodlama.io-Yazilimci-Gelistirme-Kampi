using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
     static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();
    }

    //private static void CategoryTest()
    //{
    //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    //    foreach (var category in categoryManager.GetAll())
    //    {
    //        Console.WriteLine(category.CategoryName);
    //    }
    //}

    //private static void ProductTest()
    //{
    //    ProductManager productManager = new ProductManager(new EfProductDal());

    //    //Product product = new Product { ProductName = "D", CategoryID = 1, UnitPrice = 140, UnitsInStock = 3 };
    //    //productManager.Add(product);

    //    foreach (var category in productManager.GetAll().Data)
    //    {
    //        Console.WriteLine(category.ProductName);
    //    }
    //    var result = productManager.GetProductDetails();

    //    //if(result.Success == true)
    //    //{
    //    //    foreach (var product in productManager.GetProductDetails().Data)
    //    //    {
    //    //        Console.WriteLine(product.ProductName + "-" + product.CategoryName);
    //    //    }
    //    //}
    //    //else
    //    //{
    //    //    Console.WriteLine(result.Message);
    //    //}


    //}
}