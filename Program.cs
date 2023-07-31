using Interfaces;

class TallGuy : IClown 
{
    public string Name;
    public int Height;

    public void TalkAboutYourself()
    {
        Console.WriteLine($"My name is {Name} and I'm {Height} inches tall");
    }
    public string FunnyThingIHave { get { return "big shoes"; } }
    public void Honk()
    {
        Console.WriteLine("Honk honk!");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
        tallGuy.TalkAboutYourself();
        Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
        tallGuy.Honk();
    }
}