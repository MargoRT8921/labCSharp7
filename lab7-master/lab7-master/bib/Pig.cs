namespace bib;

[FreeComment("pig")]
public class Pig : Animal
{
    public Pig(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country, hideFromOtherAnimals, name, whatAnimal)
    {
    }
    
    
    public override void SayHello()
    {
        Console.WriteLine("oink");
    }
    
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Everything;
    }
}