using DemoConsole;

public class Program
{
    //declare global variable to store product list
    static List<Product> productList = new List<Product>();

    //declare methods for program features
    private static void ViewAllProducts()
    {
        if (productList.Count == 0)
        {
            Console.WriteLine("Product List is empty\n");
        }
        else
        {
            foreach (Product p in productList)
            {
                Console.WriteLine("Product Id: " + p.ProductID);
                Console.WriteLine("Product Name: " + p.ProductName);
                Console.WriteLine("Product Price: " + p.ProductPrice);
                Console.WriteLine("Product Quantity: " + p.ProductQuantity);
                Console.WriteLine("------------------------\n");
            }
        }
    }

    private static void AddNewProducts()
    {
        //ask user to input product info
        Console.Write("Enter product id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter product price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter product quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        //create new product object
        Product p = new Product
        {
            ProductID = id,
            ProductName = name,
            ProductPrice = price,
            ProductQuantity = quantity
        };
        //add product to product list
        productList.Add(p);
        //show success message
        Console.WriteLine("Product added successfully !");  
    }

    private static void DeleteProduct()
    {
        //prompt user to input id
        Console.Write("Enter product id : ");
        int id = int.Parse(Console.ReadLine());
        Product p = productList.Find(x => x.ProductID == id);
        //case 1: product not found
        if (p == null)
        {
            Console.WriteLine("Product not found !");
        }
        else
        {
        //case 2: product found
            productList.Remove(p);
            Console.WriteLine("Product deleted successfully !");
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n1. View all products");
        Console.WriteLine("2. Add new product");
        Console.WriteLine("3. Delete product");
        Console.WriteLine("4. Exit program");
    }

    //declare main method to run program
    public static void Main(string[] args)
    {
        //set title for console program
        Console.Title = "Demo Program";
        //dislay program menu
        Console.WriteLine("Demo Menu-Based Program");
        int selection = 0;  //default value for number
        //use while loop to repeat program menu
        while (selection != 4)
        {
            //display menu
            ShowMenu();
            Console.Write("Input your selection: ");
            selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    ViewAllProducts();
                    break;
                case 2:
                    AddNewProducts();
                    break;
                case 3:
                    DeleteProduct();
                    break;
                case 4:
                    Console.WriteLine("Program exited !");
                    break;
                default:
                    Console.WriteLine("Invalid menu !");
                    break;
            }
        }
    }
}