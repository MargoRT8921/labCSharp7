namespace bib;

[FreeComment("cow")]
public class Cow : Animal
{
    public Cow(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country, hideFromOtherAnimals, name, whatAnimal)
    {
    }
    
    public override void SayHello()
    {
        Console.WriteLine("moo");
    }
    
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Plants;
    }
}