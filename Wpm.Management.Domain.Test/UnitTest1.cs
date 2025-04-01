using Wpm.Management.Domain.Entities;
using Wpm.Management.Domain.Value_Objects;

namespace Wpm.Management.Domain.Test;

public class UnitTest1
{
    [Fact]
    public void Pet_should_be_equal()
    {
        var breedService = new FakeBreedService();
        var id = breedService.breeds[0].Id;
        var pet1 = new Pet(id, "Gianni", 13,"Black-color", new Weight(20.5m), SexOfPet.Male, new BreedId(id, breedService));
        var pet2 = new Pet(id, "Nina", 5, "Black-color", new Weight(18.5m), SexOfPet.Female, new BreedId(id, breedService));

        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_be_equal_using_operator()
    {
        var breedService = new FakeBreedService();
        var id = breedService.breeds[0].Id;
        var pet1 = new Pet(id, "Gianni", 13, "Black-color", new Weight(20.5m), SexOfPet.Male, new BreedId(id, breedService));
        var pet2 = new Pet(id, "Nina", 5, "Black-color", new Weight(18.5m), SexOfPet.Female, new BreedId(id, breedService));

        Assert.True(pet1 == pet2);
    }

    [Fact]
    public void Pet_should_be__not_equal_using_operator()
    {
        var breedService = new FakeBreedService();
        var id1 = breedService.breeds[0].Id;
        var id2 = breedService.breeds[1].Id;

        var pet1 = new Pet(id1, "Gianni", 13, "Black-color", new Weight(20.5m), SexOfPet.Male, new BreedId(id1, breedService));
        var pet2 = new Pet(id2, "Nina", 5, "Black-color", new Weight(18.5m), SexOfPet.Female, new BreedId(id2, breedService));

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

    [Fact]
    public void BreedId_should_be_valid()
    {
        var breedService = new FakeBreedService();
        var id = breedService.breeds[0].Id;
        var breedId = new BreedId(id, breedService);

        Assert.NotNull(breedId);
    }


    [Fact]
    public void BreedId_should_not_be_valid()
    {
        var breedService = new FakeBreedService();
        var id = Guid.NewGuid();

        Assert.Throws<ArgumentException>(() => new BreedId(id,breedService));
    }
}