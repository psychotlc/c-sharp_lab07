using Attributes;

namespace AnimalClasses.AbstractClass;


[Comment("eClassificationAnimal enum")]
enum eClassificationAnimal{
    Herbivores,
    Carnivores,
    Omnivores
}
[Comment("eFavoriteFood enum")]
enum eFavoriteFood{
    Meat,
    Plants,
    Everything
}

[Comment("Abstract class")]
abstract class Animal{
    public string Country {get; set;}
    public string Name {get; set;}
    
    public eClassificationAnimal WhatAnimal {get; set;}

    public Animal(){
        Country = "";
        Name = "";
        WhatAnimal = eClassificationAnimal.Omnivores;
    }

    public eClassificationAnimal GetClassificationAnimal(){
        return WhatAnimal;
    }

    public abstract eFavoriteFood GetFavoriteFood();
    public abstract void SayHello();
}