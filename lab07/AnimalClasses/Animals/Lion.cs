

using AnimalClasses.AbstractClass;
using Attributes;

namespace AnimalClasses.Animals;

[Comment("This is a Lion")]
class Lion : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Meat;
    }

    public override void SayHello()
    {
        Console.WriteLine("RAAAR");
    }
}