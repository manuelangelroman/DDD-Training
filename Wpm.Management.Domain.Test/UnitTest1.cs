namespace Wpm.Management.Domain.Test;

public class UnitTest1
{
    [Fact]
    public void Pet_should_be_equal()
    {
        var id = Guid.NewGuid();
        var pet1 = new Pet(id, "Gianni", 13,"Black-color", new Weight(20.5m), SexOfPet.Male);
        var pet2 = new Pet(id, "Nina", 5, "Black-color", new Weight(18.5m), SexOfPet.Female);

        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_be_equal_using_operator()
    {
        var id = Guid.NewGuid();
        var pet1 = new Pet(id, "Gianni", 13, "Black-color", new Weight(20.5m), SexOfPet.Male);
        var pet2 = new Pet(id, "Nina", 5, "Black-color", new Weight(18.5m), SexOfPet.Female);

        Assert.True(pet1 == pet2);
    }

    [Fact]
    public void Pet_should_be__not_equal_using_operator()
    {
        var pet1 = new Pet(Guid.NewGuid(), "Gianni", 13, "Black-color", new Weight(20.5m), SexOfPet.Male);
        var pet2 = new Pet(Guid.NewGuid(), "Nina", 5, "Black-color", new Weight(18.5m), SexOfPet.Female);

        Assert.True(pet1 != pet2);
    }

    [Fact]
    public void Weight_should_be_equal()
    {
        var weight1 = new Weight(20.5m);
        var weight2 = new Weight(20.5m);

        Assert.True(weight1 == weight2);
    }



    [Fact]
    public void WeightRange_should_be_equal()
    {
        var wr1 = new WeightRange(10.5m, 20.5m);
        var wr2 = new WeightRange(10.5m, 20.5m);

        Assert.True(wr1 == wr2);
    }
}