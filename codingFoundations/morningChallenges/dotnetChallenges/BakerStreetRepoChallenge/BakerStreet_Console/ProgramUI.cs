using BakerStreet_Repo;

public class ProgramUI
{
    public readonly OrderRepo _repo = new OrderRepo();

    public void Run()
    {
        // seed some basic content into repo for viewing purposes
        Seed();
        // write a menu to the console for user to interact with repo based on different options
        RunMenu();
    }

    public void RunMenu()
    {
        bool continueToRun = true;

        do
        {
            Console.Clear();

            System.Console.WriteLine("Welcome to our Baker Street Repository! Please select an option from the following menu to continue:\n" + 
                "1. Add a new order to the list\n" + 
                "2. Get one order (based on 'Order Num') from the list\n" + 
                "3. Get all orders in the list\n" + 
                "4. Delete an order (based on 'Order Num') from the list\n" + 
                "5. Exit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    AddNewOrder();
                    break;
                case "2":
                    GetOneOrder();
                    break;
                case "3":
                    GetAllOrders();
                    break;
                case "4":
                    DeleteOneOrder();
                    break;
                case "5":
                    System.Console.WriteLine("Adios!");
                    continueToRun = false;
                    break;
                default:
                    System.Console.WriteLine("Please choose a valid option.");
                    WaitForKey();
                    break;
            }
        } while (continueToRun);
    }

    public void AddNewOrder()
    {
        Console.Clear();

        Order newOrder = new Order();

        System.Console.WriteLine("Please enter your name:");
        newOrder.CustomerName = Console.ReadLine();

        System.Console.WriteLine("Please enter the type of product you would like based on the following options:\n" + 
            "1. Bread\n" + 
            "2. Cake\n" + 
            "3. Pastry\n" + 
            "4. Pies");
        newOrder.ProductType = Console.ReadLine() switch {
            "1" => BakeryType.Bread,
            "2" => BakeryType.Cake,
            "3" => BakeryType.Pastry,
            "4" => BakeryType.Pies,
            _ => BakeryType.Unknown
        };

        System.Console.WriteLine("Please specify the # of batches you would like: ");
        newOrder.NumBatches = Int32.Parse(Console.ReadLine());

        if (_repo.AddOrderToList(newOrder))
        {
            Console.Clear();
            System.Console.WriteLine($"Order {newOrder.OrderNum} has been added to the repository!");
        } else
        {
            Console.Clear();
            System.Console.WriteLine("Issue adding your order. Please try again.");
        }

        WaitForKey();
    }

    public void GetOneOrder()
    {
        Console.Clear();

        System.Console.WriteLine("If you are aware of the Order # you would like to view, please enter below. Otherwise, select option 3 from menu to view all content within the repository.");
        string orderNum = Console.ReadLine();

        Order item = _repo.GetOneOrderFromList(orderNum);

        if(item == default)
        {
            System.Console.WriteLine("Item not found. Be sure you are specifying correct order number by checking all orders with option 3.");
        }
        else
        {
            System.Console.WriteLine($"---------- Order {item.OrderNum} ----------\n" + 
                $"Ordered by: {item.CustomerName}\n" + 
                $"Got {item.NumBatches} of {item.ProductType} for ${item.TotalCost}!");
        }

        WaitForKey();
    }

    public void GetAllOrders()
    {
        Console.Clear();

        List<Order> orderList = _repo.GetList();

        if(orderList.Count < 1)
        {
            System.Console.WriteLine("No orders to be viewed currently. Please add some using option 1 and try to view after!");
        }
        else
        {
            foreach (Order order in orderList)
            {
                System.Console.WriteLine($"---------- Order {order.OrderNum} ----------\n" + 
                    $"Ordered by: {order.CustomerName}\n" + 
                    $"Got {order.NumBatches} of {order.ProductType} for ${order.TotalCost}!");
            }
        }

        WaitForKey();
    }

    public void DeleteOneOrder()
    {
        Console.Clear();

        System.Console.WriteLine("If you are aware of the Order # you would like to view, please enter below. Otherwise, select option 3 from menu to view all content within the repository.");
        string orderNum = Console.ReadLine();

        bool isSuccess = _repo.RemoveOrderFromList(orderNum);

        if (isSuccess)
        {
            System.Console.WriteLine($"{orderNum} successfully deleted!");
        }
        else
        {
            System.Console.WriteLine("Delete unsuccessful. Make sure you are specifying the correct order #.");
        }

        WaitForKey();
    }

    private void WaitForKey()
    {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    private void Seed()
    {
        Order wonderBread = new Order("Bugs Bunny", 12, BakeryType.Bread);
        Order cosmicBrownie = new Order("TJ", 50, BakeryType.Pastry);
        Order birthdayCake = new Order("Michael Jordan", 100, BakeryType.Cake);

        _repo.AddOrderToList(wonderBread);
        _repo.AddOrderToList(cosmicBrownie);
        _repo.AddOrderToList(birthdayCake);
    }
}