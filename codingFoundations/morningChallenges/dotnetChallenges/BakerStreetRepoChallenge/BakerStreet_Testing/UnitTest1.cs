using BakerStreet_Repo;

namespace BakerStreet_Testing;

public class UnitTest1
{
    [Fact]
    public void IsAddOrderToListSuccess()
    {
        // triple "A" paradigm
        // arrange
        Order iceCreamCake = new Order("TJ", 4, BakeryType.Cake);
        OrderRepo repo = new OrderRepo();

        // act
        bool isAddOrderSuccess = repo.AddOrderToList(iceCreamCake);

        // assert
        Assert.True(isAddOrderSuccess);
    }
    
    [Fact]
    public void IsRemoveItemSuccess()
    {
        // triple "A" paradigm
        // arrange
        Order iceCreamCake = new Order("TJ", 4, BakeryType.Cake);
        OrderRepo repo = new OrderRepo();
        repo.AddOrderToList(iceCreamCake);

        // act
        // bool isRemoveItemSuccess = repo.RemoveOrderFromList()

        // assert
        // Assert.True(isAddOrderSuccess);
    }
}