namespace myPetShop;

class Goldfish : Pet, ISwim
{
    /* Constructor */
    public Goldfish(int id, string gender, string size, int age, 
        int numberOfLegs, string name, string description, 
        int price) : base(id, "Yellow", gender, size, age, numberOfLegs, name, description, price)
    {

    }

    /* Methods */
    public override void Sleep() => Console.WriteLine("zzz blub blub zzz!");
    public override void Eat() => Console.WriteLine("Blub nom Blub!");
    public void Swim() => Console.WriteLine("I Swam!");
    public override void Poops() => Console.WriteLine("I Pooped and im a goldfish!");

    public void Dive() => throw new NotImplementedException();

    public void TreadWater() => throw new NotImplementedException();

    public void SwimForward() => throw new NotImplementedException();

    public void SwimBackward() => throw new NotImplementedException();
}
