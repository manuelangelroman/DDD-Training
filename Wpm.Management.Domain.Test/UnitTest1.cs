namespace Wpm.Management.Domain.Test;

public class UnitTest1
{
    [Fact]
    public void Pet_should_be_equal()
    {
        var id = Guid.NewGuid();
        var pet1 = new Pet() { Id = id};
        var pet2 = new Pet() { Id = id};

        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_be_equal_using_operator()
    {
        var id = Guid.NewGuid();
        var pet1 = new Pet() { Id = id };
        var pet2 = new Pet() { Id = id };

        Assert.True(pet1 == pet2);
    }

    [Fact]
    public void Pet_should_be__not_equal_using_operator()
    {
        var pet1 = new Pet() { Id = Guid.NewGuid() };
        var pet2 = new Pet() { Id = Guid.NewGuid() };

        Assert.True(pet1 != pet2);
    }

}