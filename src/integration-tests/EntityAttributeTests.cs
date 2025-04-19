using Runedur;
using Xunit;

namespace integration_tests;

public class EntityAttributeTests
{
    [Fact]
    public void RunedurEntityAttribute_worksLikeARegularAttribute()
    {
        var attributes = System.Attribute.GetCustomAttributes(typeof(MyEntity));

        Assert.Contains(attributes, x => x is RunedurEntityAttribute);
    }
    
    [RunedurEntity]
    private class MyEntity
    {
    }
}