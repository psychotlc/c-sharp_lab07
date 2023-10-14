using AnimalClasses.AbstractClass;
using Attributes;

namespace AnimalClasses.classes;

[Comment("This is a Pig")]
class Pig : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Everything;
    }

    public override void SayHello()
    {
        Console.WriteLine("OOINK");
    }
}