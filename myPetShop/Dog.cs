namespace myPetShop;

class Dog : Pet
{
    private bool _hasTail;
    private string? _breed;
    private bool _hasFur;

    public Dog(int id, string colour, string gender, string breed, string size, int age, 
        int numberOfLegs, string name, string description, int price, 
        bool hasTail, bool hasFur) : base(id, colour, gender, size, age, numberOfLegs, name, description, price)
    {
        _hasTail = hasTail;
        _breed = breed;
        _hasFur = hasFur;
    }

    public override void Sleep() => Console.WriteLine("zzz woof woof zzz!");
    public void Play() => Console.WriteLine("Im playing fetch!");
}