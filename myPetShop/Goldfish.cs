namespace myPetShop;

class Goldfish : Pet
{
    /* Constructor */
    public Goldfish(int id, string gender, string size, int age, 
        int numberOfLegs, string name, string description, 
        int price) : base(id, "Yellow", gender, size, age, numberOfLegs, name, description, price)
    {

    }

    /* Methods */
    public override void Sleep() => Console.WriteLine("zzz blub blub zzz!");

    public void Swim() => Console.WriteLine("I Swam!");
    public override void Poops() => Console.WriteLine("I Pooped and im a goldfish!");
}
