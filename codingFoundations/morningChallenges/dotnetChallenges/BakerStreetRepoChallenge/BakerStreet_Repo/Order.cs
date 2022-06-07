// ! POCO (Plain Old C# Object)

namespace BakerStreet_Repo;
public class Order
{
    public Order()
    {

    }

    public Order(string name, int numBatches, BakeryType productType)
    {
        CustomerName = name;
        NumBatches = numBatches;
        ProductType = productType;
    }

    // order number
    public string OrderNum { get {
        Random ranNum = new Random();

        return $"{CustomerName[0]}-{ranNum.Next()}";
    } }

    // customer name
    public string CustomerName { get; set; }
    
    // number of batches
    public int NumBatches { get; set; }

    // organizes products based on "type" - Bread, Cake, Pastry, Pies
    public BakeryType ProductType { get; set; }

    // price per batch depending on "type" 
    //  - $500.01 for bread
    //  - $2000 for cake
    //  - $200.10 for pasteries
    // - $851.5 for pies
    public double PricePerBatch { get {
        switch (ProductType)
        {
            case BakeryType.Bread:
                return 500.01;
                break;
            case BakeryType.Cake:
                return 2000;
                break;
            case BakeryType.Pastry:
                return 200.10;
                break;
            case BakeryType.Pies:
                return 851.50;
                break;
            default:
                return 0;
                break;
        }
    } }

    // total cost = 100 + (totalCostOfBatches)
    //  - totalCostOfBatches = numberOfBatches * pricePerBatch
    public double TotalCost { get {
        double totalCostOfBatches = NumBatches * PricePerBatch;

        return 100 + totalCostOfBatches;
    } }

}

public enum BakeryType {Bread, Cake, Pastry, Pies, Unknown}
