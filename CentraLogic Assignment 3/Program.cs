class Item      //Created Item class for attribute i.e. ID,Name,Price,Quantity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Item(int id, string name, double price, int quantity)   //constructor
    {
        ID = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void DisplayProducts()   //CRUD Operation i.e. Read method
    {
        Console.WriteLine($"\nID:{ID} Name:{Name}, Price:{Price}, Quantity:{Quantity}");
    }

}

class Inventory
{
    //public List<Item> Items;{ get; set; } = new List<Item>();
    public List<Item> Items;

    public Inventory()
    {
        Items = new List<Item>();
    }

    // Validate numeric input
    public static bool TryParseDouble(string input, out double result)
    {
        return double.TryParse(input, out result);
    }

    public static bool TryParseInt(string input, out int result)
    {
        return int.TryParse(input, out result);
    }

    // Validate non-empty string
    public static bool ValidateString(string input)
    {
        return !string.IsNullOrWhiteSpace(input);
    }

    //add Method under inventory class
    public void AddItem()
    {
        int id = GenerateId();

        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();
        while (!ValidateString(name))
        {
            Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            Console.Write("Enter Item Name: ");
            name = Console.ReadLine();
        }

        Console.Write("Enter Item Price: ");
        double price;
        while (!TryParseDouble(Console.ReadLine(), out price))
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric price.");
            Console.Write("Enter Item Price: ");
            price = double.Parse(Console.ReadLine());
        }

        Console.Write("Enter Item Quantity: ");
        int quantity;
        while (!TryParseInt(Console.ReadLine(), out quantity))
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric quantity.");
            Console.Write("Enter Item Quantity: ");
            quantity = int.Parse(Console.ReadLine());
        }
        Item newItem = new Item(id, name, price, quantity);
        Items.Add(newItem);
        Console.WriteLine("Product Details is Successfully added");
        Console.WriteLine("");
    }

    //method for display all items under inventory class
    public void DisplayAllItems()
    {
        Console.WriteLine("\n============Inventory============");
        Console.WriteLine("ID  Name         Price         Quantity");
        foreach (Item item in Items)
            Console.WriteLine($"{item.ID}  {item.Name}         {item.Price}         {item.Quantity}");
        Console.WriteLine("");
    }

    //search method for searching items with help of item id under inventory class
    public Item SearchItemById(int id)
    {
        return Items.Find(item => item.ID == id);
    }
    public int GenerateId()
    {
        return Items.Count + 1;
    }

    //update method for changing item's info
    public void UpdateItem(int id, string name, double price, int quantity)
    {
        Item itemToUpdate = SearchItemById(id);

        if (itemToUpdate != null)
        {
            itemToUpdate.Name = name;
            itemToUpdate.Price = price;
            itemToUpdate.Quantity = quantity;
            Console.WriteLine($"item at index {id} is successfully updated");
        }
        else
        {
            Console.WriteLine("Respective item not found in Inventory");
        }
        Console.WriteLine("");
    }

    // delete method for deleting item from inventory
    public void DeleteItem(int id)
    {
        Item itemToDelete = SearchItemById(id);

        if (itemToDelete != null)
        {
            Items.Remove(itemToDelete);
            Console.WriteLine($"Item at index{id} is deleted successfully");
        }
        else
        {
            Console.WriteLine("Item at Inventory not Found");
        }
        Console.WriteLine("");
    }
}

class Program : Inventory
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        try
        {
            while (true)
            {
                Console.WriteLine(":)===Welcome To Inventory Management System.===(:");
                Console.WriteLine("1. Add / Create new Item");
                Console.WriteLine("2. Display / Read all Items");
                Console.WriteLine("3. Find / Search Item by its ID");
                Console.WriteLine("4. change / Update Item");
                Console.WriteLine("5. Remove / Delete Item");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice accordingly: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        inventory.AddItem();
                        Console.WriteLine("");
                        break;

                    case 2:
                        inventory.DisplayAllItems();
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.Write("Enter Index ID of Item for search: ");
                        int findId = int.Parse(Console.ReadLine());
                        Item findItem = inventory.SearchItemById(findId);

                        if (findItem != null)
                        {
                            Console.WriteLine("Searched Item found in Inventory");
                            findItem.DisplayProducts();
                        }
                        else
                        {
                            Console.WriteLine("Entered Index along with Item not found");
                        }
                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.Write("Enter Item ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());

                        Console.Write("Enter new Item Name: ");
                        string newName = Console.ReadLine();

                        Console.Write("Enter new Item Price: ");
                        double newPrice = double.Parse(Console.ReadLine());

                        Console.Write("Enter new Item Quantity: ");
                        int newQuantity = int.Parse(Console.ReadLine());

                        inventory.UpdateItem(updateId, newName, newPrice, newQuantity);
                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.Write("Enter Input as Item ID to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        inventory.DeleteItem(deleteId);
                        Console.WriteLine("");
                        break;

                    case 6:
                        Console.WriteLine("We are ready to Exit, Have a nice day!");
                        return;

                    default:
                        Console.WriteLine("Entered Choice is Invalid! Please Enter Valid specified Choice.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid Input! entered by you, please enter valid Input according to specific Field");
        }
    }
}
