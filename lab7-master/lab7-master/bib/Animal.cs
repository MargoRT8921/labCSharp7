namespace bib;

[FreeComment("animal")]
public abstract class Animal
{
    public string Country { get; set; }
    public string HideFromOtherAnimals { get; set; }
    public string Name { get; set; }
    public string WhatAnimal { get; set; }
    
    public Animal(string country, string hideFromOtherAnimals, string name, string whatAnimal)
    {
        Country = country;
        HideFromOtherAnimals = hideFromOtherAnimals;
        Name = name;
        WhatAnimal = whatAnimal;
    }
    
    public void Deconstruct(out string animalCountry, out string animalHFOA, out string animalName, out string animalWA)
    {
        animalCountry = Country;
        animalHFOA = HideFromOtherAnimals;
        animalName = Name;
        animalWA = WhatAnimal;
    }

    public abstract void SayHello();

    public eClassificationAnimal GetClassificationAnimal()
    {
        if (this.GetFavoriteFood() == eFavoriteFood.Plants) return eClassificationAnimal.Herbivores;
        return this.GetFavoriteFood() == eFavoriteFood.Everything ? eClassificationAnimal.Omnivores : eClassificationAnimal.Carnivores;
    }

    public abstract eFavoriteFood GetFavoriteFood();
}