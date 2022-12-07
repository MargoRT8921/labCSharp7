namespace bib;

[FreeComment("lion")]
public class Lion : Animal
{
    public Lion(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country, hideFromOtherAnimals, name, whatAnimal)
    {
    }

    public override void SayHello()
    {
        Console.WriteLine("roar");
    }
    
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Meat;
    }
}