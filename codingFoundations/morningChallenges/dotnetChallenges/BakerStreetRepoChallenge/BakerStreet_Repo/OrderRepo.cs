// ! REPOSITORY (holds our CRUD methods [create, read, update, delete])

namespace BakerStreet_Repo;
public class OrderRepo
{
    // need a list to store orders
    public readonly List<Order> _orderDirectory = new List<Order>();

    // add an order to the list
    public bool AddOrderToList(Order order)
    {
        int prevOrderCount = _orderDirectory.Count;

        _orderDirectory.Add(order);

        if (_orderDirectory.Count > prevOrderCount) {
            return true;
        }
        else {
            return false;
        }
    }

    // get one item (order) from the list
    public Order GetOneOrderFromList(string orderNum)
    {
        return _orderDirectory.Find(order => order.OrderNum == orderNum);
    }

    // get the list
    public List<Order> GetList()
    {
        return _orderDirectory;
    }

    // remove from the list
    public bool RemoveOrderFromList(string orderNum)
    {
        Order orderToDelete = GetOneOrderFromList(orderNum);

        if (orderToDelete != default)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
