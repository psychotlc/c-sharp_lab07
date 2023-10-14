using AnimalClasses.AbstractClass;
using Attributes;

namespace AnimalClasses.classes;

[Comment("This is a Cow")]
class Cow : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Plants;
    }

    public override void SayHello()
    {
        Console.WriteLine("MUUU");
    }
}