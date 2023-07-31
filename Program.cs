class TallGuy
{
    public string Name;
    public int Height;

    public void TalkAboutYourself()
    {
        Console.WriteLine($"My name is {Name} and I'm {Height} inches tall");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
        tallGuy.TalkAboutYourself();
    }
}