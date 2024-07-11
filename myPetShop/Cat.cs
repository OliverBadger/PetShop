namespace myPetShop;

class Cat : Pet
{
    /* Variables */
    private bool _hasFur;
    private string? _breed;
    private bool _hasTail; // Manx Isle of Man, Has no Tail!

    /* Constructor */
    public Cat(int id, string colour, string gender, string breed, string size, int age, 
        int numberOfLegs, string name, string description, 
        int price, bool hasFur, bool hasTail) : base(id, colour, gender, size, age, numberOfLegs, name, description, price)
    {
        _hasFur = hasFur;
        _breed = breed;
        _hasTail = hasTail;
    }

    /* Methods */
    public override void Sleep() => Console.WriteLine("zzz purr purr zzz!");
    public override void Eat() => Console.WriteLine("Meow nom!");
    public override void Poops() => Console.WriteLine("I Pooped and im a cat");
}